namespace MidProjectDb.UI
{
    partial class CourseAllocation
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.FacultyID_txtbox = new System.Windows.Forms.TextBox();
            this.FacultyID_lbl = new System.Windows.Forms.Label();
            this.courseID_txtbox = new System.Windows.Forms.TextBox();
            this.Courseid_lbl = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.facultyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.researchAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTeachingHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cousresallocation_lbl = new System.Windows.Forms.Label();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Save_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Save_btn);
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.FacultyID_txtbox);
            this.panel1.Controls.Add(this.FacultyID_lbl);
            this.panel1.Controls.Add(this.courseID_txtbox);
            this.panel1.Controls.Add(this.Courseid_lbl);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 659);
            this.panel1.TabIndex = 0;
            // 
            // Back_lbl
            // 
            this.Back_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Back_lbl.BorderRadius = 20;
            this.Back_lbl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Back_lbl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Back_lbl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Back_lbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Back_lbl.FillColor = System.Drawing.Color.MidnightBlue;
            this.Back_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_lbl.ForeColor = System.Drawing.Color.White;
            this.Back_lbl.Location = new System.Drawing.Point(189, 577);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(174, 55);
            this.Back_lbl.TabIndex = 20;
            this.Back_lbl.Text = "Back";
            this.Back_lbl.Click += new System.EventHandler(this.Back_lbl_Click);
            // 
            // FacultyID_txtbox
            // 
            this.FacultyID_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FacultyID_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyID_txtbox.Location = new System.Drawing.Point(930, 488);
            this.FacultyID_txtbox.Name = "FacultyID_txtbox";
            this.FacultyID_txtbox.Size = new System.Drawing.Size(301, 27);
            this.FacultyID_txtbox.TabIndex = 9;
            // 
            // FacultyID_lbl
            // 
            this.FacultyID_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FacultyID_lbl.AutoSize = true;
            this.FacultyID_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyID_lbl.Location = new System.Drawing.Point(681, 481);
            this.FacultyID_lbl.Name = "FacultyID_lbl";
            this.FacultyID_lbl.Size = new System.Drawing.Size(216, 32);
            this.FacultyID_lbl.TabIndex = 8;
            this.FacultyID_lbl.Text = "Enter FacultyID:";
            // 
            // courseID_txtbox
            // 
            this.courseID_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.courseID_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseID_txtbox.Location = new System.Drawing.Point(320, 481);
            this.courseID_txtbox.Name = "courseID_txtbox";
            this.courseID_txtbox.Size = new System.Drawing.Size(301, 27);
            this.courseID_txtbox.TabIndex = 7;
            // 
            // Courseid_lbl
            // 
            this.Courseid_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Courseid_lbl.AutoSize = true;
            this.Courseid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courseid_lbl.Location = new System.Drawing.Point(56, 476);
            this.Courseid_lbl.Name = "Courseid_lbl";
            this.Courseid_lbl.Size = new System.Drawing.Size(215, 32);
            this.Courseid_lbl.TabIndex = 6;
            this.Courseid_lbl.Text = "Enter CourseID:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facultyIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.DesignationId,
            this.researchAreaDataGridViewTextBoxColumn,
            this.totalTeachingHoursDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.facultyBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(158, 301);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1058, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // facultyIdDataGridViewTextBoxColumn
            // 
            this.facultyIdDataGridViewTextBoxColumn.DataPropertyName = "FacultyId";
            this.facultyIdDataGridViewTextBoxColumn.HeaderText = "FacultyId";
            this.facultyIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facultyIdDataGridViewTextBoxColumn.Name = "facultyIdDataGridViewTextBoxColumn";
            this.facultyIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.facultyIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactDataGridViewTextBoxColumn.Width = 125;
            // 
            // DesignationId
            // 
            this.DesignationId.DataPropertyName = "DesignationId";
            this.DesignationId.HeaderText = "DesignationId";
            this.DesignationId.MinimumWidth = 6;
            this.DesignationId.Name = "DesignationId";
            this.DesignationId.ReadOnly = true;
            this.DesignationId.Width = 125;
            // 
            // researchAreaDataGridViewTextBoxColumn
            // 
            this.researchAreaDataGridViewTextBoxColumn.DataPropertyName = "ResearchArea";
            this.researchAreaDataGridViewTextBoxColumn.HeaderText = "ResearchArea";
            this.researchAreaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.researchAreaDataGridViewTextBoxColumn.Name = "researchAreaDataGridViewTextBoxColumn";
            this.researchAreaDataGridViewTextBoxColumn.ReadOnly = true;
            this.researchAreaDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalTeachingHoursDataGridViewTextBoxColumn
            // 
            this.totalTeachingHoursDataGridViewTextBoxColumn.DataPropertyName = "TotalTeachingHours";
            this.totalTeachingHoursDataGridViewTextBoxColumn.HeaderText = "TotalTeachingHours";
            this.totalTeachingHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalTeachingHoursDataGridViewTextBoxColumn.Name = "totalTeachingHoursDataGridViewTextBoxColumn";
            this.totalTeachingHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalTeachingHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // facultyBindingSource1
            // 
            this.facultyBindingSource1.DataSource = typeof(MidProjectDb.UI.Faculty);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.courseTypeDataGridViewTextBoxColumn,
            this.creditHoursDataGridViewTextBoxColumn,
            this.contactHoursDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(296, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(687, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "CourseId";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "CourseId";
            this.courseIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseTypeDataGridViewTextBoxColumn
            // 
            this.courseTypeDataGridViewTextBoxColumn.DataPropertyName = "CourseType";
            this.courseTypeDataGridViewTextBoxColumn.HeaderText = "CourseType";
            this.courseTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseTypeDataGridViewTextBoxColumn.Name = "courseTypeDataGridViewTextBoxColumn";
            this.courseTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // creditHoursDataGridViewTextBoxColumn
            // 
            this.creditHoursDataGridViewTextBoxColumn.DataPropertyName = "CreditHours";
            this.creditHoursDataGridViewTextBoxColumn.HeaderText = "CreditHours";
            this.creditHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditHoursDataGridViewTextBoxColumn.Name = "creditHoursDataGridViewTextBoxColumn";
            this.creditHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.creditHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactHoursDataGridViewTextBoxColumn
            // 
            this.contactHoursDataGridViewTextBoxColumn.DataPropertyName = "ContactHours";
            this.contactHoursDataGridViewTextBoxColumn.HeaderText = "ContactHours";
            this.contactHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactHoursDataGridViewTextBoxColumn.Name = "contactHoursDataGridViewTextBoxColumn";
            this.contactHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(MidProjectDb.BL.Course);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Cousresallocation_lbl);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1270, 125);
            this.panel2.TabIndex = 3;
            // 
            // Cousresallocation_lbl
            // 
            this.Cousresallocation_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cousresallocation_lbl.AutoSize = true;
            this.Cousresallocation_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Cousresallocation_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cousresallocation_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Cousresallocation_lbl.Location = new System.Drawing.Point(456, 39);
            this.Cousresallocation_lbl.Name = "Cousresallocation_lbl";
            this.Cousresallocation_lbl.Size = new System.Drawing.Size(350, 49);
            this.Cousresallocation_lbl.TabIndex = 0;
            this.Cousresallocation_lbl.Text = "Course Allocation";
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataSource = typeof(MidProjectDb.UI.Faculty);
            // 
            // Save_btn
            // 
            this.Save_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Save_btn.BorderRadius = 20;
            this.Save_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Save_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Save_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Save_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Save_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Save_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.ForeColor = System.Drawing.Color.White;
            this.Save_btn.Location = new System.Drawing.Point(993, 577);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(174, 55);
            this.Save_btn.TabIndex = 26;
            this.Save_btn.Text = "Add";
            // 
            // CourseAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1276, 659);
            this.Controls.Add(this.panel1);
            this.Name = "CourseAllocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseAllocation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label Cousresallocation_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private System.Windows.Forms.Label Courseid_lbl;
        private System.Windows.Forms.TextBox courseID_txtbox;
        private System.Windows.Forms.Label FacultyID_lbl;
        private System.Windows.Forms.TextBox FacultyID_txtbox;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
        private System.Windows.Forms.BindingSource facultyBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn researchAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTeachingHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button Save_btn;
    }
}