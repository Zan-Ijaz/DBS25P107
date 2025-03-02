namespace MidProjectDb.UI
{
    partial class Sechduling
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
            this.Next_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.Availableroom = new System.Windows.Forms.Label();
            this.Course_lbl = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.roomnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facultyCourseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesteridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultycourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sechduling_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultycourseBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Next_btn);
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.Availableroom);
            this.panel1.Controls.Add(this.Course_lbl);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 662);
            this.panel1.TabIndex = 0;
            // 
            // Next_btn
            // 
            this.Next_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Next_btn.BorderRadius = 20;
            this.Next_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Next_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Next_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Next_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Next_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Next_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_btn.ForeColor = System.Drawing.Color.White;
            this.Next_btn.Location = new System.Drawing.Point(623, 575);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(174, 55);
            this.Next_btn.TabIndex = 23;
            this.Next_btn.Text = "Next";
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
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
            this.Back_lbl.Location = new System.Drawing.Point(149, 575);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(174, 55);
            this.Back_lbl.TabIndex = 20;
            this.Back_lbl.Text = "Back";
            this.Back_lbl.Click += new System.EventHandler(this.Back_lbl_Click);
            // 
            // Availableroom
            // 
            this.Availableroom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Availableroom.AutoSize = true;
            this.Availableroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Availableroom.Location = new System.Drawing.Point(143, 355);
            this.Availableroom.Name = "Availableroom";
            this.Availableroom.Size = new System.Drawing.Size(236, 32);
            this.Availableroom.TabIndex = 8;
            this.Availableroom.Text = "Available Rooms:";
            // 
            // Course_lbl
            // 
            this.Course_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Course_lbl.AutoSize = true;
            this.Course_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_lbl.Location = new System.Drawing.Point(143, 145);
            this.Course_lbl.Name = "Course_lbl";
            this.Course_lbl.Size = new System.Drawing.Size(327, 32);
            this.Course_lbl.TabIndex = 7;
            this.Course_lbl.Text = "Current Faculty Courses:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomnameDataGridViewTextBoxColumn,
            this.roomtypeDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.roomBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(282, 402);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(448, 150);
            this.dataGridView2.TabIndex = 4;
            // 
            // roomnameDataGridViewTextBoxColumn
            // 
            this.roomnameDataGridViewTextBoxColumn.DataPropertyName = "roomname";
            this.roomnameDataGridViewTextBoxColumn.HeaderText = "roomname";
            this.roomnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomnameDataGridViewTextBoxColumn.Name = "roomnameDataGridViewTextBoxColumn";
            this.roomnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomtypeDataGridViewTextBoxColumn
            // 
            this.roomtypeDataGridViewTextBoxColumn.DataPropertyName = "roomtype";
            this.roomtypeDataGridViewTextBoxColumn.HeaderText = "roomtype";
            this.roomtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomtypeDataGridViewTextBoxColumn.Name = "roomtypeDataGridViewTextBoxColumn";
            this.roomtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(MidProjectDb.UI.Room);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facultyCourseid,
            this.facultyidDataGridViewTextBoxColumn,
            this.courseidDataGridViewTextBoxColumn,
            this.semesteridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facultycourseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(230, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(567, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // facultyCourseid
            // 
            this.facultyCourseid.DataPropertyName = "facultyCourseid";
            this.facultyCourseid.HeaderText = "facultyCourseid";
            this.facultyCourseid.MinimumWidth = 6;
            this.facultyCourseid.Name = "facultyCourseid";
            this.facultyCourseid.ReadOnly = true;
            this.facultyCourseid.Width = 125;
            // 
            // facultyidDataGridViewTextBoxColumn
            // 
            this.facultyidDataGridViewTextBoxColumn.DataPropertyName = "facultyid";
            this.facultyidDataGridViewTextBoxColumn.HeaderText = "facultyid";
            this.facultyidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facultyidDataGridViewTextBoxColumn.Name = "facultyidDataGridViewTextBoxColumn";
            this.facultyidDataGridViewTextBoxColumn.ReadOnly = true;
            this.facultyidDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseidDataGridViewTextBoxColumn
            // 
            this.courseidDataGridViewTextBoxColumn.DataPropertyName = "Courseid";
            this.courseidDataGridViewTextBoxColumn.HeaderText = "Courseid";
            this.courseidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseidDataGridViewTextBoxColumn.Name = "courseidDataGridViewTextBoxColumn";
            this.courseidDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseidDataGridViewTextBoxColumn.Width = 125;
            // 
            // semesteridDataGridViewTextBoxColumn
            // 
            this.semesteridDataGridViewTextBoxColumn.DataPropertyName = "Semesterid";
            this.semesteridDataGridViewTextBoxColumn.HeaderText = "Semesterid";
            this.semesteridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesteridDataGridViewTextBoxColumn.Name = "semesteridDataGridViewTextBoxColumn";
            this.semesteridDataGridViewTextBoxColumn.ReadOnly = true;
            this.semesteridDataGridViewTextBoxColumn.Width = 125;
            // 
            // facultycourseBindingSource
            // 
            this.facultycourseBindingSource.DataSource = typeof(MidProjectDb.BL.Facultycourse);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Sechduling_lbl);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 142);
            this.panel2.TabIndex = 2;
            // 
            // Sechduling_lbl
            // 
            this.Sechduling_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sechduling_lbl.AutoSize = true;
            this.Sechduling_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.Sechduling_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sechduling_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Sechduling_lbl.Location = new System.Drawing.Point(281, 55);
            this.Sechduling_lbl.Name = "Sechduling_lbl";
            this.Sechduling_lbl.Size = new System.Drawing.Size(346, 49);
            this.Sechduling_lbl.TabIndex = 1;
            this.Sechduling_lbl.Text = "Sechdule Courses";
            // 
            // Sechduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(964, 662);
            this.Controls.Add(this.panel1);
            this.Name = "Sechduling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sechduling";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultycourseBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Sechduling_lbl;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource facultycourseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Availableroom;
        private System.Windows.Forms.Label Course_lbl;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
        private Guna.UI2.WinForms.Guna2Button Next_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyCourseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesteridDataGridViewTextBoxColumn;
    }
}