namespace MidProjectDb.UI
{
    partial class UpdateSem
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Delete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.year_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.Save_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Sems_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ManageSem_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.Delete_btn);
            this.panel1.Controls.Add(this.update_btn);
            this.panel1.Controls.Add(this.year_txtbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.Save_btn);
            this.panel1.Controls.Add(this.Sems_lbl);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1428, 701);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall"});
            this.comboBox1.Location = new System.Drawing.Point(653, 379);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(344, 24);
            this.comboBox1.TabIndex = 35;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Delete_btn.BorderRadius = 20;
            this.Delete_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Delete_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.Location = new System.Drawing.Point(823, 624);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(174, 55);
            this.Delete_btn.TabIndex = 34;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.Click += new System.EventHandler(this.Del_btn_Click);
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
            this.update_btn.Location = new System.Drawing.Point(411, 624);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(174, 55);
            this.update_btn.TabIndex = 33;
            this.update_btn.Text = "Update";
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // year_txtbox
            // 
            this.year_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.year_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_txtbox.Location = new System.Drawing.Point(653, 457);
            this.year_txtbox.Name = "year_txtbox";
            this.year_txtbox.Size = new System.Drawing.Size(344, 27);
            this.year_txtbox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 32);
            this.label2.TabIndex = 30;
            this.label2.Text = "Enter Year:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Enter Term:";
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
            this.Back_lbl.Location = new System.Drawing.Point(411, 532);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(174, 55);
            this.Back_lbl.TabIndex = 28;
            this.Back_lbl.Text = "Back";
            this.Back_lbl.Click += new System.EventHandler(this.Back_lbl_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Save_btn.BorderRadius = 20;
            this.Save_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Save_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Save_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Save_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Save_btn.FillColor = System.Drawing.Color.MidnightBlue;
            this.Save_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.ForeColor = System.Drawing.Color.White;
            this.Save_btn.Location = new System.Drawing.Point(823, 532);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(174, 55);
            this.Save_btn.TabIndex = 27;
            this.Save_btn.Text = "Add";
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Sems_lbl
            // 
            this.Sems_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sems_lbl.AutoSize = true;
            this.Sems_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sems_lbl.Location = new System.Drawing.Point(405, 159);
            this.Sems_lbl.Name = "Sems_lbl";
            this.Sems_lbl.Size = new System.Drawing.Size(157, 32);
            this.Sems_lbl.TabIndex = 26;
            this.Sems_lbl.Text = "Semesters:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(586, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.ManageSem_lbl);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1428, 142);
            this.panel2.TabIndex = 3;
            // 
            // ManageSem_lbl
            // 
            this.ManageSem_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManageSem_lbl.AutoSize = true;
            this.ManageSem_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.ManageSem_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageSem_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.ManageSem_lbl.Location = new System.Drawing.Point(530, 53);
            this.ManageSem_lbl.Name = "ManageSem_lbl";
            this.ManageSem_lbl.Size = new System.Drawing.Size(350, 49);
            this.ManageSem_lbl.TabIndex = 1;
            this.ManageSem_lbl.Text = "Manage Semester";
            // 
            // UpdateSem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1428, 701);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateSem";
            this.Text = "UpdateSem";
            this.Load += new System.EventHandler(this.UpdateSem_Load);
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
        private System.Windows.Forms.Label ManageSem_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Sems_lbl;
        private Guna.UI2.WinForms.Guna2Button Save_btn;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox year_txtbox;
        private Guna.UI2.WinForms.Guna2Button update_btn;
        private Guna.UI2.WinForms.Guna2Button Delete_btn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}