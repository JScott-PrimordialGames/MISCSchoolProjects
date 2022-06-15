namespace SuperHero
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_Heros = new System.Windows.Forms.ListBox();
            this.TXB_Profile = new System.Windows.Forms.TextBox();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heroes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profile";
            // 
            // LB_Heros
            // 
            this.LB_Heros.FormattingEnabled = true;
            this.LB_Heros.Location = new System.Drawing.Point(34, 42);
            this.LB_Heros.Name = "LB_Heros";
            this.LB_Heros.Size = new System.Drawing.Size(130, 108);
            this.LB_Heros.TabIndex = 2;
            this.LB_Heros.SelectedIndexChanged += new System.EventHandler(this.LB_Heros_SelectedIndexChanged);
            // 
            // TXB_Profile
            // 
            this.TXB_Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Profile.Location = new System.Drawing.Point(245, 42);
            this.TXB_Profile.Multiline = true;
            this.TXB_Profile.Name = "TXB_Profile";
            this.TXB_Profile.ReadOnly = true;
            this.TXB_Profile.Size = new System.Drawing.Size(302, 108);
            this.TXB_Profile.TabIndex = 3;
            // 
            // BTN_OK
            // 
            this.BTN_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_OK.Location = new System.Drawing.Point(52, 155);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 27);
            this.BTN_OK.TabIndex = 4;
            this.BTN_OK.Text = "Ok";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 184);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.TXB_Profile);
            this.Controls.Add(this.LB_Heros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LB_Heros;
        private System.Windows.Forms.TextBox TXB_Profile;
        private System.Windows.Forms.Button BTN_OK;
    }
}