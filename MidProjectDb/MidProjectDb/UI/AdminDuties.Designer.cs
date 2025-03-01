namespace MidProjectDb.UI
{
    partial class AdminDuties
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTeachingHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.semesterIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Workoad_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.facultyAdminRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdminRoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supervision_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.facname_txtbox = new System.Windows.Forms.TextBox();
            this.rolefacname_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.semid_txtbox = new System.Windows.Forms.TextBox();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyAdminRoleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.semid_txtbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rolefacname_txtbox);
            this.panel1.Controls.Add(this.facname_txtbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Supervision_lbl);
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this._lbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 771);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.totalTeachingHoursDataGridViewTextBoxColumn,
            this.DesignationId});
            this.dataGridView2.DataSource = this.facultyBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(811, 196);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(439, 150);
            this.dataGridView2.TabIndex = 14;
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
            // totalTeachingHoursDataGridViewTextBoxColumn
            // 
            this.totalTeachingHoursDataGridViewTextBoxColumn.DataPropertyName = "TotalTeachingHours";
            this.totalTeachingHoursDataGridViewTextBoxColumn.HeaderText = "TotalTeachingHours";
            this.totalTeachingHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalTeachingHoursDataGridViewTextBoxColumn.Name = "totalTeachingHoursDataGridViewTextBoxColumn";
            this.totalTeachingHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalTeachingHoursDataGridViewTextBoxColumn.Width = 125;
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
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataSource = typeof(MidProjectDb.UI.Faculty);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(805, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Current Faculty:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.semesterIdDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.semesterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(84, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(437, 150);
            this.dataGridView1.TabIndex = 12;
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
            // _lbl
            // 
            this._lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lbl.AutoSize = true;
            this._lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl.Location = new System.Drawing.Point(78, 161);
            this._lbl.Name = "_lbl";
            this._lbl.Size = new System.Drawing.Size(258, 32);
            this._lbl.TabIndex = 11;
            this._lbl.Text = "Current Semesters:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Workoad_lbl);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1394, 142);
            this.panel2.TabIndex = 4;
            // 
            // Workoad_lbl
            // 
            this.Workoad_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Workoad_lbl.AutoSize = true;
            this.Workoad_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.Workoad_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Workoad_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Workoad_lbl.Location = new System.Drawing.Point(509, 45);
            this.Workoad_lbl.Name = "Workoad_lbl";
            this.Workoad_lbl.Size = new System.Drawing.Size(416, 49);
            this.Workoad_lbl.TabIndex = 1;
            this.Workoad_lbl.Text = "Adminstrative Duties";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Current Admin Duties:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdminRoleId,
            this.FacultyId,
            this.RoleName,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.facultyAdminRoleBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(375, 384);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(572, 150);
            this.dataGridView3.TabIndex = 16;
            // 
            // facultyAdminRoleBindingSource
            // 
            this.facultyAdminRoleBindingSource.DataSource = typeof(MidProjectDb.BL.FacultyAdminRole);
            // 
            // AdminRoleId
            // 
            this.AdminRoleId.DataPropertyName = "AdminRoleId";
            this.AdminRoleId.HeaderText = "AdminRoleId";
            this.AdminRoleId.MinimumWidth = 6;
            this.AdminRoleId.Name = "AdminRoleId";
            this.AdminRoleId.ReadOnly = true;
            this.AdminRoleId.Width = 125;
            // 
            // FacultyId
            // 
            this.FacultyId.DataPropertyName = "FacultyId";
            this.FacultyId.HeaderText = "FacultyId";
            this.FacultyId.MinimumWidth = 6;
            this.FacultyId.Name = "FacultyId";
            this.FacultyId.ReadOnly = true;
            this.FacultyId.Width = 125;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "RoleName";
            this.RoleName.MinimumWidth = 6;
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            this.RoleName.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SemesterId";
            this.dataGridViewTextBoxColumn1.HeaderText = "SemesterId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Supervision_lbl
            // 
            this.Supervision_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Supervision_lbl.AutoSize = true;
            this.Supervision_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supervision_lbl.Location = new System.Drawing.Point(42, 537);
            this.Supervision_lbl.Name = "Supervision_lbl";
            this.Supervision_lbl.Size = new System.Drawing.Size(271, 32);
            this.Supervision_lbl.TabIndex = 17;
            this.Supervision_lbl.Text = "Enter Faculty Name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(724, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enter Role Name:";
            // 
            // facname_txtbox
            // 
            this.facname_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.facname_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facname_txtbox.Location = new System.Drawing.Point(319, 542);
            this.facname_txtbox.Name = "facname_txtbox";
            this.facname_txtbox.Size = new System.Drawing.Size(301, 27);
            this.facname_txtbox.TabIndex = 19;
            // 
            // rolefacname_txtbox
            // 
            this.rolefacname_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rolefacname_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolefacname_txtbox.Location = new System.Drawing.Point(993, 549);
            this.rolefacname_txtbox.Name = "rolefacname_txtbox";
            this.rolefacname_txtbox.Size = new System.Drawing.Size(301, 27);
            this.rolefacname_txtbox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "Enter Semester Id:";
            // 
            // semid_txtbox
            // 
            this.semid_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.semid_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semid_txtbox.Location = new System.Drawing.Point(646, 601);
            this.semid_txtbox.Name = "semid_txtbox";
            this.semid_txtbox.Size = new System.Drawing.Size(301, 27);
            this.semid_txtbox.TabIndex = 22;
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
            this.Back_lbl.Location = new System.Drawing.Point(225, 653);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(174, 55);
            this.Back_lbl.TabIndex = 30;
            this.Back_lbl.Text = "Back";
            this.Back_lbl.Click += new System.EventHandler(this.Back_lbl_Click);
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
            this.guna2Button1.Location = new System.Drawing.Point(905, 653);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(174, 55);
            this.guna2Button1.TabIndex = 31;
            this.guna2Button1.Text = "Add";
            // 
            // AdminDuties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1325, 771);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDuties";
            this.Text = "AdminDuties";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyAdminRoleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Workoad_lbl;
        private System.Windows.Forms.Label _lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource semesterBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTeachingHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminRoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource facultyAdminRoleBindingSource;
        private System.Windows.Forms.Label Supervision_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rolefacname_txtbox;
        private System.Windows.Forms.TextBox facname_txtbox;
        private System.Windows.Forms.TextBox semid_txtbox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}