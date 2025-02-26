namespace MidProjectDb.UI
{
    partial class Signup
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.signup_lbl = new System.Windows.Forms.Label();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.signupusername_txtbox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.signup_lbl);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 125);
            this.panel2.TabIndex = 2;
            // 
            // signup_lbl
            // 
            this.signup_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signup_lbl.AutoSize = true;
            this.signup_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.signup_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signup_lbl.Location = new System.Drawing.Point(307, 47);
            this.signup_lbl.Name = "signup_lbl";
            this.signup_lbl.Size = new System.Drawing.Size(163, 49);
            this.signup_lbl.TabIndex = 0;
            this.signup_lbl.Text = "Sign up";
            // 
            // Username_lbl
            // 
            this.Username_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.Location = new System.Drawing.Point(70, 145);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(227, 32);
            this.Username_lbl.TabIndex = 3;
            this.Username_lbl.Text = "Enter Username:";
            // 
            // signupusername_txtbox
            // 
            this.signupusername_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signupusername_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupusername_txtbox.Location = new System.Drawing.Point(76, 190);
            this.signupusername_txtbox.Multiline = true;
            this.signupusername_txtbox.Name = "signupusername_txtbox";
            this.signupusername_txtbox.Size = new System.Drawing.Size(677, 39);
            this.signupusername_txtbox.TabIndex = 4;
            this.signupusername_txtbox.Text = "Password must be atleast 8 characters";
            this.signupusername_txtbox.UseSystemPasswordChar = true;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signupusername_txtbox);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.panel2);
            this.Name = "Signup";
            this.Text = "Signup";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label signup_lbl;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.TextBox signupusername_txtbox;
    }
}