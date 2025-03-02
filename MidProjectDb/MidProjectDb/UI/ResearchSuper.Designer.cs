namespace MidProjectDb.UI
{
    partial class ResearchSuper
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.semesterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Semesters = new System.Windows.Forms.Label();
            this.Assign_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.facultyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.researchAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTeachingHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facprojects_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descreptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Projects_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.research_lbl = new System.Windows.Forms.Label();
            this.facultyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.facultyprojectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyprojectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.Semesters);
            this.panel1.Controls.Add(this.Assign_btn);
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.facprojects_lbl);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Projects_lbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1431, 679);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.semesterIdDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.semesterBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(827, 221);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(455, 150);
            this.dataGridView3.TabIndex = 31;
            // 
            // semesterIdDataGridViewTextBoxColumn
            // 
            this.semesterIdDataGridViewTextBoxColumn.DataPropertyName = "SemesterId";
            this.semesterIdDataGridViewTextBoxColumn.HeaderText = "SemesterId";
            this.semesterIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterIdDataGridViewTextBoxColumn.Name = "semesterIdDataGridViewTextBoxColumn";
            this.semesterIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.semesterIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "Term";
            this.termDataGridViewTextBoxColumn.HeaderText = "Term";
            this.termDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            this.termDataGridViewTextBoxColumn.ReadOnly = true;
            this.termDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // semesterBindingSource
            // 
            this.semesterBindingSource.DataSource = typeof(MidProjectDb.BL.Semester);
            // 
            // Semesters
            // 
            this.Semesters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Semesters.AutoSize = true;
            this.Semesters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Semesters.Location = new System.Drawing.Point(738, 170);
            this.Semesters.Name = "Semesters";
            this.Semesters.Size = new System.Drawing.Size(157, 32);
            this.Semesters.TabIndex = 30;
            this.Semesters.Text = "Semesters:";
            // 
            // Assign_btn
            // 
            this.Assign_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Assign_btn.BorderRadius = 20;
            this.Assign_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Assign_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Assign_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Assign_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Assign_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Assign_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assign_btn.ForeColor = System.Drawing.Color.White;
            this.Assign_btn.Location = new System.Drawing.Point(1077, 612);
            this.Assign_btn.Name = "Assign_btn";
            this.Assign_btn.Size = new System.Drawing.Size(174, 55);
            this.Assign_btn.TabIndex = 29;
            this.Assign_btn.Text = "Assign project ";
            this.Assign_btn.Click += new System.EventHandler(this.Assign_btn_Click);
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
            this.Back_lbl.Location = new System.Drawing.Point(245, 612);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(174, 55);
            this.Back_lbl.TabIndex = 28;
            this.Back_lbl.Text = "Back";
            this.Back_lbl.Click += new System.EventHandler(this.Back_lbl_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView2.AutoGenerateColumns = false;
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
            this.dataGridView2.DataSource = this.facultyBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(196, 434);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1086, 150);
            this.dataGridView2.TabIndex = 10;
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
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataSource = typeof(MidProjectDb.UI.Faculty);
            // 
            // facprojects_lbl
            // 
            this.facprojects_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.facprojects_lbl.AutoSize = true;
            this.facprojects_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facprojects_lbl.Location = new System.Drawing.Point(190, 388);
            this.facprojects_lbl.Name = "facprojects_lbl";
            this.facprojects_lbl.Size = new System.Drawing.Size(206, 32);
            this.facprojects_lbl.TabIndex = 9;
            this.facprojects_lbl.Text = "Current faculty:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectIdDataGridViewTextBoxColumn,
            this.descreptionDataGridViewTextBoxColumn,
            this.titlDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.projectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(196, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(455, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "projectId";
            this.projectIdDataGridViewTextBoxColumn.HeaderText = "projectId";
            this.projectIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            this.projectIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // descreptionDataGridViewTextBoxColumn
            // 
            this.descreptionDataGridViewTextBoxColumn.DataPropertyName = "descreption";
            this.descreptionDataGridViewTextBoxColumn.HeaderText = "descreption";
            this.descreptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descreptionDataGridViewTextBoxColumn.Name = "descreptionDataGridViewTextBoxColumn";
            this.descreptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descreptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // titlDataGridViewTextBoxColumn
            // 
            this.titlDataGridViewTextBoxColumn.DataPropertyName = "titl";
            this.titlDataGridViewTextBoxColumn.HeaderText = "titl";
            this.titlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titlDataGridViewTextBoxColumn.Name = "titlDataGridViewTextBoxColumn";
            this.titlDataGridViewTextBoxColumn.ReadOnly = true;
            this.titlDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(MidProjectDb.UI.Project);
            // 
            // Projects_lbl
            // 
            this.Projects_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Projects_lbl.AutoSize = true;
            this.Projects_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects_lbl.Location = new System.Drawing.Point(190, 170);
            this.Projects_lbl.Name = "Projects_lbl";
            this.Projects_lbl.Size = new System.Drawing.Size(223, 32);
            this.Projects_lbl.TabIndex = 7;
            this.Projects_lbl.Text = "Current projects:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.research_lbl);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1428, 142);
            this.panel2.TabIndex = 4;
            // 
            // research_lbl
            // 
            this.research_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.research_lbl.AutoSize = true;
            this.research_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.research_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.research_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.research_lbl.Location = new System.Drawing.Point(505, 45);
            this.research_lbl.Name = "research_lbl";
            this.research_lbl.Size = new System.Drawing.Size(420, 49);
            this.research_lbl.TabIndex = 1;
            this.research_lbl.Text = "Research Supervision";
            // 
            // facultyBindingSource1
            // 
            this.facultyBindingSource1.DataSource = typeof(MidProjectDb.UI.Faculty);
            // 
            // facultyprojectBindingSource
            // 
            this.facultyprojectBindingSource.DataSource = typeof(MidProjectDb.UI.Facultyproject);
            // 
            // ResearchSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1431, 679);
            this.Controls.Add(this.panel1);
            this.Name = "ResearchSuper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResearchSuper";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyprojectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label research_lbl;
        private System.Windows.Forms.Label Projects_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descreptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titlDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.Label facprojects_lbl;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource facultyprojectBindingSource;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
        private System.Windows.Forms.Label Semesters;
        private Guna.UI2.WinForms.Guna2Button Assign_btn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource semesterBindingSource;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private System.Windows.Forms.BindingSource facultyBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn researchAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTeachingHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
    }
}