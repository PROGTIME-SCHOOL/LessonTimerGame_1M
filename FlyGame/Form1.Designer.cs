﻿namespace FlyGame
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
            this.buttonFly = new System.Windows.Forms.Button();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFly
            // 
            this.buttonFly.Location = new System.Drawing.Point(191, 185);
            this.buttonFly.Name = "buttonFly";
            this.buttonFly.Size = new System.Drawing.Size(80, 63);
            this.buttonFly.TabIndex = 0;
            this.buttonFly.Text = "FLY";
            this.buttonFly.UseVisualStyleBackColor = true;
            this.buttonFly.Click += new System.EventHandler(this.buttonFly_Click);
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(92, 25);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score: 0";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(12, 34);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(102, 25);
            this.labelTimer.TabIndex = 2;
            this.labelTimer.Text = "Timer: 10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 429);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonFly);
            this.Name = "Form1";
            this.Text = "Fly Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFly;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelTimer;
    }
}

