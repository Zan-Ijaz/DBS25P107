namespace MidProjectDb.UI
{
    partial class FacultyManagement
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
            this.Facultymanag_lbl = new System.Windows.Forms.Label();
            this.Addfaculty_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Deletefaculty_btn = new Guna.UI2.WinForms.Guna2Button();
            this.update_faculty_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Back_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back_btn);
            this.panel1.Controls.Add(this.update_faculty_btn);
            this.panel1.Controls.Add(this.Deletefaculty_btn);
            this.panel1.Controls.Add(this.Addfaculty_btn);
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
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Facultymanag_lbl);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 125);
            this.panel2.TabIndex = 4;
            // 
            // Facultymanag_lbl
            // 
            this.Facultymanag_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Facultymanag_lbl.AutoSize = true;
            this.Facultymanag_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Facultymanag_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facultymanag_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Facultymanag_lbl.Location = new System.Drawing.Point(212, 44);
            this.Facultymanag_lbl.Name = "Facultymanag_lbl";
            this.Facultymanag_lbl.Size = new System.Drawing.Size(415, 49);
            this.Facultymanag_lbl.TabIndex = 0;
            this.Facultymanag_lbl.Text = "Faculty Management";
            // 
            // Addfaculty_btn
            // 
            this.Addfaculty_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Addfaculty_btn.BorderRadius = 20;
            this.Addfaculty_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Addfaculty_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Addfaculty_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Addfaculty_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Addfaculty_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Addfaculty_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addfaculty_btn.ForeColor = System.Drawing.Color.White;
            this.Addfaculty_btn.Location = new System.Drawing.Point(159, 172);
            this.Addfaculty_btn.Name = "Addfaculty_btn";
            this.Addfaculty_btn.Size = new System.Drawing.Size(496, 45);
            this.Addfaculty_btn.TabIndex = 9;
            this.Addfaculty_btn.Text = "Add Faculty Member";
            this.Addfaculty_btn.Click += new System.EventHandler(this.Addfaculty_btn_Click);
            // 
            // Deletefaculty_btn
            // 
            this.Deletefaculty_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Deletefaculty_btn.BorderRadius = 20;
            this.Deletefaculty_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Deletefaculty_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Deletefaculty_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Deletefaculty_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Deletefaculty_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Deletefaculty_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletefaculty_btn.ForeColor = System.Drawing.Color.White;
            this.Deletefaculty_btn.Location = new System.Drawing.Point(159, 239);
            this.Deletefaculty_btn.Name = "Deletefaculty_btn";
            this.Deletefaculty_btn.Size = new System.Drawing.Size(496, 45);
            this.Deletefaculty_btn.TabIndex = 10;
            this.Deletefaculty_btn.Text = "Delete Faculty Member";
            // 
            // update_faculty_btn
            // 
            this.update_faculty_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.update_faculty_btn.BorderRadius = 20;
            this.update_faculty_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_faculty_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_faculty_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_faculty_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_faculty_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.update_faculty_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_faculty_btn.ForeColor = System.Drawing.Color.White;
            this.update_faculty_btn.Location = new System.Drawing.Point(159, 305);
            this.update_faculty_btn.Name = "update_faculty_btn";
            this.update_faculty_btn.Size = new System.Drawing.Size(496, 45);
            this.update_faculty_btn.TabIndex = 11;
            this.update_faculty_btn.Text = "Update Faculty Member";
            // 
            // Back_btn
            // 
            this.Back_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Back_btn.BorderRadius = 20;
            this.Back_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Back_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Back_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Back_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Back_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Back_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.ForeColor = System.Drawing.Color.White;
            this.Back_btn.Location = new System.Drawing.Point(159, 379);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(496, 45);
            this.Back_btn.TabIndex = 12;
            this.Back_btn.Text = "Go Back";
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // FacultyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FacultyManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacultyManagement";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Facultymanag_lbl;
        private Guna.UI2.WinForms.Guna2Button Back_btn;
        private Guna.UI2.WinForms.Guna2Button update_faculty_btn;
        private Guna.UI2.WinForms.Guna2Button Deletefaculty_btn;
        private Guna.UI2.WinForms.Guna2Button Addfaculty_btn;
    }
}