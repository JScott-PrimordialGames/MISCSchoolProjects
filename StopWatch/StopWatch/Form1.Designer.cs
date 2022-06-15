namespace StopWatch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LBL_Timer = new System.Windows.Forms.Label();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBL_CurrentScore = new System.Windows.Forms.Label();
            this.LBL_Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HitBox = new System.Windows.Forms.PictureBox();
            this.LBL_HighScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_Lives = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Timer
            // 
            this.LBL_Timer.AutoSize = true;
            this.LBL_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Timer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_Timer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBL_Timer.Location = new System.Drawing.Point(90, 11);
            this.LBL_Timer.Name = "LBL_Timer";
            this.LBL_Timer.Size = new System.Drawing.Size(35, 37);
            this.LBL_Timer.TabIndex = 0;
            this.LBL_Timer.Text = "0";
            this.LBL_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_Start
            // 
            this.BTN_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Start.Location = new System.Drawing.Point(245, 498);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(113, 37);
            this.BTN_Start.TabIndex = 1;
            this.BTN_Start.Text = "Start Game";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LBL_CurrentScore
            // 
            this.LBL_CurrentScore.AutoSize = true;
            this.LBL_CurrentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CurrentScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_CurrentScore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBL_CurrentScore.Location = new System.Drawing.Point(105, 48);
            this.LBL_CurrentScore.Name = "LBL_CurrentScore";
            this.LBL_CurrentScore.Size = new System.Drawing.Size(35, 37);
            this.LBL_CurrentScore.TabIndex = 5;
            this.LBL_CurrentScore.Text = "0";
            this.LBL_CurrentScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Time
            // 
            this.LBL_Time.AutoSize = true;
            this.LBL_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_Time.Location = new System.Drawing.Point(5, 9);
            this.LBL_Time.Name = "LBL_Time";
            this.LBL_Time.Size = new System.Drawing.Size(106, 37);
            this.LBL_Time.TabIndex = 6;
            this.LBL_Time.Text = "Time: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score:";
            // 
            // HitBox
            // 
            this.HitBox.Image = global::StopWatch.Properties.Resources.Valkyrie;
            this.HitBox.Location = new System.Drawing.Point(257, 218);
            this.HitBox.Name = "HitBox";
            this.HitBox.Size = new System.Drawing.Size(90, 100);
            this.HitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HitBox.TabIndex = 8;
            this.HitBox.TabStop = false;
            this.HitBox.Click += new System.EventHandler(this.Hit);
            // 
            // LBL_HighScore
            // 
            this.LBL_HighScore.AutoSize = true;
            this.LBL_HighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HighScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_HighScore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBL_HighScore.Location = new System.Drawing.Point(415, 11);
            this.LBL_HighScore.Name = "LBL_HighScore";
            this.LBL_HighScore.Size = new System.Drawing.Size(35, 37);
            this.LBL_HighScore.TabIndex = 9;
            this.LBL_HighScore.Text = "0";
            this.LBL_HighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(248, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "HighScore:";
            // 
            // LBL_Lives
            // 
            this.LBL_Lives.AutoSize = true;
            this.LBL_Lives.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Lives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_Lives.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBL_Lives.Location = new System.Drawing.Point(333, 48);
            this.LBL_Lives.Name = "LBL_Lives";
            this.LBL_Lives.Size = new System.Drawing.Size(35, 37);
            this.LBL_Lives.TabIndex = 11;
            this.LBL_Lives.Text = "0";
            this.LBL_Lives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(248, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lives:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(591, 547);
            this.Controls.Add(this.LBL_Lives);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBL_HighScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HitBox);
            this.Controls.Add(this.LBL_CurrentScore);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.LBL_Timer);
            this.Controls.Add(this.LBL_Time);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.HitBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Timer;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBL_CurrentScore;
        private System.Windows.Forms.Label LBL_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox HitBox;
        private System.Windows.Forms.Label LBL_HighScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_Lives;
        private System.Windows.Forms.Label label5;
    }
}

