namespace MidProjectDb.UI
{
    partial class SignIn
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
            this.forgot_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Next_btn = new Guna.UI2.WinForms.Guna2Button();
            this.signinpassword_txtbox = new System.Windows.Forms.TextBox();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.signinusername_txtbox = new System.Windows.Forms.TextBox();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Signin_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.forgot_btn);
            this.panel1.Controls.Add(this.Next_btn);
            this.panel1.Controls.Add(this.signinpassword_txtbox);
            this.panel1.Controls.Add(this.Password_lbl);
            this.panel1.Controls.Add(this.signinusername_txtbox);
            this.panel1.Controls.Add(this.Username_lbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 741);
            this.panel1.TabIndex = 0;
            // 
            // forgot_btn
            // 
            this.forgot_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.forgot_btn.BorderRadius = 20;
            this.forgot_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.forgot_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.forgot_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.forgot_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.forgot_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.forgot_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_btn.ForeColor = System.Drawing.Color.White;
            this.forgot_btn.Location = new System.Drawing.Point(649, 383);
            this.forgot_btn.Name = "forgot_btn";
            this.forgot_btn.Size = new System.Drawing.Size(174, 64);
            this.forgot_btn.TabIndex = 16;
            this.forgot_btn.Text = "Forgot Password?";
            this.forgot_btn.Click += new System.EventHandler(this.forgot_btn_Click);
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
            this.Next_btn.Location = new System.Drawing.Point(1119, 383);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(174, 64);
            this.Next_btn.TabIndex = 15;
            this.Next_btn.Text = "Next";
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // signinpassword_txtbox
            // 
            this.signinpassword_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signinpassword_txtbox.Location = new System.Drawing.Point(626, 326);
            this.signinpassword_txtbox.Name = "signinpassword_txtbox";
            this.signinpassword_txtbox.Size = new System.Drawing.Size(677, 22);
            this.signinpassword_txtbox.TabIndex = 4;
            this.signinpassword_txtbox.UseSystemPasswordChar = true;
            // 
            // Password_lbl
            // 
            this.Password_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.Location = new System.Drawing.Point(620, 276);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(221, 32);
            this.Password_lbl.TabIndex = 3;
            this.Password_lbl.Text = "Enter Password:";
            // 
            // signinusername_txtbox
            // 
            this.signinusername_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signinusername_txtbox.Location = new System.Drawing.Point(626, 218);
            this.signinusername_txtbox.Name = "signinusername_txtbox";
            this.signinusername_txtbox.Size = new System.Drawing.Size(677, 22);
            this.signinusername_txtbox.TabIndex = 2;
            // 
            // Username_lbl
            // 
            this.Username_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.Location = new System.Drawing.Point(620, 174);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(227, 32);
            this.Username_lbl.TabIndex = 1;
            this.Username_lbl.Text = "Enter Username:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Signin_lbl);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 142);
            this.panel2.TabIndex = 0;
            // 
            // Signin_lbl
            // 
            this.Signin_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Signin_lbl.AutoSize = true;
            this.Signin_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.Signin_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Signin_lbl.Location = new System.Drawing.Point(867, 45);
            this.Signin_lbl.Name = "Signin_lbl";
            this.Signin_lbl.Size = new System.Drawing.Size(156, 49);
            this.Signin_lbl.TabIndex = 1;
            this.Signin_lbl.Text = "Sign In";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 741);
            this.Controls.Add(this.panel1);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Signin_lbl;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.TextBox signinusername_txtbox;
        private System.Windows.Forms.TextBox signinpassword_txtbox;
        private System.Windows.Forms.Label Password_lbl;
        private Guna.UI2.WinForms.Guna2Button forgot_btn;
        private Guna.UI2.WinForms.Guna2Button Next_btn;
    }
}