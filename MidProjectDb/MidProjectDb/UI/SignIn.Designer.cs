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
            this.signup_btn = new System.Windows.Forms.Button();
            this.forgotpassword_btn = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Controls.Add(this.forgotpassword_btn);
            this.panel1.Controls.Add(this.signinpassword_txtbox);
            this.panel1.Controls.Add(this.Password_lbl);
            this.panel1.Controls.Add(this.signinusername_txtbox);
            this.panel1.Controls.Add(this.Username_lbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // signup_btn
            // 
            this.signup_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signup_btn.Location = new System.Drawing.Point(512, 383);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(148, 55);
            this.signup_btn.TabIndex = 6;
            this.signup_btn.Text = "Not a user?";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // forgotpassword_btn
            // 
            this.forgotpassword_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.forgotpassword_btn.Location = new System.Drawing.Point(122, 383);
            this.forgotpassword_btn.Name = "forgotpassword_btn";
            this.forgotpassword_btn.Size = new System.Drawing.Size(141, 55);
            this.forgotpassword_btn.TabIndex = 5;
            this.forgotpassword_btn.Text = "Forgot Password?";
            this.forgotpassword_btn.UseVisualStyleBackColor = true;
            this.forgotpassword_btn.Click += new System.EventHandler(this.forgotpassword_btn_Click);
            // 
            // signinpassword_txtbox
            // 
            this.signinpassword_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signinpassword_txtbox.Location = new System.Drawing.Point(64, 326);
            this.signinpassword_txtbox.Name = "signinpassword_txtbox";
            this.signinpassword_txtbox.Size = new System.Drawing.Size(677, 22);
            this.signinpassword_txtbox.TabIndex = 4;
            this.signinpassword_txtbox.UseSystemPasswordChar = true;
            // 
            // Password_lbl
            // 
            this.Password_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.Location = new System.Drawing.Point(58, 276);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(221, 32);
            this.Password_lbl.TabIndex = 3;
            this.Password_lbl.Text = "Enter Password:";
            // 
            // signinusername_txtbox
            // 
            this.signinusername_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signinusername_txtbox.Location = new System.Drawing.Point(64, 218);
            this.signinusername_txtbox.Name = "signinusername_txtbox";
            this.signinusername_txtbox.Size = new System.Drawing.Size(677, 22);
            this.signinusername_txtbox.TabIndex = 2;
            // 
            // Username_lbl
            // 
            this.Username_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.Location = new System.Drawing.Point(58, 174);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(227, 32);
            this.Username_lbl.TabIndex = 1;
            this.Username_lbl.Text = "Enter Username:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.Signin_lbl);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 139);
            this.panel2.TabIndex = 0;
            // 
            // Signin_lbl
            // 
            this.Signin_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Signin_lbl.AutoSize = true;
            this.Signin_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.Signin_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Signin_lbl.Location = new System.Drawing.Point(305, 45);
            this.Signin_lbl.Name = "Signin_lbl";
            this.Signin_lbl.Size = new System.Drawing.Size(156, 49);
            this.Signin_lbl.TabIndex = 1;
            this.Signin_lbl.Text = "Sign In";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SignIn";
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
        private System.Windows.Forms.Button forgotpassword_btn;
        private System.Windows.Forms.Button signup_btn;
    }
}