using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    internal class ReflectionLine : IImpactPoint
    {
        public float Width = 100;
        public float Height = 20;
        public float Angle; // угол наклона прямоугольника в радианах

        public override void ImpactParticle(Particle particle)
        {
            // Определяем центр прямоугольника
            float centerX = X + Width / 2;
            float centerY = Y + Height / 2;

            // Смещаем координаты частицы в систему координат прямоугольника
            float dx = particle.X - centerX;
            float dy = particle.Y - centerY;

            // Поворачиваем систему координат на угол -Angle
            float rotatedX = (float)(dx * Math.Cos(-Angle) - dy * Math.Sin(-Angle));
            float rotatedY = (float)(dx * Math.Sin(-Angle) + dy * Math.Cos(-Angle));

            // Проверяем столкновение в новой системе координат
            bool collided = false;
            float normalX = 0;
            float normalY = 0;

            // Проверка столкновения с левой и правой стенками
            if (rotatedX >= -Width / 2 - particle.Radius && rotatedX <= Width / 2 + particle.Radius)
            {
                if (rotatedY >= -Height / 2 && rotatedY <= Height / 2)
                {
                    if (rotatedX - particle.Radius < -Width / 2)
                    {
                        normalX = -1;
                        normalY = 0;
                        collided = true;
                    }
                    else if (rotatedX + particle.Radius > Width / 2)
                    {
                        normalX = 1;
                        normalY = 0;
                        collided = true;
                    }
                }
            }

            // Проверка столкновения с верхней и нижней стенками
            if (rotatedY >= -Height / 2 - particle.Radius && rotatedY <= Height / 2 + particle.Radius)
            {
                if (rotatedX >= -Width / 2 && rotatedX <= Width / 2)
                {
                    if (rotatedY - particle.Radius < -Height / 2)
                    {
                        normalX = 0;
                        normalY = -1;
                        collided = true;
                    }
                    else if (rotatedY + particle.Radius > Height / 2)
                    {
                        normalX = 0;
                        normalY = 1;
                        collided = true;
                    }
                }
            }

            // Если столкновение произошло, вычисляем отраженный вектор
            if (collided)
            {
                // Вектор скорости частицы
                float vX = particle.SpeedX;
                float vY = particle.SpeedY;

                // Поворачиваем нормаль обратно в исходную систему координат
                float globalNormalX = (float)(normalX * Math.Cos(Angle) - normalY * Math.Sin(Angle));
                float globalNormalY = (float)(normalX * Math.Sin(Angle) + normalY * Math.Cos(Angle));

                // Проекция вектора скорости на нормальный вектор
                float dotProduct = vX * globalNormalX + vY * globalNormalY;

                // Вычисляем отражённый вектор
                float reflectedVx = vX - 2 * dotProduct * globalNormalX;
                float reflectedVy = vY - 2 * dotProduct * globalNormalY;

                // Применяем новый вектор скорости к частице
                particle.SpeedX = reflectedVx;
                particle.SpeedY = reflectedVy;
            }
        }

        public override void Render(Graphics g)
        {
            // Сохранить состояние графики
            var state = g.Save();

            // Перемещаем систему координат в центр прямоугольника и поворачиваем её
            g.TranslateTransform(X + Width / 2, Y + Height / 2);
            g.RotateTransform(Angle * (float)(180 / Math.PI));

            // Рисуем прямоугольник, центрированный в новой системе координат
            g.DrawRectangle(
                new Pen(Color.Red),
                -Width/2,
                -Height/2,
                Width,
                Height
            );

            // Восстановить предыдущее состояние графики
            g.Restore(state);
        }
    }
}
