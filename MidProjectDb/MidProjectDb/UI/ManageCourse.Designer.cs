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
            this.Del_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.coursetype_combo = new System.Windows.Forms.ComboBox();
            this.Add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Contact_txtbox = new System.Windows.Forms.TextBox();
            this.contactHours_lbl = new System.Windows.Forms.Label();
            this.Credithour_txtbox = new System.Windows.Forms.TextBox();
            this.hours_lbl = new System.Windows.Forms.Label();
            this.type_lbl = new System.Windows.Forms.Label();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.Courses_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ManageCourse_lbl = new System.Windows.Forms.Label();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Del_btn);
            this.panel1.Controls.Add(this.Update_btn);
            this.panel1.Controls.Add(this.coursetype_combo);
            this.panel1.Controls.Add(this.Add_btn);
            this.panel1.Controls.Add(this.Contact_txtbox);
            this.panel1.Controls.Add(this.contactHours_lbl);
            this.panel1.Controls.Add(this.Credithour_txtbox);
            this.panel1.Controls.Add(this.hours_lbl);
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
            this.panel1.Size = new System.Drawing.Size(1300, 689);
            this.panel1.TabIndex = 0;
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
            this.Del_btn.Location = new System.Drawing.Point(979, 609);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(174, 55);
            this.Del_btn.TabIndex = 36;
            this.Del_btn.Text = "Delete";
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Update_btn.BorderRadius = 20;
            this.Update_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Update_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Update_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Update_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Update_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Update_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.ForeColor = System.Drawing.Color.White;
            this.Update_btn.Location = new System.Drawing.Point(755, 609);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(174, 55);
            this.Update_btn.TabIndex = 35;
            this.Update_btn.Text = "Update";
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // coursetype_combo
            // 
            this.coursetype_combo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.coursetype_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coursetype_combo.FormattingEnabled = true;
            this.coursetype_combo.Items.AddRange(new object[] {
            "Theory",
            "Lab"});
            this.coursetype_combo.Location = new System.Drawing.Point(849, 436);
            this.coursetype_combo.Name = "coursetype_combo";
            this.coursetype_combo.Size = new System.Drawing.Size(301, 24);
            this.coursetype_combo.TabIndex = 34;
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Add_btn.BorderRadius = 20;
            this.Add_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Add_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.White;
            this.Add_btn.Location = new System.Drawing.Point(520, 609);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(174, 55);
            this.Add_btn.TabIndex = 33;
            this.Add_btn.Text = "Add";
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Contact_txtbox
            // 
            this.Contact_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Contact_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_txtbox.Location = new System.Drawing.Point(849, 516);
            this.Contact_txtbox.Name = "Contact_txtbox";
            this.Contact_txtbox.Size = new System.Drawing.Size(301, 27);
            this.Contact_txtbox.TabIndex = 32;
            // 
            // contactHours_lbl
            // 
            this.contactHours_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contactHours_lbl.AutoSize = true;
            this.contactHours_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactHours_lbl.Location = new System.Drawing.Point(265, 509);
            this.contactHours_lbl.Name = "contactHours_lbl";
            this.contactHours_lbl.Size = new System.Drawing.Size(277, 32);
            this.contactHours_lbl.TabIndex = 31;
            this.contactHours_lbl.Text = "Enter Contact Hours:";
            // 
            // Credithour_txtbox
            // 
            this.Credithour_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Credithour_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credithour_txtbox.Location = new System.Drawing.Point(849, 474);
            this.Credithour_txtbox.Name = "Credithour_txtbox";
            this.Credithour_txtbox.Size = new System.Drawing.Size(301, 27);
            this.Credithour_txtbox.TabIndex = 30;
            // 
            // hours_lbl
            // 
            this.hours_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hours_lbl.AutoSize = true;
            this.hours_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_lbl.Location = new System.Drawing.Point(265, 467);
            this.hours_lbl.Name = "hours_lbl";
            this.hours_lbl.Size = new System.Drawing.Size(255, 32);
            this.hours_lbl.TabIndex = 29;
            this.hours_lbl.Text = "Enter Credit Hours:";
            // 
            // type_lbl
            // 
            this.type_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.type_lbl.AutoSize = true;
            this.type_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_lbl.Location = new System.Drawing.Point(265, 428);
            this.type_lbl.Name = "type_lbl";
            this.type_lbl.Size = new System.Drawing.Size(258, 32);
            this.type_lbl.TabIndex = 27;
            this.type_lbl.Text = "Enter Course Type:";
            // 
            // name_txtbox
            // 
            this.name_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txtbox.Location = new System.Drawing.Point(849, 394);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(304, 27);
            this.name_txtbox.TabIndex = 26;
            // 
            // Name_lbl
            // 
            this.Name_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(265, 394);
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
            this.Back_lbl.Location = new System.Drawing.Point(271, 609);
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
            this.Courses_lbl.Location = new System.Drawing.Point(265, 159);
            this.Courses_lbl.Name = "Courses_lbl";
            this.Courses_lbl.Size = new System.Drawing.Size(127, 32);
            this.Courses_lbl.TabIndex = 22;
            this.Courses_lbl.Text = "Courses:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(882, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.ManageCourse_lbl);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 142);
            this.panel2.TabIndex = 2;
            // 
            // ManageCourse_lbl
            // 
            this.ManageCourse_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManageCourse_lbl.AutoSize = true;
            this.ManageCourse_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.ManageCourse_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageCourse_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.ManageCourse_lbl.Location = new System.Drawing.Point(511, 53);
            this.ManageCourse_lbl.Name = "ManageCourse_lbl";
            this.ManageCourse_lbl.Size = new System.Drawing.Size(331, 49);
            this.ManageCourse_lbl.TabIndex = 1;
            this.ManageCourse_lbl.Text = "Manage Courses";
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataSource = typeof(MidProjectDb.BL.Course);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(MidProjectDb.BL.Course);
            // 
            // ManageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1300, 689);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCourse";
            this.Load += new System.EventHandler(this.ManageCourse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button Add_btn;
        private System.Windows.Forms.ComboBox coursetype_combo;
        private Guna.UI2.WinForms.Guna2Button Del_btn;
        private Guna.UI2.WinForms.Guna2Button Update_btn;
    }
}