namespace MidProjectDb.UI
{
    partial class DepartmentHead
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
            this.Allocation_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Approvereq_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Assignworkload_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Department_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Allocation_btn);
            this.panel1.Controls.Add(this.Approvereq_btn);
            this.panel1.Controls.Add(this.Assignworkload_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
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
            this.Allocation_btn.Location = new System.Drawing.Point(162, 345);
            this.Allocation_btn.Name = "Allocation_btn";
            this.Allocation_btn.Size = new System.Drawing.Size(496, 45);
            this.Allocation_btn.TabIndex = 8;
            this.Allocation_btn.Text = "Manage Resourse Allocation";
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
            this.Approvereq_btn.Location = new System.Drawing.Point(162, 263);
            this.Approvereq_btn.Name = "Approvereq_btn";
            this.Approvereq_btn.Size = new System.Drawing.Size(496, 45);
            this.Approvereq_btn.TabIndex = 7;
            this.Approvereq_btn.Text = "Approve Faculty Request";
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
            this.Assignworkload_btn.Location = new System.Drawing.Point(162, 188);
            this.Assignworkload_btn.Name = "Assignworkload_btn";
            this.Assignworkload_btn.Size = new System.Drawing.Size(496, 45);
            this.Assignworkload_btn.TabIndex = 6;
            this.Assignworkload_btn.Text = "Assign workload";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Department_lbl);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 142);
            this.panel2.TabIndex = 2;
            // 
            // Department_lbl
            // 
            this.Department_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Department_lbl.AutoSize = true;
            this.Department_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.Department_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Department_lbl.Location = new System.Drawing.Point(226, 42);
            this.Department_lbl.Name = "Department_lbl";
            this.Department_lbl.Size = new System.Drawing.Size(353, 49);
            this.Department_lbl.TabIndex = 1;
            this.Department_lbl.Text = "Department Head";
            // 
            // DepartmentHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "DepartmentHead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentHead";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Department_lbl;
        private Guna.UI2.WinForms.Guna2Button Approvereq_btn;
        private Guna.UI2.WinForms.Guna2Button Assignworkload_btn;
        private Guna.UI2.WinForms.Guna2Button Allocation_btn;
    }
}