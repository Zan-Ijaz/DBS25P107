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
            this.panel2 = new System.Windows.Forms.Panel();
            this.forgotpassword_lbl = new System.Windows.Forms.Label();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.forgotuser_txtbox = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.forgotemail_txtbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
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
            this.forgotpassword_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.forgotpassword_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpassword_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.forgotpassword_lbl.Location = new System.Drawing.Point(251, 50);
            this.forgotpassword_lbl.Name = "forgotpassword_lbl";
            this.forgotpassword_lbl.Size = new System.Drawing.Size(332, 49);
            this.forgotpassword_lbl.TabIndex = 1;
            this.forgotpassword_lbl.Text = "Forgot Password";
            // 
            // Username_lbl
            // 
            this.Username_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.Location = new System.Drawing.Point(47, 169);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(227, 32);
            this.Username_lbl.TabIndex = 4;
            this.Username_lbl.Text = "Enter Username:";
            // 
            // forgotuser_txtbox
            // 
            this.forgotuser_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forgotuser_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotuser_txtbox.Location = new System.Drawing.Point(53, 204);
            this.forgotuser_txtbox.Name = "forgotuser_txtbox";
            this.forgotuser_txtbox.Size = new System.Drawing.Size(670, 27);
            this.forgotuser_txtbox.TabIndex = 7;
            // 
            // email_lbl
            // 
            this.email_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(47, 234);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(169, 32);
            this.email_lbl.TabIndex = 8;
            this.email_lbl.Text = "Enter Email:";
            // 
            // forgotemail_txtbox
            // 
            this.forgotemail_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forgotemail_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotemail_txtbox.Location = new System.Drawing.Point(53, 269);
            this.forgotemail_txtbox.Name = "forgotemail_txtbox";
            this.forgotemail_txtbox.Size = new System.Drawing.Size(670, 27);
            this.forgotemail_txtbox.TabIndex = 9;
            // 
            // Forgotpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Forgotpassword";
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
    }
}