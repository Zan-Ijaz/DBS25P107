namespace MidProjectDb.UI
{
    partial class UserInputs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Next_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Userinfo_lbl = new System.Windows.Forms.Label();
            this.facultyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.researchAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTeachingHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Back_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back_btn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Next_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 450);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facultyIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.researchAreaDataGridViewTextBoxColumn,
            this.totalTeachingHoursDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.facultyUserDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facultyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 150);
            this.dataGridView1.TabIndex = 17;
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
            this.Next_btn.Location = new System.Drawing.Point(883, 374);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(174, 64);
            this.Next_btn.TabIndex = 16;
            this.Next_btn.Text = "Next";
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Userinfo_lbl);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1213, 125);
            this.panel2.TabIndex = 5;
            // 
            // Userinfo_lbl
            // 
            this.Userinfo_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Userinfo_lbl.AutoSize = true;
            this.Userinfo_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Userinfo_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userinfo_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Userinfo_lbl.Location = new System.Drawing.Point(445, 44);
            this.Userinfo_lbl.Name = "Userinfo_lbl";
            this.Userinfo_lbl.Size = new System.Drawing.Size(286, 49);
            this.Userinfo_lbl.TabIndex = 0;
            this.Userinfo_lbl.Text = "Delete Faculty";
            // 
            // facultyIdDataGridViewTextBoxColumn
            // 
            this.facultyIdDataGridViewTextBoxColumn.DataPropertyName = "FacultyId";
            this.facultyIdDataGridViewTextBoxColumn.HeaderText = "FacultyId";
            this.facultyIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facultyIdDataGridViewTextBoxColumn.Name = "facultyIdDataGridViewTextBoxColumn";
            this.facultyIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 125;
            // 
            // researchAreaDataGridViewTextBoxColumn
            // 
            this.researchAreaDataGridViewTextBoxColumn.DataPropertyName = "ResearchArea";
            this.researchAreaDataGridViewTextBoxColumn.HeaderText = "ResearchArea";
            this.researchAreaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.researchAreaDataGridViewTextBoxColumn.Name = "researchAreaDataGridViewTextBoxColumn";
            this.researchAreaDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalTeachingHoursDataGridViewTextBoxColumn
            // 
            this.totalTeachingHoursDataGridViewTextBoxColumn.DataPropertyName = "TotalTeachingHours";
            this.totalTeachingHoursDataGridViewTextBoxColumn.HeaderText = "TotalTeachingHours";
            this.totalTeachingHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalTeachingHoursDataGridViewTextBoxColumn.Name = "totalTeachingHoursDataGridViewTextBoxColumn";
            this.totalTeachingHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // facultyUserDataGridViewTextBoxColumn
            // 
            this.facultyUserDataGridViewTextBoxColumn.DataPropertyName = "FacultyUser";
            this.facultyUserDataGridViewTextBoxColumn.HeaderText = "FacultyUser";
            this.facultyUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facultyUserDataGridViewTextBoxColumn.Name = "facultyUserDataGridViewTextBoxColumn";
            this.facultyUserDataGridViewTextBoxColumn.Width = 125;
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataSource = typeof(MidProjectDb.UI.Faculty);
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
            this.Back_btn.Location = new System.Drawing.Point(208, 374);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(174, 64);
            this.Back_btn.TabIndex = 18;
            this.Back_btn.Text = "Back";
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // UserInputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 450);
            this.Controls.Add(this.panel1);
            this.Name = "UserInputs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInputs";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label Userinfo_lbl;
        public Guna.UI2.WinForms.Guna2Button Next_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn researchAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTeachingHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        public Guna.UI2.WinForms.Guna2Button Back_btn;
    }
}