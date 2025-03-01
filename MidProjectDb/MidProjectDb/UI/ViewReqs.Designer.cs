namespace MidProjectDb.UI
{
    partial class ViewReqs
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdminStaff_lbl = new System.Windows.Forms.Label();
            this.facProjects_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facultyRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultyReqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyReqBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.facProjects_lbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.AdminStaff_lbl);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 142);
            this.panel2.TabIndex = 2;
            // 
            // AdminStaff_lbl
            // 
            this.AdminStaff_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AdminStaff_lbl.AutoSize = true;
            this.AdminStaff_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.AdminStaff_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminStaff_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.AdminStaff_lbl.Location = new System.Drawing.Point(267, 55);
            this.AdminStaff_lbl.Name = "AdminStaff_lbl";
            this.AdminStaff_lbl.Size = new System.Drawing.Size(397, 49);
            this.AdminStaff_lbl.TabIndex = 1;
            this.AdminStaff_lbl.Text = "Administrative Staff";
            // 
            // facProjects_lbl
            // 
            this.facProjects_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.facProjects_lbl.AutoSize = true;
            this.facProjects_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facProjects_lbl.Location = new System.Drawing.Point(80, 165);
            this.facProjects_lbl.Name = "facProjects_lbl";
            this.facProjects_lbl.Size = new System.Drawing.Size(243, 32);
            this.facProjects_lbl.TabIndex = 9;
            this.facProjects_lbl.Text = "Current Requests:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestidDataGridViewTextBoxColumn,
            this.facultyidDataGridViewTextBoxColumn,
            this.statusidDataGridViewTextBoxColumn,
            this.itemidDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.requestdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facultyReqBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(86, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(829, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // facultyRequestBindingSource
            // 
            this.facultyRequestBindingSource.DataSource = typeof(MidProjectDb.UI.FacultyRequest);
            // 
            // facultyReqBindingSource
            // 
            this.facultyReqBindingSource.DataSource = typeof(MidProjectDb.UI.FacultyReq);
            // 
            // requestidDataGridViewTextBoxColumn
            // 
            this.requestidDataGridViewTextBoxColumn.DataPropertyName = "requestid";
            this.requestidDataGridViewTextBoxColumn.HeaderText = "requestid";
            this.requestidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestidDataGridViewTextBoxColumn.Name = "requestidDataGridViewTextBoxColumn";
            this.requestidDataGridViewTextBoxColumn.Width = 125;
            // 
            // facultyidDataGridViewTextBoxColumn
            // 
            this.facultyidDataGridViewTextBoxColumn.DataPropertyName = "facultyid";
            this.facultyidDataGridViewTextBoxColumn.HeaderText = "facultyid";
            this.facultyidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facultyidDataGridViewTextBoxColumn.Name = "facultyidDataGridViewTextBoxColumn";
            this.facultyidDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusidDataGridViewTextBoxColumn
            // 
            this.statusidDataGridViewTextBoxColumn.DataPropertyName = "statusid";
            this.statusidDataGridViewTextBoxColumn.HeaderText = "statusid";
            this.statusidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusidDataGridViewTextBoxColumn.Name = "statusidDataGridViewTextBoxColumn";
            this.statusidDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "itemid";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "itemid";
            this.itemidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            this.itemidDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // requestdateDataGridViewTextBoxColumn
            // 
            this.requestdateDataGridViewTextBoxColumn.DataPropertyName = "request_date";
            this.requestdateDataGridViewTextBoxColumn.HeaderText = "request_date";
            this.requestdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requestdateDataGridViewTextBoxColumn.Name = "requestdateDataGridViewTextBoxColumn";
            this.requestdateDataGridViewTextBoxColumn.Width = 125;
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
            this.Back_lbl.Location = new System.Drawing.Point(398, 383);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(174, 55);
            this.Back_lbl.TabIndex = 30;
            this.Back_lbl.Text = "Back";
            this.Back_lbl.Click += new System.EventHandler(this.Back_lbl_Click);
            // 
            // ViewReqs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ViewReqs";
            this.Text = "ViewReqs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyReqBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AdminStaff_lbl;
        private System.Windows.Forms.Label facProjects_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource facultyReqBindingSource;
        private System.Windows.Forms.BindingSource facultyRequestBindingSource;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
    }
}