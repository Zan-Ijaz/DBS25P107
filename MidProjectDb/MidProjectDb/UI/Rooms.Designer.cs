namespace MidProjectDb.UI
{
    partial class Rooms
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Delete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.capacity_txtbox = new System.Windows.Forms.TextBox();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.capacity_lbl = new System.Windows.Forms.Label();
            this.romType_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rooms_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Addroom_lbl = new System.Windows.Forms.Label();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.Delete_btn);
            this.panel1.Controls.Add(this.Update_btn);
            this.panel1.Controls.Add(this.capacity_txtbox);
            this.panel1.Controls.Add(this.name_txtbox);
            this.panel1.Controls.Add(this.capacity_lbl);
            this.panel1.Controls.Add(this.romType_lbl);
            this.panel1.Controls.Add(this.Name_lbl);
            this.panel1.Controls.Add(this.Add_btn);
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Rooms_lbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1684, 769);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Classroom",
            "Lab"});
            this.comboBox1.Location = new System.Drawing.Point(848, 444);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 24);
            this.comboBox1.TabIndex = 38;
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
            this.Delete_btn.Location = new System.Drawing.Point(975, 659);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(174, 55);
            this.Delete_btn.TabIndex = 37;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
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
            this.Update_btn.Location = new System.Drawing.Point(535, 659);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(174, 55);
            this.Update_btn.TabIndex = 36;
            this.Update_btn.Text = "Update";
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // capacity_txtbox
            // 
            this.capacity_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.capacity_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity_txtbox.Location = new System.Drawing.Point(848, 503);
            this.capacity_txtbox.Name = "capacity_txtbox";
            this.capacity_txtbox.Size = new System.Drawing.Size(301, 27);
            this.capacity_txtbox.TabIndex = 35;
            // 
            // name_txtbox
            // 
            this.name_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txtbox.Location = new System.Drawing.Point(848, 374);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(301, 27);
            this.name_txtbox.TabIndex = 33;
            // 
            // capacity_lbl
            // 
            this.capacity_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.capacity_lbl.AutoSize = true;
            this.capacity_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity_lbl.Location = new System.Drawing.Point(529, 496);
            this.capacity_lbl.Name = "capacity_lbl";
            this.capacity_lbl.Size = new System.Drawing.Size(208, 32);
            this.capacity_lbl.TabIndex = 32;
            this.capacity_lbl.Text = "Enter Capacity:";
            // 
            // romType_lbl
            // 
            this.romType_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.romType_lbl.AutoSize = true;
            this.romType_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romType_lbl.Location = new System.Drawing.Point(529, 437);
            this.romType_lbl.Name = "romType_lbl";
            this.romType_lbl.Size = new System.Drawing.Size(242, 32);
            this.romType_lbl.TabIndex = 31;
            this.romType_lbl.Text = "Enter Room Type:";
            // 
            // Name_lbl
            // 
            this.Name_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(529, 374);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(254, 32);
            this.Name_lbl.TabIndex = 30;
            this.Name_lbl.Text = "Enter Room Name:";
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
            this.Add_btn.Location = new System.Drawing.Point(975, 569);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(174, 55);
            this.Add_btn.TabIndex = 29;
            this.Add_btn.Text = "Add";
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
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
            this.Back_lbl.Location = new System.Drawing.Point(535, 569);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(174, 55);
            this.Back_lbl.TabIndex = 28;
            this.Back_lbl.Text = "Back";
            this.Back_lbl.Click += new System.EventHandler(this.Back_lbl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(535, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(614, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // Rooms_lbl
            // 
            this.Rooms_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Rooms_lbl.AutoSize = true;
            this.Rooms_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rooms_lbl.Location = new System.Drawing.Point(529, 145);
            this.Rooms_lbl.Name = "Rooms_lbl";
            this.Rooms_lbl.Size = new System.Drawing.Size(111, 32);
            this.Rooms_lbl.TabIndex = 25;
            this.Rooms_lbl.Text = "Rooms:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Addroom_lbl);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1684, 142);
            this.panel2.TabIndex = 3;
            // 
            // Addroom_lbl
            // 
            this.Addroom_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Addroom_lbl.AutoSize = true;
            this.Addroom_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.Addroom_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addroom_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Addroom_lbl.Location = new System.Drawing.Point(659, 55);
            this.Addroom_lbl.Name = "Addroom_lbl";
            this.Addroom_lbl.Size = new System.Drawing.Size(309, 49);
            this.Addroom_lbl.TabIndex = 1;
            this.Addroom_lbl.Text = "Manage Rooms";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(MidProjectDb.UI.Room);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 769);
            this.Controls.Add(this.panel1);
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Addroom_lbl;
        private System.Windows.Forms.Label Rooms_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
        private Guna.UI2.WinForms.Guna2Button Add_btn;
        private System.Windows.Forms.Label capacity_lbl;
        private System.Windows.Forms.Label romType_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.TextBox capacity_txtbox;
        private System.Windows.Forms.TextBox name_txtbox;
        private Guna.UI2.WinForms.Guna2Button Update_btn;
        private Guna.UI2.WinForms.Guna2Button Delete_btn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}