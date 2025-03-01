namespace MidProjectDb.UI
{
    partial class AssignProject
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
            this.label2 = new System.Windows.Forms.Label();
            this.semid_txtbox = new System.Windows.Forms.TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.projectid_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Facultyname_txtbox = new System.Windows.Forms.TextBox();
            this.FacultyName_lbl = new System.Windows.Forms.Label();
            this.supervisionhour_txtbox = new System.Windows.Forms.TextBox();
            this.Supervision_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facultyprojectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisionhoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semsteridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyprojectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facProjects_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Workoad_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyprojectBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.semid_txtbox);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.projectid_txtbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Facultyname_txtbox);
            this.panel1.Controls.Add(this.FacultyName_lbl);
            this.panel1.Controls.Add(this.supervisionhour_txtbox);
            this.panel1.Controls.Add(this.Supervision_lbl);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.facProjects_lbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 702);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 32);
            this.label2.TabIndex = 32;
            this.label2.Text = "Enter Semester Id:";
            // 
            // semid_txtbox
            // 
            this.semid_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.semid_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semid_txtbox.Location = new System.Drawing.Point(626, 530);
            this.semid_txtbox.Name = "semid_txtbox";
            this.semid_txtbox.Size = new System.Drawing.Size(301, 27);
            this.semid_txtbox.TabIndex = 31;
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
            this.guna2Button1.Location = new System.Drawing.Point(753, 600);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(174, 55);
            this.guna2Button1.TabIndex = 30;
            this.guna2Button1.Text = "Assign";
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
            this.Back_lbl.Location = new System.Drawing.Point(215, 600);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(174, 55);
            this.Back_lbl.TabIndex = 29;
            this.Back_lbl.Text = "Back";
            this.Back_lbl.Click += new System.EventHandler(this.Back_lbl_Click);
            // 
            // projectid_txtbox
            // 
            this.projectid_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.projectid_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectid_txtbox.Location = new System.Drawing.Point(626, 485);
            this.projectid_txtbox.Name = "projectid_txtbox";
            this.projectid_txtbox.Size = new System.Drawing.Size(301, 27);
            this.projectid_txtbox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter Project Id:";
            // 
            // Facultyname_txtbox
            // 
            this.Facultyname_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Facultyname_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facultyname_txtbox.Location = new System.Drawing.Point(626, 435);
            this.Facultyname_txtbox.Name = "Facultyname_txtbox";
            this.Facultyname_txtbox.Size = new System.Drawing.Size(301, 27);
            this.Facultyname_txtbox.TabIndex = 13;
            // 
            // FacultyName_lbl
            // 
            this.FacultyName_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FacultyName_lbl.AutoSize = true;
            this.FacultyName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyName_lbl.Location = new System.Drawing.Point(209, 435);
            this.FacultyName_lbl.Name = "FacultyName_lbl";
            this.FacultyName_lbl.Size = new System.Drawing.Size(271, 32);
            this.FacultyName_lbl.TabIndex = 12;
            this.FacultyName_lbl.Text = "Enter Faculty Name:";
            // 
            // supervisionhour_txtbox
            // 
            this.supervisionhour_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.supervisionhour_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisionhour_txtbox.Location = new System.Drawing.Point(626, 383);
            this.supervisionhour_txtbox.Name = "supervisionhour_txtbox";
            this.supervisionhour_txtbox.Size = new System.Drawing.Size(301, 27);
            this.supervisionhour_txtbox.TabIndex = 11;
            // 
            // Supervision_lbl
            // 
            this.Supervision_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Supervision_lbl.AutoSize = true;
            this.Supervision_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supervision_lbl.Location = new System.Drawing.Point(209, 383);
            this.Supervision_lbl.Name = "Supervision_lbl";
            this.Supervision_lbl.Size = new System.Drawing.Size(329, 32);
            this.Supervision_lbl.TabIndex = 10;
            this.Supervision_lbl.Text = "Enter Supervision Hours:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facultyprojectidDataGridViewTextBoxColumn,
            this.supervisionhoursDataGridViewTextBoxColumn,
            this.facultyidDataGridViewTextBoxColumn,
            this.projectidDataGridViewTextBoxColumn,
            this.semsteridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facultyprojectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(215, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // facultyprojectidDataGridViewTextBoxColumn
            // 
            this.facultyprojectidDataGridViewTextBoxColumn.DataPropertyName = "facultyprojectid";
            this.facultyprojectidDataGridViewTextBoxColumn.HeaderText = "facultyprojectid";
            this.facultyprojectidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facultyprojectidDataGridViewTextBoxColumn.Name = "facultyprojectidDataGridViewTextBoxColumn";
            this.facultyprojectidDataGridViewTextBoxColumn.Width = 125;
            // 
            // supervisionhoursDataGridViewTextBoxColumn
            // 
            this.supervisionhoursDataGridViewTextBoxColumn.DataPropertyName = "supervisionhours";
            this.supervisionhoursDataGridViewTextBoxColumn.HeaderText = "supervisionhours";
            this.supervisionhoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supervisionhoursDataGridViewTextBoxColumn.Name = "supervisionhoursDataGridViewTextBoxColumn";
            this.supervisionhoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // facultyidDataGridViewTextBoxColumn
            // 
            this.facultyidDataGridViewTextBoxColumn.DataPropertyName = "facultyid";
            this.facultyidDataGridViewTextBoxColumn.HeaderText = "facultyid";
            this.facultyidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facultyidDataGridViewTextBoxColumn.Name = "facultyidDataGridViewTextBoxColumn";
            this.facultyidDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectidDataGridViewTextBoxColumn
            // 
            this.projectidDataGridViewTextBoxColumn.DataPropertyName = "projectid";
            this.projectidDataGridViewTextBoxColumn.HeaderText = "projectid";
            this.projectidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectidDataGridViewTextBoxColumn.Name = "projectidDataGridViewTextBoxColumn";
            this.projectidDataGridViewTextBoxColumn.Width = 125;
            // 
            // semsteridDataGridViewTextBoxColumn
            // 
            this.semsteridDataGridViewTextBoxColumn.DataPropertyName = "semsterid";
            this.semsteridDataGridViewTextBoxColumn.HeaderText = "semsterid";
            this.semsteridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semsteridDataGridViewTextBoxColumn.Name = "semsteridDataGridViewTextBoxColumn";
            this.semsteridDataGridViewTextBoxColumn.Width = 125;
            // 
            // facultyprojectBindingSource
            // 
            this.facultyprojectBindingSource.DataSource = typeof(MidProjectDb.UI.Facultyproject);
            // 
            // facProjects_lbl
            // 
            this.facProjects_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.facProjects_lbl.AutoSize = true;
            this.facProjects_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facProjects_lbl.Location = new System.Drawing.Point(209, 164);
            this.facProjects_lbl.Name = "facProjects_lbl";
            this.facProjects_lbl.Size = new System.Drawing.Size(322, 32);
            this.facProjects_lbl.TabIndex = 8;
            this.facProjects_lbl.Text = "Current Faculty projects:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Workoad_lbl);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 142);
            this.panel2.TabIndex = 6;
            // 
            // Workoad_lbl
            // 
            this.Workoad_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Workoad_lbl.AutoSize = true;
            this.Workoad_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.Workoad_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Workoad_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Workoad_lbl.Location = new System.Drawing.Point(318, 46);
            this.Workoad_lbl.Name = "Workoad_lbl";
            this.Workoad_lbl.Size = new System.Drawing.Size(340, 49);
            this.Workoad_lbl.TabIndex = 1;
            this.Workoad_lbl.Text = "Assign Workload";
            // 
            // AssignProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1045, 702);
            this.Controls.Add(this.panel1);
            this.Name = "AssignProject";
            this.Text = "AssignProject";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyprojectBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Workoad_lbl;
        private System.Windows.Forms.Label facProjects_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource facultyprojectBindingSource;
        private System.Windows.Forms.Label Supervision_lbl;
        private System.Windows.Forms.TextBox projectid_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Facultyname_txtbox;
        private System.Windows.Forms.Label FacultyName_lbl;
        private System.Windows.Forms.TextBox supervisionhour_txtbox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyprojectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisionhoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semsteridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox semid_txtbox;
    }
}