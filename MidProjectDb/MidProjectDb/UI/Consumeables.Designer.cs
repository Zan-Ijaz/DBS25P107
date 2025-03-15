namespace MidProjectDb.UI
{
    partial class Consumeables
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
            this.itemname_txtbox = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.Add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comsu_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddConsume_lbl = new System.Windows.Forms.Label();
            this.update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.consumableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consumableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.update_btn);
            this.panel1.Controls.Add(this.itemname_txtbox);
            this.panel1.Controls.Add(this.name_lbl);
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.Add_btn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.comsu_lbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1797, 725);
            this.panel1.TabIndex = 0;
            // 
            // itemname_txtbox
            // 
            this.itemname_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.itemname_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemname_txtbox.Location = new System.Drawing.Point(859, 362);
            this.itemname_txtbox.Name = "itemname_txtbox";
            this.itemname_txtbox.Size = new System.Drawing.Size(301, 27);
            this.itemname_txtbox.TabIndex = 29;
            // 
            // name_lbl
            // 
            this.name_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(599, 355);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(229, 32);
            this.name_lbl.TabIndex = 28;
            this.name_lbl.Text = "Enter Item name:";
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
            this.Back_lbl.Location = new System.Drawing.Point(605, 437);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(174, 55);
            this.Back_lbl.TabIndex = 27;
            this.Back_lbl.Text = "Back";
            this.Back_lbl.Click += new System.EventHandler(this.Back_lbl_Click);
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
            this.Add_btn.Location = new System.Drawing.Point(986, 437);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(174, 55);
            this.Add_btn.TabIndex = 26;
            this.Add_btn.Text = "Add";
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(669, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(491, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // comsu_lbl
            // 
            this.comsu_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comsu_lbl.AutoSize = true;
            this.comsu_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comsu_lbl.Location = new System.Drawing.Point(599, 145);
            this.comsu_lbl.Name = "comsu_lbl";
            this.comsu_lbl.Size = new System.Drawing.Size(196, 32);
            this.comsu_lbl.TabIndex = 24;
            this.comsu_lbl.Text = "Consumables:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.AddConsume_lbl);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1797, 142);
            this.panel2.TabIndex = 2;
            // 
            // AddConsume_lbl
            // 
            this.AddConsume_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddConsume_lbl.AutoSize = true;
            this.AddConsume_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.AddConsume_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddConsume_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.AddConsume_lbl.Location = new System.Drawing.Point(715, 55);
            this.AddConsume_lbl.Name = "AddConsume_lbl";
            this.AddConsume_lbl.Size = new System.Drawing.Size(359, 49);
            this.AddConsume_lbl.TabIndex = 1;
            this.AddConsume_lbl.Text = "Add Consumables";
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
            this.update_btn.Location = new System.Drawing.Point(605, 559);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(174, 55);
            this.update_btn.TabIndex = 30;
            this.update_btn.Text = "Update";
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Delete.BorderRadius = 20;
            this.Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete.FillColor = System.Drawing.Color.MidnightBlue;
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(986, 559);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(174, 55);
            this.Delete.TabIndex = 31;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // consumableBindingSource
            // 
            this.consumableBindingSource.DataSource = typeof(MidProjectDb.BL.MidProjectDb.BL.Consumable);
            // 
            // Consumeables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1797, 725);
            this.Controls.Add(this.panel1);
            this.Name = "Consumeables";
            this.Text = "Consumeables";
            this.Load += new System.EventHandler(this.Consumeables_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consumableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AddConsume_lbl;
        private System.Windows.Forms.Label comsu_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource consumableBindingSource;
        private Guna.UI2.WinForms.Guna2Button Add_btn;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox itemname_txtbox;
        private Guna.UI2.WinForms.Guna2Button Delete;
        private Guna.UI2.WinForms.Guna2Button update_btn;
    }
}