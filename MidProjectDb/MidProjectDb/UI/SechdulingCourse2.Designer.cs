namespace MidProjectDb.UI
{
    partial class SechdulingCourse2
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
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.Startdate = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.roomname_txtbox = new System.Windows.Forms.TextBox();
            this.facultyname_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Supervision_lbl = new System.Windows.Forms.Label();
            this.Next_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.Course_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sechduleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sechduling_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EndDate);
            this.panel1.Controls.Add(this.Startdate);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.roomname_txtbox);
            this.panel1.Controls.Add(this.facultyname_txtbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Supervision_lbl);
            this.panel1.Controls.Add(this.Next_btn);
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.Course_lbl);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 706);
            this.panel1.TabIndex = 0;
            // 
            // EndDate
            // 
            this.EndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndDate.Location = new System.Drawing.Point(695, 575);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(301, 22);
            this.EndDate.TabIndex = 34;
            // 
            // Startdate
            // 
            this.Startdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Startdate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Startdate.Location = new System.Drawing.Point(695, 526);
            this.Startdate.Name = "Startdate";
            this.Startdate.Size = new System.Drawing.Size(301, 22);
            this.Startdate.TabIndex = 33;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.comboBox1.Location = new System.Drawing.Point(695, 481);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 24);
            this.comboBox1.TabIndex = 32;
            // 
            // roomname_txtbox
            // 
            this.roomname_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roomname_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomname_txtbox.Location = new System.Drawing.Point(695, 430);
            this.roomname_txtbox.Name = "roomname_txtbox";
            this.roomname_txtbox.Size = new System.Drawing.Size(301, 27);
            this.roomname_txtbox.TabIndex = 31;
            // 
            // facultyname_txtbox
            // 
            this.facultyname_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.facultyname_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyname_txtbox.Location = new System.Drawing.Point(695, 387);
            this.facultyname_txtbox.Name = "facultyname_txtbox";
            this.facultyname_txtbox.Size = new System.Drawing.Size(301, 27);
            this.facultyname_txtbox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 565);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 32);
            this.label4.TabIndex = 29;
            this.label4.Text = "Enter End Time:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 32);
            this.label3.TabIndex = 28;
            this.label3.Text = "Enter Start time:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Select day:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Enter Room Name:";
            // 
            // Supervision_lbl
            // 
            this.Supervision_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Supervision_lbl.AutoSize = true;
            this.Supervision_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supervision_lbl.Location = new System.Drawing.Point(153, 380);
            this.Supervision_lbl.Name = "Supervision_lbl";
            this.Supervision_lbl.Size = new System.Drawing.Size(267, 32);
            this.Supervision_lbl.TabIndex = 25;
            this.Supervision_lbl.Text = "Enter Faculty name:";
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
            this.Next_btn.Location = new System.Drawing.Point(865, 639);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(174, 55);
            this.Next_btn.TabIndex = 24;
            this.Next_btn.Text = "Add";
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
            this.Back_lbl.Location = new System.Drawing.Point(159, 639);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(174, 55);
            this.Back_lbl.TabIndex = 21;
            this.Back_lbl.Text = "Back";
            this.Back_lbl.Click += new System.EventHandler(this.Back_lbl_Click);
            // 
            // Course_lbl
            // 
            this.Course_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Course_lbl.AutoSize = true;
            this.Course_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_lbl.Location = new System.Drawing.Point(153, 160);
            this.Course_lbl.Name = "Course_lbl";
            this.Course_lbl.Size = new System.Drawing.Size(254, 32);
            this.Course_lbl.TabIndex = 8;
            this.Course_lbl.Text = "Sechdule Courses:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sechduleid});
            this.dataGridView1.Location = new System.Drawing.Point(159, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // Sechduleid
            // 
            this.Sechduleid.DataPropertyName = "Sechduleid";
            this.Sechduleid.HeaderText = "Sechduleid";
            this.Sechduleid.MinimumWidth = 6;
            this.Sechduleid.Name = "Sechduleid";
            this.Sechduleid.ReadOnly = true;
            this.Sechduleid.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Sechduling_lbl);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 142);
            this.panel2.TabIndex = 3;
            // 
            // Sechduling_lbl
            // 
            this.Sechduling_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sechduling_lbl.AutoSize = true;
            this.Sechduling_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.Sechduling_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sechduling_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Sechduling_lbl.Location = new System.Drawing.Point(354, 55);
            this.Sechduling_lbl.Name = "Sechduling_lbl";
            this.Sechduling_lbl.Size = new System.Drawing.Size(346, 49);
            this.Sechduling_lbl.TabIndex = 1;
            this.Sechduling_lbl.Text = "Sechdule Courses";
            // 
            // SechdulingCourse2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 706);
            this.Controls.Add(this.panel1);
            this.Name = "SechdulingCourse2";
            this.Text = "SechdulingCourse2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Sechduling_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Course_lbl;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
        private Guna.UI2.WinForms.Guna2Button Next_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Supervision_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sechduleid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roomname_txtbox;
        private System.Windows.Forms.TextBox facultyname_txtbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker Startdate;
    }
}