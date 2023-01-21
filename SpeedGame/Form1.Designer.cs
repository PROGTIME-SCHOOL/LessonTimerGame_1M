namespace SpeedGame
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
            this.pictureBoxCar1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar4 = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCar1
            // 
            this.pictureBoxCar1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCar1.Image = global::SpeedGame.Properties.Resources.car2;
            this.pictureBoxCar1.Location = new System.Drawing.Point(32, 100);
            this.pictureBoxCar1.Name = "pictureBoxCar1";
            this.pictureBoxCar1.Size = new System.Drawing.Size(146, 68);
            this.pictureBoxCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar1.TabIndex = 0;
            this.pictureBoxCar1.TabStop = false;
            // 
            // pictureBoxCar2
            // 
            this.pictureBoxCar2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCar2.Image = global::SpeedGame.Properties.Resources.car2_pink;
            this.pictureBoxCar2.Location = new System.Drawing.Point(32, 229);
            this.pictureBoxCar2.Name = "pictureBoxCar2";
            this.pictureBoxCar2.Size = new System.Drawing.Size(146, 68);
            this.pictureBoxCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar2.TabIndex = 1;
            this.pictureBoxCar2.TabStop = false;
            // 
            // pictureBoxCar3
            // 
            this.pictureBoxCar3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCar3.Image = global::SpeedGame.Properties.Resources.car2_green;
            this.pictureBoxCar3.Location = new System.Drawing.Point(32, 357);
            this.pictureBoxCar3.Name = "pictureBoxCar3";
            this.pictureBoxCar3.Size = new System.Drawing.Size(146, 68);
            this.pictureBoxCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar3.TabIndex = 2;
            this.pictureBoxCar3.TabStop = false;
            // 
            // pictureBoxCar4
            // 
            this.pictureBoxCar4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCar4.Image = global::SpeedGame.Properties.Resources.car2_yellow;
            this.pictureBoxCar4.Location = new System.Drawing.Point(32, 487);
            this.pictureBoxCar4.Name = "pictureBoxCar4";
            this.pictureBoxCar4.Size = new System.Drawing.Size(146, 68);
            this.pictureBoxCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar4.TabIndex = 3;
            this.pictureBoxCar4.TabStop = false;
            // 
            // timerGame
            // 
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Enabled = false;
            this.buttonFinish.Location = new System.Drawing.Point(1018, 100);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(10, 439);
            this.buttonFinish.TabIndex = 4;
            this.buttonFinish.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(4, 583);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(192, 60);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(202, 583);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeedGame.Properties.Resources.road_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1127, 653);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxCar4);
            this.Controls.Add(this.pictureBoxCar3);
            this.Controls.Add(this.pictureBoxCar2);
            this.Controls.Add(this.pictureBoxCar1);
            this.Controls.Add(this.buttonFinish);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Speed Game v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCar1;
        private System.Windows.Forms.PictureBox pictureBoxCar2;
        private System.Windows.Forms.PictureBox pictureBoxCar3;
        private System.Windows.Forms.PictureBox pictureBoxCar4;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

