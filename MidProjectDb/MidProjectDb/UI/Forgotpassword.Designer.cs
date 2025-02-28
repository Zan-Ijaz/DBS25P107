namespace MidProjectDb.UI
{
    partial class Forgotpassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Signin_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Next_btn = new Guna.UI2.WinForms.Guna2Button();
            this.forgotemail_txtbox = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.forgotuser_txtbox = new System.Windows.Forms.TextBox();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.forgotpassword_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Signin_btn);
            this.panel1.Controls.Add(this.Next_btn);
            this.panel1.Controls.Add(this.forgotemail_txtbox);
            this.panel1.Controls.Add(this.email_lbl);
            this.panel1.Controls.Add(this.forgotuser_txtbox);
            this.panel1.Controls.Add(this.Username_lbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // Signin_btn
            // 
            this.Signin_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Signin_btn.BorderRadius = 20;
            this.Signin_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Signin_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Signin_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Signin_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Signin_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Signin_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin_btn.ForeColor = System.Drawing.Color.White;
            this.Signin_btn.Location = new System.Drawing.Point(100, 348);
            this.Signin_btn.Name = "Signin_btn";
            this.Signin_btn.Size = new System.Drawing.Size(174, 55);
            this.Signin_btn.TabIndex = 17;
            this.Signin_btn.Text = "Sign in with old password?";
            this.Signin_btn.Click += new System.EventHandler(this.Signin_btn_Click);
            // 
            // Next_btn
            // 
            this.Next_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Next_btn.BorderRadius = 20;
            this.Next_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Next_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Next_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Next_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Next_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Next_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_btn.ForeColor = System.Drawing.Color.White;
            this.Next_btn.Location = new System.Drawing.Point(478, 348);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(174, 55);
            this.Next_btn.TabIndex = 16;
            this.Next_btn.Text = "Next";
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click_1);
            // 
            // forgotemail_txtbox
            // 
            this.forgotemail_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.forgotemail_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotemail_txtbox.Location = new System.Drawing.Point(53, 269);
            this.forgotemail_txtbox.Name = "forgotemail_txtbox";
            this.forgotemail_txtbox.Size = new System.Drawing.Size(670, 27);
            this.forgotemail_txtbox.TabIndex = 9;
            // 
            // email_lbl
            // 
            this.email_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(47, 234);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(169, 32);
            this.email_lbl.TabIndex = 8;
            this.email_lbl.Text = "Enter Email:";
            // 
            // forgotuser_txtbox
            // 
            this.forgotuser_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.forgotuser_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotuser_txtbox.Location = new System.Drawing.Point(53, 204);
            this.forgotuser_txtbox.Name = "forgotuser_txtbox";
            this.forgotuser_txtbox.Size = new System.Drawing.Size(670, 27);
            this.forgotuser_txtbox.TabIndex = 7;
            // 
            // Username_lbl
            // 
            this.Username_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.Location = new System.Drawing.Point(47, 169);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(227, 32);
            this.Username_lbl.TabIndex = 4;
            this.Username_lbl.Text = "Enter Username:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.forgotpassword_lbl);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 139);
            this.panel2.TabIndex = 1;
            // 
            // forgotpassword_lbl
            // 
            this.forgotpassword_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.forgotpassword_lbl.AutoSize = true;
            this.forgotpassword_lbl.BackColor = System.Drawing.Color.Transparent;
            this.forgotpassword_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpassword_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.forgotpassword_lbl.Location = new System.Drawing.Point(251, 50);
            this.forgotpassword_lbl.Name = "forgotpassword_lbl";
            this.forgotpassword_lbl.Size = new System.Drawing.Size(332, 49);
            this.forgotpassword_lbl.TabIndex = 1;
            this.forgotpassword_lbl.Text = "Forgot Password";
            // 
            // Forgotpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Forgotpassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgotpassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label forgotpassword_lbl;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.TextBox forgotuser_txtbox;
        private System.Windows.Forms.TextBox forgotemail_txtbox;
        private System.Windows.Forms.Label email_lbl;
        private Guna.UI2.WinForms.Guna2Button Next_btn;
        private Guna.UI2.WinForms.Guna2Button Signin_btn;
    }
}