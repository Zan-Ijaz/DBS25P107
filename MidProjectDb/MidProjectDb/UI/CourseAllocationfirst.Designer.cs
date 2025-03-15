namespace MidProjectDb.UI
{
    partial class CourseAllocationfirst
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Instructors = new System.Windows.Forms.Label();
            this.Sem_combobox = new System.Windows.Forms.ComboBox();
            this.Courses_combobox = new System.Windows.Forms.ComboBox();
            this.Instructor_comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facultyCourse_lbl = new System.Windows.Forms.Label();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.Next_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cousresallocation_lbl = new System.Windows.Forms.Label();
            this.update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Del_btn = new Guna.UI2.WinForms.Guna2Button();
            this.facultycourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultycourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Del_btn);
            this.panel1.Controls.Add(this.update_btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Instructors);
            this.panel1.Controls.Add(this.Sem_combobox);
            this.panel1.Controls.Add(this.Courses_combobox);
            this.panel1.Controls.Add(this.Instructor_comboBox);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.facultyCourse_lbl);
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.Next_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1782, 769);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Semesters:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Courses (with contact hours):";
            // 
            // Instructors
            // 
            this.Instructors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Instructors.AutoSize = true;
            this.Instructors.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructors.Location = new System.Drawing.Point(513, 374);
            this.Instructors.Name = "Instructors";
            this.Instructors.Size = new System.Drawing.Size(429, 32);
            this.Instructors.TabIndex = 25;
            this.Instructors.Text = "Instructors (with available hours):";
            // 
            // Sem_combobox
            // 
            this.Sem_combobox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sem_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sem_combobox.FormattingEnabled = true;
            this.Sem_combobox.Location = new System.Drawing.Point(958, 490);
            this.Sem_combobox.Name = "Sem_combobox";
            this.Sem_combobox.Size = new System.Drawing.Size(258, 24);
            this.Sem_combobox.TabIndex = 24;
            // 
            // Courses_combobox
            // 
            this.Courses_combobox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Courses_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Courses_combobox.FormattingEnabled = true;
            this.Courses_combobox.Location = new System.Drawing.Point(958, 439);
            this.Courses_combobox.Name = "Courses_combobox";
            this.Courses_combobox.Size = new System.Drawing.Size(258, 24);
            this.Courses_combobox.TabIndex = 23;
            // 
            // Instructor_comboBox
            // 
            this.Instructor_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Instructor_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Instructor_comboBox.FormattingEnabled = true;
            this.Instructor_comboBox.Location = new System.Drawing.Point(958, 374);
            this.Instructor_comboBox.Name = "Instructor_comboBox";
            this.Instructor_comboBox.Size = new System.Drawing.Size(258, 24);
            this.Instructor_comboBox.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(519, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(697, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // facultyCourse_lbl
            // 
            this.facultyCourse_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.facultyCourse_lbl.AutoSize = true;
            this.facultyCourse_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyCourse_lbl.Location = new System.Drawing.Point(513, 144);
            this.facultyCourse_lbl.Name = "facultyCourse_lbl";
            this.facultyCourse_lbl.Size = new System.Drawing.Size(226, 32);
            this.facultyCourse_lbl.TabIndex = 20;
            this.facultyCourse_lbl.Text = "Faculty Courses:";
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
            this.Back_lbl.Location = new System.Drawing.Point(519, 560);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(174, 55);
            this.Back_lbl.TabIndex = 19;
            this.Back_lbl.Text = "Back";
            this.Back_lbl.Click += new System.EventHandler(this.Back_lbl_Click);
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
            this.Next_btn.Location = new System.Drawing.Point(1042, 560);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(174, 55);
            this.Next_btn.TabIndex = 18;
            this.Next_btn.Text = "Allocate Course";
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Cousresallocation_lbl);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1779, 125);
            this.panel2.TabIndex = 4;
            // 
            // Cousresallocation_lbl
            // 
            this.Cousresallocation_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cousresallocation_lbl.AutoSize = true;
            this.Cousresallocation_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Cousresallocation_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cousresallocation_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Cousresallocation_lbl.Location = new System.Drawing.Point(723, 33);
            this.Cousresallocation_lbl.Name = "Cousresallocation_lbl";
            this.Cousresallocation_lbl.Size = new System.Drawing.Size(350, 49);
            this.Cousresallocation_lbl.TabIndex = 0;
            this.Cousresallocation_lbl.Text = "Course Allocation";
            // 
            // update_btn
            // 
            this.update_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.update_btn.BorderRadius = 20;
            this.update_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.update_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(519, 672);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(174, 55);
            this.update_btn.TabIndex = 28;
            this.update_btn.Text = "Update";
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // Del_btn
            // 
            this.Del_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Del_btn.BorderRadius = 20;
            this.Del_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Del_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Del_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Del_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Del_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Del_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_btn.ForeColor = System.Drawing.Color.White;
            this.Del_btn.Location = new System.Drawing.Point(1042, 672);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(174, 55);
            this.Del_btn.TabIndex = 29;
            this.Del_btn.Text = "Delete";
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // facultycourseBindingSource
            // 
            this.facultycourseBindingSource.DataSource = typeof(MidProjectDb.BL.Facultycourse);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(MidProjectDb.BL.Course);
            // 
            // CourseAllocationfirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 769);
            this.Controls.Add(this.panel1);
            this.Name = "CourseAllocationfirst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseAllocationfirst";
            this.Load += new System.EventHandler(this.CourseAllocationfirst_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultycourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label Cousresallocation_lbl;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
        private Guna.UI2.WinForms.Guna2Button Next_btn;
        private System.Windows.Forms.Label facultyCourse_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource facultycourseBindingSource;
        private System.Windows.Forms.ComboBox Sem_combobox;
        private System.Windows.Forms.ComboBox Courses_combobox;
        private System.Windows.Forms.ComboBox Instructor_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Instructors;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Guna.UI2.WinForms.Guna2Button update_btn;
        private Guna.UI2.WinForms.Guna2Button Del_btn;
    }
}