namespace MidProjectDb.UI
{
    partial class Reports
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
            this.Department_lbl = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.logout_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Allocation_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Approvereq_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Assignworkload_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Allocation_btn);
            this.panel1.Controls.Add(this.Assignworkload_btn);
            this.panel1.Controls.Add(this.Approvereq_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 659);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Department_lbl);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1336, 142);
            this.panel2.TabIndex = 3;
            // 
            // Department_lbl
            // 
            this.Department_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Department_lbl.AutoSize = true;
            this.Department_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.Department_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Department_lbl.Location = new System.Drawing.Point(567, 50);
            this.Department_lbl.Name = "Department_lbl";
            this.Department_lbl.Size = new System.Drawing.Size(167, 49);
            this.Department_lbl.TabIndex = 1;
            this.Department_lbl.Text = "Reports";
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
            this.guna2Button1.Location = new System.Drawing.Point(433, 421);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(496, 45);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "Faculty Role Distribution Report";
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
            this.logout_btn.Location = new System.Drawing.Point(433, 483);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(496, 45);
            this.logout_btn.TabIndex = 14;
            this.logout_btn.Text = "Go Back";
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // Allocation_btn
            // 
            this.Allocation_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Allocation_btn.BorderRadius = 20;
            this.Allocation_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Allocation_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Allocation_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Allocation_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Allocation_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Allocation_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allocation_btn.ForeColor = System.Drawing.Color.White;
            this.Allocation_btn.Location = new System.Drawing.Point(433, 358);
            this.Allocation_btn.Name = "Allocation_btn";
            this.Allocation_btn.Size = new System.Drawing.Size(496, 45);
            this.Allocation_btn.TabIndex = 13;
            this.Allocation_btn.Text = "Most Requested Resources Report";
            // 
            // Approvereq_btn
            // 
            this.Approvereq_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Approvereq_btn.BorderRadius = 20;
            this.Approvereq_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Approvereq_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Approvereq_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Approvereq_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Approvereq_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Approvereq_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Approvereq_btn.ForeColor = System.Drawing.Color.White;
            this.Approvereq_btn.Location = new System.Drawing.Point(433, 282);
            this.Approvereq_btn.Name = "Approvereq_btn";
            this.Approvereq_btn.Size = new System.Drawing.Size(496, 45);
            this.Approvereq_btn.TabIndex = 12;
            this.Approvereq_btn.Text = "Faculty Requests Summary Report";
            // 
            // Assignworkload_btn
            // 
            this.Assignworkload_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Assignworkload_btn.BorderRadius = 20;
            this.Assignworkload_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Assignworkload_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Assignworkload_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Assignworkload_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Assignworkload_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Assignworkload_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assignworkload_btn.ForeColor = System.Drawing.Color.White;
            this.Assignworkload_btn.Location = new System.Drawing.Point(433, 212);
            this.Assignworkload_btn.Name = "Assignworkload_btn";
            this.Assignworkload_btn.Size = new System.Drawing.Size(496, 45);
            this.Assignworkload_btn.TabIndex = 11;
            this.Assignworkload_btn.Text = "Faculty Workload Report";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1342, 659);
            this.Controls.Add(this.panel1);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Department_lbl;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button logout_btn;
        private Guna.UI2.WinForms.Guna2Button Allocation_btn;
        private Guna.UI2.WinForms.Guna2Button Assignworkload_btn;
        private Guna.UI2.WinForms.Guna2Button Approvereq_btn;
    }
}