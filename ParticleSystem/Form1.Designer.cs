namespace ParticleSystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addEmitter = new System.Windows.Forms.Button();
            this.addLine = new System.Windows.Forms.Button();
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.tbAngle = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblSpreading = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.BackColor = System.Drawing.Color.Black;
            this.picDisplay.Location = new System.Drawing.Point(0, -2);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(826, 587);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.Click += new System.EventHandler(this.picDisplay_Click);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(832, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 587);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // addEmitter
            // 
            this.addEmitter.BackColor = System.Drawing.Color.Black;
            this.addEmitter.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.addEmitter.FlatAppearance.BorderSize = 3;
            this.addEmitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addEmitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmitter.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmitter.ForeColor = System.Drawing.Color.Magenta;
            this.addEmitter.Location = new System.Drawing.Point(845, 23);
            this.addEmitter.Name = "addEmitter";
            this.addEmitter.Size = new System.Drawing.Size(177, 52);
            this.addEmitter.TabIndex = 16;
            this.addEmitter.Text = "Частицы";
            this.addEmitter.UseVisualStyleBackColor = false;
            this.addEmitter.Click += new System.EventHandler(this.addEmitter_Click_1);
            // 
            // addLine
            // 
            this.addLine.BackColor = System.Drawing.Color.Black;
            this.addLine.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.addLine.FlatAppearance.BorderSize = 3;
            this.addLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLine.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addLine.ForeColor = System.Drawing.Color.Magenta;
            this.addLine.Location = new System.Drawing.Point(845, 81);
            this.addLine.Name = "addLine";
            this.addLine.Size = new System.Drawing.Size(177, 52);
            this.addLine.TabIndex = 17;
            this.addLine.Text = "Барьеры";
            this.addLine.UseVisualStyleBackColor = false;
            this.addLine.Click += new System.EventHandler(this.addLine_Click_1);
            // 
            // tbDirection
            // 
            this.tbDirection.BackColor = System.Drawing.Color.Black;
            this.tbDirection.Location = new System.Drawing.Point(845, 174);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(151, 45);
            this.tbDirection.TabIndex = 18;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll_1);
            // 
            // tbSpreading
            // 
            this.tbSpreading.BackColor = System.Drawing.Color.Black;
            this.tbSpreading.Location = new System.Drawing.Point(845, 235);
            this.tbSpreading.Maximum = 359;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(151, 45);
            this.tbSpreading.TabIndex = 19;
            this.tbSpreading.Scroll += new System.EventHandler(this.tbSpreading_Scroll_1);
            // 
            // tbAngle
            // 
            this.tbAngle.BackColor = System.Drawing.Color.Black;
            this.tbAngle.Location = new System.Drawing.Point(845, 302);
            this.tbAngle.Maximum = 359;
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(151, 45);
            this.tbAngle.TabIndex = 20;
            this.tbAngle.Scroll += new System.EventHandler(this.tbAngle_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(851, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Направление";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(851, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Разброс";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(851, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Угол наклона";
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.BackColor = System.Drawing.Color.Black;
            this.lblDirection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDirection.Location = new System.Drawing.Point(996, 186);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(13, 13);
            this.lblDirection.TabIndex = 24;
            this.lblDirection.Text = "0";
            // 
            // lblSpreading
            // 
            this.lblSpreading.AutoSize = true;
            this.lblSpreading.BackColor = System.Drawing.Color.Black;
            this.lblSpreading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSpreading.Location = new System.Drawing.Point(996, 250);
            this.lblSpreading.Name = "lblSpreading";
            this.lblSpreading.Size = new System.Drawing.Size(13, 13);
            this.lblSpreading.TabIndex = 25;
            this.lblSpreading.Text = "0";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.BackColor = System.Drawing.Color.Black;
            this.lblAngle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAngle.Location = new System.Drawing.Point(996, 314);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(13, 13);
            this.lblAngle.TabIndex = 26;
            this.lblAngle.Text = "0";
            // 
            // tbHeight
            // 
            this.tbHeight.BackColor = System.Drawing.Color.Black;
            this.tbHeight.Location = new System.Drawing.Point(845, 370);
            this.tbHeight.Maximum = 500;
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(151, 45);
            this.tbHeight.TabIndex = 27;
            this.tbHeight.Scroll += new System.EventHandler(this.tbHeight_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(851, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Высота";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.Black;
            this.lblHeight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeight.Location = new System.Drawing.Point(996, 381);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(13, 13);
            this.lblHeight.TabIndex = 29;
            this.lblHeight.Text = "0";
            // 
            // tbWidth
            // 
            this.tbWidth.BackColor = System.Drawing.Color.Black;
            this.tbWidth.Location = new System.Drawing.Point(845, 442);
            this.tbWidth.Maximum = 500;
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(151, 45);
            this.tbWidth.TabIndex = 30;
            this.tbWidth.Scroll += new System.EventHandler(this.tbWidth_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(851, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ширина";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.BackColor = System.Drawing.Color.Black;
            this.lblWidth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWidth.Location = new System.Drawing.Point(996, 458);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(13, 13);
            this.lblWidth.TabIndex = 32;
            this.lblWidth.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 580);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.lblSpreading);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAngle);
            this.Controls.Add(this.tbSpreading);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.addLine);
            this.Controls.Add(this.addEmitter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addEmitter;
        private System.Windows.Forms.Button addLine;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.TrackBar tbSpreading;
        private System.Windows.Forms.TrackBar tbAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblSpreading;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.TrackBar tbHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TrackBar tbWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWidth;
    }
}

