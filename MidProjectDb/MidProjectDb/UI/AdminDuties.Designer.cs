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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Del_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sem_comboBox = new System.Windows.Forms.ComboBox();
            this.faculty_comboBox = new System.Windows.Forms.ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.rolefacname_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Supervision_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Workoad_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Del_btn);
            this.panel1.Controls.Add(this.Update_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sem_comboBox);
            this.panel1.Controls.Add(this.faculty_comboBox);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.rolefacname_txtbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Supervision_lbl);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1754, 771);
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
            this.Del_btn.Location = new System.Drawing.Point(1067, 704);
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
            this.Update_btn.Location = new System.Drawing.Point(467, 704);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(174, 55);
            this.Update_btn.TabIndex = 35;
            this.Update_btn.Text = "Update";
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "Select Semester:";
            // 
            // sem_comboBox
            // 
            this.sem_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sem_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sem_comboBox.FormattingEnabled = true;
            this.sem_comboBox.Location = new System.Drawing.Point(932, 559);
            this.sem_comboBox.Name = "sem_comboBox";
            this.sem_comboBox.Size = new System.Drawing.Size(305, 24);
            this.sem_comboBox.TabIndex = 33;
            // 
            // faculty_comboBox
            // 
            this.faculty_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.faculty_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.faculty_comboBox.FormattingEnabled = true;
            this.faculty_comboBox.Location = new System.Drawing.Point(932, 413);
            this.faculty_comboBox.Name = "faculty_comboBox";
            this.faculty_comboBox.Size = new System.Drawing.Size(309, 24);
            this.faculty_comboBox.TabIndex = 32;
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
            this.guna2Button1.Location = new System.Drawing.Point(1067, 610);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(174, 55);
            this.guna2Button1.TabIndex = 31;
            this.guna2Button1.Text = "Assign";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.Back_lbl.Location = new System.Drawing.Point(467, 610);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(174, 55);
            this.Back_lbl.TabIndex = 30;
            this.Back_lbl.Text = "Back";
            this.Back_lbl.Click += new System.EventHandler(this.Back_lbl_Click);
            // 
            // rolefacname_txtbox
            // 
            this.rolefacname_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rolefacname_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolefacname_txtbox.Location = new System.Drawing.Point(932, 484);
            this.rolefacname_txtbox.Name = "rolefacname_txtbox";
            this.rolefacname_txtbox.Size = new System.Drawing.Size(309, 27);
            this.rolefacname_txtbox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enter Role Name:";
            // 
            // Supervision_lbl
            // 
            this.Supervision_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Supervision_lbl.AutoSize = true;
            this.Supervision_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supervision_lbl.Location = new System.Drawing.Point(461, 413);
            this.Supervision_lbl.Name = "Supervision_lbl";
            this.Supervision_lbl.Size = new System.Drawing.Size(201, 32);
            this.Supervision_lbl.TabIndex = 17;
            this.Supervision_lbl.Text = "Select Faculty:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(467, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 158);
            this.dataGridView1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Current Admin Duties:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Workoad_lbl);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1751, 142);
            this.panel2.TabIndex = 4;
            // 
            // Workoad_lbl
            // 
            this.Workoad_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Workoad_lbl.AutoSize = true;
            this.Workoad_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.Workoad_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Workoad_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Workoad_lbl.Location = new System.Drawing.Point(687, 45);
            this.Workoad_lbl.Name = "Workoad_lbl";
            this.Workoad_lbl.Size = new System.Drawing.Size(416, 49);
            this.Workoad_lbl.TabIndex = 1;
            this.Workoad_lbl.Text = "Adminstrative Duties";
            // 
            // AdminDuties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1754, 771);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDuties";
            this.Text = "AdminDuties";
            this.Load += new System.EventHandler(this.AdminDuties_Load);
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
        private System.Windows.Forms.Label Workoad_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Supervision_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rolefacname_txtbox;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ComboBox faculty_comboBox;
        private System.Windows.Forms.ComboBox sem_comboBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Update_btn;
        private Guna.UI2.WinForms.Guna2Button Del_btn;
    }
}