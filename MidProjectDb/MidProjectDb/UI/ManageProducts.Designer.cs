namespace MidProjectDb.UI
{
    partial class ManageProducts
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
            this.Delete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.descry_txtbox = new System.Windows.Forms.TextBox();
            this.title_txtbox = new System.Windows.Forms.TextBox();
            this.Description_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.Save_btn = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Projects_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ManageProjects_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Delete_btn);
            this.panel1.Controls.Add(this.Update_btn);
            this.panel1.Controls.Add(this.descry_txtbox);
            this.panel1.Controls.Add(this.title_txtbox);
            this.panel1.Controls.Add(this.Description_lbl);
            this.panel1.Controls.Add(this.title_lbl);
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.Save_btn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Projects_lbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1615, 686);
            this.panel1.TabIndex = 0;
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
            this.Delete_btn.Location = new System.Drawing.Point(992, 599);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(174, 55);
            this.Delete_btn.TabIndex = 32;
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
            this.Update_btn.Location = new System.Drawing.Point(433, 599);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(174, 55);
            this.Update_btn.TabIndex = 31;
            this.Update_btn.Text = "Update";
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // descry_txtbox
            // 
            this.descry_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descry_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descry_txtbox.Location = new System.Drawing.Point(865, 437);
            this.descry_txtbox.Multiline = true;
            this.descry_txtbox.Name = "descry_txtbox";
            this.descry_txtbox.Size = new System.Drawing.Size(301, 22);
            this.descry_txtbox.TabIndex = 30;
            // 
            // title_txtbox
            // 
            this.title_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_txtbox.Location = new System.Drawing.Point(865, 391);
            this.title_txtbox.Name = "title_txtbox";
            this.title_txtbox.Size = new System.Drawing.Size(301, 27);
            this.title_txtbox.TabIndex = 29;
            // 
            // Description_lbl
            // 
            this.Description_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Description_lbl.AutoSize = true;
            this.Description_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_lbl.Location = new System.Drawing.Point(427, 427);
            this.Description_lbl.Name = "Description_lbl";
            this.Description_lbl.Size = new System.Drawing.Size(240, 32);
            this.Description_lbl.TabIndex = 28;
            this.Description_lbl.Text = "Enter Description:";
            // 
            // title_lbl
            // 
            this.title_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(427, 384);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(152, 32);
            this.title_lbl.TabIndex = 27;
            this.title_lbl.Text = "Enter Title:";
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
            this.Back_lbl.Location = new System.Drawing.Point(433, 504);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(174, 55);
            this.Back_lbl.TabIndex = 26;
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
            this.Save_btn.Location = new System.Drawing.Point(992, 504);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(174, 55);
            this.Save_btn.TabIndex = 25;
            this.Save_btn.Text = "Add";
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(433, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // Projects_lbl
            // 
            this.Projects_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Projects_lbl.AutoSize = true;
            this.Projects_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects_lbl.Location = new System.Drawing.Point(427, 156);
            this.Projects_lbl.Name = "Projects_lbl";
            this.Projects_lbl.Size = new System.Drawing.Size(125, 32);
            this.Projects_lbl.TabIndex = 23;
            this.Projects_lbl.Text = "Projects:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.ManageProjects_lbl);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1615, 142);
            this.panel2.TabIndex = 2;
            // 
            // ManageProjects_lbl
            // 
            this.ManageProjects_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManageProjects_lbl.AutoSize = true;
            this.ManageProjects_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.ManageProjects_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageProjects_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.ManageProjects_lbl.Location = new System.Drawing.Point(623, 53);
            this.ManageProjects_lbl.Name = "ManageProjects_lbl";
            this.ManageProjects_lbl.Size = new System.Drawing.Size(331, 49);
            this.ManageProjects_lbl.TabIndex = 1;
            this.ManageProjects_lbl.Text = "Manage Projects";
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1615, 686);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
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
        private System.Windows.Forms.Label ManageProjects_lbl;
        private System.Windows.Forms.Label Projects_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button Save_btn;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
        private System.Windows.Forms.Label Description_lbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox descry_txtbox;
        private System.Windows.Forms.TextBox title_txtbox;
        private Guna.UI2.WinForms.Guna2Button Update_btn;
        private Guna.UI2.WinForms.Guna2Button Delete_btn;
    }
}