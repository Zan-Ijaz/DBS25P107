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
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Rooms_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Addroom_lbl = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.romType_lbl = new System.Windows.Forms.Label();
            this.capacity_lbl = new System.Windows.Forms.Label();
            this.roomid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.type_txtbox = new System.Windows.Forms.TextBox();
            this.capacity_txtbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.capacity_txtbox);
            this.panel1.Controls.Add(this.type_txtbox);
            this.panel1.Controls.Add(this.name_txtbox);
            this.panel1.Controls.Add(this.capacity_lbl);
            this.panel1.Controls.Add(this.romType_lbl);
            this.panel1.Controls.Add(this.Name_lbl);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Rooms_lbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 615);
            this.panel1.TabIndex = 0;
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
            this.Back_lbl.Location = new System.Drawing.Point(93, 535);
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomid,
            this.roomnameDataGridViewTextBoxColumn,
            this.roomtypeDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(149, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(MidProjectDb.UI.Room);
            // 
            // Rooms_lbl
            // 
            this.Rooms_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Rooms_lbl.AutoSize = true;
            this.Rooms_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rooms_lbl.Location = new System.Drawing.Point(87, 145);
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
            this.panel2.Size = new System.Drawing.Size(800, 142);
            this.panel2.TabIndex = 3;
            // 
            // Addroom_lbl
            // 
            this.Addroom_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Addroom_lbl.AutoSize = true;
            this.Addroom_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.Addroom_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addroom_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Addroom_lbl.Location = new System.Drawing.Point(217, 55);
            this.Addroom_lbl.Name = "Addroom_lbl";
            this.Addroom_lbl.Size = new System.Drawing.Size(309, 49);
            this.Addroom_lbl.TabIndex = 1;
            this.Addroom_lbl.Text = "Manage Rooms";
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
            this.guna2Button1.Location = new System.Drawing.Point(533, 535);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(174, 55);
            this.guna2Button1.TabIndex = 29;
            this.guna2Button1.Text = "Add";
            // 
            // Name_lbl
            // 
            this.Name_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.Location = new System.Drawing.Point(87, 347);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(254, 32);
            this.Name_lbl.TabIndex = 30;
            this.Name_lbl.Text = "Enter Room Name:";
            // 
            // romType_lbl
            // 
            this.romType_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.romType_lbl.AutoSize = true;
            this.romType_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romType_lbl.Location = new System.Drawing.Point(87, 407);
            this.romType_lbl.Name = "romType_lbl";
            this.romType_lbl.Size = new System.Drawing.Size(242, 32);
            this.romType_lbl.TabIndex = 31;
            this.romType_lbl.Text = "Enter Room Type:";
            // 
            // capacity_lbl
            // 
            this.capacity_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.capacity_lbl.AutoSize = true;
            this.capacity_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity_lbl.Location = new System.Drawing.Point(87, 476);
            this.capacity_lbl.Name = "capacity_lbl";
            this.capacity_lbl.Size = new System.Drawing.Size(208, 32);
            this.capacity_lbl.TabIndex = 32;
            this.capacity_lbl.Text = "Enter Capacity:";
            // 
            // roomid
            // 
            this.roomid.DataPropertyName = "roomid";
            this.roomid.HeaderText = "roomid";
            this.roomid.MinimumWidth = 6;
            this.roomid.Name = "roomid";
            this.roomid.ReadOnly = true;
            this.roomid.Width = 125;
            // 
            // roomnameDataGridViewTextBoxColumn
            // 
            this.roomnameDataGridViewTextBoxColumn.DataPropertyName = "roomname";
            this.roomnameDataGridViewTextBoxColumn.HeaderText = "roomname";
            this.roomnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomnameDataGridViewTextBoxColumn.Name = "roomnameDataGridViewTextBoxColumn";
            this.roomnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomtypeDataGridViewTextBoxColumn
            // 
            this.roomtypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.roomtypeDataGridViewTextBoxColumn.DataPropertyName = "roomtype";
            this.roomtypeDataGridViewTextBoxColumn.HeaderText = "roomtype";
            this.roomtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomtypeDataGridViewTextBoxColumn.Name = "roomtypeDataGridViewTextBoxColumn";
            this.roomtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // name_txtbox
            // 
            this.name_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txtbox.Location = new System.Drawing.Point(406, 354);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(301, 27);
            this.name_txtbox.TabIndex = 33;
            // 
            // type_txtbox
            // 
            this.type_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.type_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_txtbox.Location = new System.Drawing.Point(406, 412);
            this.type_txtbox.Name = "type_txtbox";
            this.type_txtbox.Size = new System.Drawing.Size(301, 27);
            this.type_txtbox.TabIndex = 34;
            // 
            // capacity_txtbox
            // 
            this.capacity_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.capacity_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity_txtbox.Location = new System.Drawing.Point(406, 457);
            this.capacity_txtbox.Name = "capacity_txtbox";
            this.capacity_txtbox.Size = new System.Drawing.Size(301, 27);
            this.capacity_txtbox.TabIndex = 35;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.panel1);
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label capacity_lbl;
        private System.Windows.Forms.Label romType_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox capacity_txtbox;
        private System.Windows.Forms.TextBox type_txtbox;
        private System.Windows.Forms.TextBox name_txtbox;
    }
}