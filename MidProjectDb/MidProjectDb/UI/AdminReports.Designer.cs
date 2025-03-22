namespace MidProjectDb.UI
{
    partial class AdminReports
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
            this.Inventort_btn = new Guna.UI2.WinForms.Guna2Button();
            this.logout_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Department_lbl = new System.Windows.Forms.Label();
            this.req_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.Inventort_btn);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.req_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1690, 755);
            this.panel1.TabIndex = 1;
            // 
            // Inventort_btn
            // 
            this.Inventort_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Inventort_btn.BorderRadius = 20;
            this.Inventort_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Inventort_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Inventort_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Inventort_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Inventort_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Inventort_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventort_btn.ForeColor = System.Drawing.Color.White;
            this.Inventort_btn.Location = new System.Drawing.Point(607, 376);
            this.Inventort_btn.Name = "Inventort_btn";
            this.Inventort_btn.Size = new System.Drawing.Size(496, 45);
            this.Inventort_btn.TabIndex = 15;
            this.Inventort_btn.Text = "Inventory Report";
            this.Inventort_btn.Click += new System.EventHandler(this.Inventort_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logout_btn.BorderRadius = 20;
            this.logout_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logout_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logout_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logout_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logout_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.logout_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(607, 450);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(496, 45);
            this.logout_btn.TabIndex = 14;
            this.logout_btn.Text = "Go Back";
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Department_lbl);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1684, 142);
            this.panel2.TabIndex = 3;
            // 
            // Department_lbl
            // 
            this.Department_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Department_lbl.AutoSize = true;
            this.Department_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.Department_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Department_lbl.Location = new System.Drawing.Point(741, 50);
            this.Department_lbl.Name = "Department_lbl";
            this.Department_lbl.Size = new System.Drawing.Size(167, 49);
            this.Department_lbl.TabIndex = 1;
            this.Department_lbl.Text = "Reports";
            // 
            // req_btn
            // 
            this.req_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.req_btn.BorderRadius = 20;
            this.req_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.req_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.req_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.req_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.req_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.req_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.req_btn.ForeColor = System.Drawing.Color.White;
            this.req_btn.Location = new System.Drawing.Point(607, 299);
            this.req_btn.Name = "req_btn";
            this.req_btn.Size = new System.Drawing.Size(496, 45);
            this.req_btn.TabIndex = 12;
            this.req_btn.Text = "Faculty Requests Summary Report";
            this.req_btn.Click += new System.EventHandler(this.req_btn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(607, 208);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(496, 45);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "Faculty Report";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // AdminReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 755);
            this.Controls.Add(this.panel1);
            this.Name = "AdminReports";
            this.Text = "AdminReports";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Inventort_btn;
        private Guna.UI2.WinForms.Guna2Button logout_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Department_lbl;
        private Guna.UI2.WinForms.Guna2Button req_btn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}