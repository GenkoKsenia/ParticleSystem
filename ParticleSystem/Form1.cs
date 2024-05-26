using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ParticleSystem.Particle;

namespace ParticleSystem
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        List<IImpactPoint> iimpactPoints = new List<IImpactPoint>();

        Emitter activeEmitter = null;
        ReflectionLine activeLine = null;
               

        public Form1()
        {
            InitializeComponent();

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
                       

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);

                foreach (var emitter in emitters)
                {
                    emitter.UpdateState();
                    emitter.Render(g);
                }

                if (activeEmitter != null)
                {
                    activeEmitter.UpdateState();
                    activeEmitter.Render(g);
                }
            }

            picDisplay.Invalidate();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeEmitter != null)
            {
                activeEmitter.X = e.X;
                activeEmitter.Y = e.Y;
            }

            if(activeLine != null)
            {
                activeLine.X = e.X;
                activeLine.Y = e.Y;  
            }
        }             

              

        private void picDisplay_Click(object sender, EventArgs e)
        {
            if (activeEmitter != null)
            {
                emitters.Add(activeEmitter);                
                activeEmitter = null; // Сбрасываем активный эмиттер после фиксации
            }

            if (activeLine != null)
            {
                iimpactPoints.Add(activeLine);               
                activeLine = null; // Сбрасываем активный эмиттер после фиксации
            }
        }       

        private void addNewEmitter()
        {            
            foreach (var iimpactPoint in iimpactPoints)
            {
                activeEmitter.impactPoints.Add(iimpactPoint);
            }
            
        }

        private void addNewLine()
        {
            foreach (var emitter in emitters)
            {
                emitter.impactPoints.Add(activeLine);                
            }
        }

        private void addEmitter_Click_1(object sender, EventArgs e)
        {
            if(activeLine == null) {
                activeEmitter = new Emitter
                {
                    Direction = 270,
                    Spreading = 0,
                    SpeedMin = 10,
                    SpeedMax = 10,
                    ColorFrom = Color.Gold,
                    ColorTo = Color.FromArgb(0, Color.Red),
                    ParticlesPerTick = 10,
                    X = picDisplay.Width / 2,
                    Y = picDisplay.Height / 2,
                };
                addNewEmitter();
            }
        }

        private void addLine_Click_1(object sender, EventArgs e)
        {
            if (activeEmitter == null) {
                activeLine = new ReflectionLine
                {
                    X = picDisplay.Width / 2,
                    Y = picDisplay.Height / 2,
                    Width = 100,
                    Height = 20,
                    Angle = 0,
                };
                addNewLine();

            }
        }

        private void tbDirection_Scroll_1(object sender, EventArgs e)
        {
            if (activeEmitter != null)
            {
                activeEmitter.Direction = tbDirection.Value;
                lblDirection.Text = $"{tbDirection.Value}°";
            }
        }

        private void tbSpreading_Scroll_1(object sender, EventArgs e)
        {
            if (activeEmitter != null)
            {
                activeEmitter.Spreading = tbSpreading.Value;
                lblSpreading.Text = $"{tbSpreading.Value}°";
            }
        }       

        private void tbAngle_Scroll(object sender, EventArgs e)
        {
            if (activeLine != null)
            {
                activeLine.Angle = tbAngle.Value;
                lblAngle.Text = $"{tbAngle.Value}°";
            }
        }

        private void tbHeight_Scroll(object sender, EventArgs e)
        {
            if (activeLine != null)
            {
                activeLine.Height = tbHeight.Value;
                lblHeight.Text = $"{tbHeight.Value}°";
            }
        }

        private void tbWidth_Scroll(object sender, EventArgs e)
        {
            if (activeLine != null)
            {
                activeLine.Width = tbWidth.Value;
                lblWidth.Text = $"{tbWidth.Value}°";
            }
        }
    }
    
}
