namespace MidProjectDb.UI
{
    partial class ManageCourse
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Contact_txtbox = new System.Windows.Forms.TextBox();
            this.contactHours_lbl = new System.Windows.Forms.Label();
            this.Credithour_txtbox = new System.Windows.Forms.TextBox();
            this.hours_lbl = new System.Windows.Forms.Label();
            this.type_txtbox = new System.Windows.Forms.TextBox();
            this.type_lbl = new System.Windows.Forms.Label();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.Courses_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.ManageCourse_lbl = new System.Windows.Forms.Label();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.Contact_txtbox);
            this.panel1.Controls.Add(this.contactHours_lbl);
            this.panel1.Controls.Add(this.Credithour_txtbox);
            this.panel1.Controls.Add(this.hours_lbl);
            this.panel1.Controls.Add(this.type_txtbox);
            this.panel1.Controls.Add(this.type_lbl);
            this.panel1.Controls.Add(this.name_txtbox);
            this.panel1.Controls.Add(this.Name_lbl);
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.Courses_lbl);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 689);
            this.panel1.TabIndex = 0;
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
            this.guna2Button1.Location = new System.Drawing.Point(713, 609);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(174, 55);
            this.guna2Button1.TabIndex = 33;
            this.guna2Button1.Text = "Add";
            // 
            // Contact_txtbox
            // 
            this.Contact_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Contact_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_txtbox.Location = new System.Drawing.Point(586, 542);
            this.Contact_txtbox.Name = "Contact_txtbox";
            this.Contact_txtbox.Size = new System.Drawing.Size(301, 27);
            this.Contact_txtbox.TabIndex = 32;
            // 
            // contactHours_lbl
            // 
            this.contactHours_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contactHours_lbl.AutoSize = true;
            this.contactHours_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactHours_lbl.Location = new System.Drawing.Point(192, 542);
            this.contactHours_lbl.Name = "contactHours_lbl";
            this.contactHours_lbl.Size = new System.Drawing.Size(277, 32);
            this.contactHours_lbl.TabIndex = 31;
            this.contactHours_lbl.Text = "Enter Contact Hours:";
            // 
            // Credithour_txtbox
            // 
            this.Credithour_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Credithour_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credithour_txtbox.Location = new System.Drawing.Point(586, 481);
            this.Credithour_txtbox.Name = "Credithour_txtbox";
            this.Credithour_txtbox.Size = new System.Drawing.Size(301, 27);
            this.Credithour_txtbox.TabIndex = 30;
            // 
            // hours_lbl
            // 
            this.hours_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hours_lbl.AutoSize = true;
            this.hours_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_lbl.Location = new System.Drawing.Point(192, 490);
            this.hours_lbl.Name = "hours_lbl";
            this.hours_lbl.Size = new System.Drawing.Size(255, 32);
            this.hours_lbl.TabIndex = 29;
            this.hours_lbl.Text = "Enter Credit Hours:";
            // 
            // type_txtbox
            // 
            this.type_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.type_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_txtbox.Location = new System.Drawing.Point(586, 439);
            this.type_txtbox.Name = "type_txtbox";
            this.type_txtbox.Size = new System.Drawing.Size(301, 27);
            this.type_txtbox.TabIndex = 28;
            // 
            // type_lbl
            // 
            this.type_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.type_lbl.AutoSize = true;
            this.type_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_lbl.Location = new System.Drawing.Point(192, 434);
            this.type_lbl.Name = "type_lbl";
            this.type_lbl.Size = new System.Drawing.Size(258, 32);
            this.type_lbl.TabIndex = 27;
            this.type_lbl.Text = "Enter Course Type:";
            // 
            // name_txtbox
            // 
            this.name_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txtbox.Location = new System.Drawing.Point(586, 387);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(301, 27);
            this.name_txtbox.TabIndex = 26;
            // 
            // Name_lbl
            // 
            this.Name_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(192, 387);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(270, 32);
            this.Name_lbl.TabIndex = 25;
            this.Name_lbl.Text = "Enter Course Name:";
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
            this.Back_lbl.Location = new System.Drawing.Point(198, 609);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(174, 55);
            this.Back_lbl.TabIndex = 23;
            this.Back_lbl.Text = "Back";
            this.Back_lbl.Click += new System.EventHandler(this.Back_lbl_Click);
            // 
            // Courses_lbl
            // 
            this.Courses_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Courses_lbl.AutoSize = true;
            this.Courses_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courses_lbl.Location = new System.Drawing.Point(192, 160);
            this.Courses_lbl.Name = "Courses_lbl";
            this.Courses_lbl.Size = new System.Drawing.Size(127, 32);
            this.Courses_lbl.TabIndex = 22;
            this.Courses_lbl.Text = "Courses:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseId,
            this.courseNameDataGridViewTextBoxColumn,
            this.courseTypeDataGridViewTextBoxColumn,
            this.creditHoursDataGridViewTextBoxColumn,
            this.contactHoursDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(198, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(689, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataSource = typeof(MidProjectDb.BL.Course);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.ManageCourse_lbl);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 142);
            this.panel2.TabIndex = 2;
            // 
            // ManageCourse_lbl
            // 
            this.ManageCourse_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManageCourse_lbl.AutoSize = true;
            this.ManageCourse_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.ManageCourse_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCourse_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.ManageCourse_lbl.Location = new System.Drawing.Point(325, 53);
            this.ManageCourse_lbl.Name = "ManageCourse_lbl";
            this.ManageCourse_lbl.Size = new System.Drawing.Size(331, 49);
            this.ManageCourse_lbl.TabIndex = 1;
            this.ManageCourse_lbl.Text = "Manage Courses";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(MidProjectDb.BL.Course);
            // 
            // CourseId
            // 
            this.CourseId.DataPropertyName = "CourseId";
            this.CourseId.HeaderText = "CourseId";
            this.CourseId.MinimumWidth = 6;
            this.CourseId.Name = "CourseId";
            this.CourseId.Width = 125;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseTypeDataGridViewTextBoxColumn
            // 
            this.courseTypeDataGridViewTextBoxColumn.DataPropertyName = "CourseType";
            this.courseTypeDataGridViewTextBoxColumn.HeaderText = "CourseType";
            this.courseTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseTypeDataGridViewTextBoxColumn.Name = "courseTypeDataGridViewTextBoxColumn";
            this.courseTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // creditHoursDataGridViewTextBoxColumn
            // 
            this.creditHoursDataGridViewTextBoxColumn.DataPropertyName = "CreditHours";
            this.creditHoursDataGridViewTextBoxColumn.HeaderText = "CreditHours";
            this.creditHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditHoursDataGridViewTextBoxColumn.Name = "creditHoursDataGridViewTextBoxColumn";
            this.creditHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactHoursDataGridViewTextBoxColumn
            // 
            this.contactHoursDataGridViewTextBoxColumn.DataPropertyName = "ContactHours";
            this.contactHoursDataGridViewTextBoxColumn.HeaderText = "ContactHours";
            this.contactHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactHoursDataGridViewTextBoxColumn.Name = "contactHoursDataGridViewTextBoxColumn";
            this.contactHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // ManageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(991, 689);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCourse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ManageCourse_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.Label Courses_lbl;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label type_lbl;
        private System.Windows.Forms.TextBox Contact_txtbox;
        private System.Windows.Forms.Label contactHours_lbl;
        private System.Windows.Forms.TextBox Credithour_txtbox;
        private System.Windows.Forms.Label hours_lbl;
        private System.Windows.Forms.TextBox type_txtbox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactHoursDataGridViewTextBoxColumn;
    }
}