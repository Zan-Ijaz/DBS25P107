namespace MidProjectDb
{
    partial class firstinterface
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
            this.Signup_btn = new System.Windows.Forms.Button();
            this.SignIn_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Welcome_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Signup_btn);
            this.panel1.Controls.Add(this.SignIn_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // Signup_btn
            // 
            this.Signup_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Signup_btn.Location = new System.Drawing.Point(142, 340);
            this.Signup_btn.Name = "Signup_btn";
            this.Signup_btn.Size = new System.Drawing.Size(496, 53);
            this.Signup_btn.TabIndex = 3;
            this.Signup_btn.Text = "Sign up";
            this.Signup_btn.UseVisualStyleBackColor = true;
            this.Signup_btn.Click += new System.EventHandler(this.Signup_btn_Click);
            // 
            // SignIn_btn
            // 
            this.SignIn_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignIn_btn.Location = new System.Drawing.Point(142, 246);
            this.SignIn_btn.Name = "SignIn_btn";
            this.SignIn_btn.Size = new System.Drawing.Size(496, 53);
            this.SignIn_btn.TabIndex = 2;
            this.SignIn_btn.Text = "Sign In";
            this.SignIn_btn.UseVisualStyleBackColor = true;
            this.SignIn_btn.Click += new System.EventHandler(this.SignIn_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "What would you like to do?";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.Welcome_lbl);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 125);
            this.panel2.TabIndex = 1;
            // 
            // Welcome_lbl
            // 
            this.Welcome_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Welcome_lbl.AutoSize = true;
            this.Welcome_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.Welcome_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Welcome_lbl.Location = new System.Drawing.Point(307, 47);
            this.Welcome_lbl.Name = "Welcome_lbl";
            this.Welcome_lbl.Size = new System.Drawing.Size(190, 49);
            this.Welcome_lbl.TabIndex = 0;
            this.Welcome_lbl.Text = "Welcome";
            // 
            // firstinterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "firstinterface";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Welcome_lbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Signup_btn;
        private System.Windows.Forms.Button SignIn_btn;
    }
}

