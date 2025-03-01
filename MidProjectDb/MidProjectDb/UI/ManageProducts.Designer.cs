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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.supervisionhour_txtbox = new System.Windows.Forms.TextBox();
            this.Description_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.Save_btn = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Projects_lbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ManageProjects_lbl = new System.Windows.Forms.Label();
            this.projectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descreptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.supervisionhour_txtbox);
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
            this.panel1.Size = new System.Drawing.Size(800, 640);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(439, 470);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 22);
            this.textBox1.TabIndex = 30;
            // 
            // supervisionhour_txtbox
            // 
            this.supervisionhour_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.supervisionhour_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisionhour_txtbox.Location = new System.Drawing.Point(439, 405);
            this.supervisionhour_txtbox.Name = "supervisionhour_txtbox";
            this.supervisionhour_txtbox.Size = new System.Drawing.Size(301, 27);
            this.supervisionhour_txtbox.TabIndex = 29;
            // 
            // Description_lbl
            // 
            this.Description_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Description_lbl.AutoSize = true;
            this.Description_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_lbl.Location = new System.Drawing.Point(161, 460);
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
            this.title_lbl.Location = new System.Drawing.Point(161, 405);
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
            this.Back_lbl.Location = new System.Drawing.Point(100, 536);
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
            this.Save_btn.Location = new System.Drawing.Point(537, 536);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(174, 55);
            this.Save_btn.TabIndex = 25;
            this.Save_btn.Text = "Add";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectId,
            this.titlDataGridViewTextBoxColumn,
            this.descreptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.projectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(228, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(432, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(MidProjectDb.UI.Project);
            // 
            // Projects_lbl
            // 
            this.Projects_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Projects_lbl.AutoSize = true;
            this.Projects_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects_lbl.Location = new System.Drawing.Point(161, 159);
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
            this.panel2.Size = new System.Drawing.Size(800, 142);
            this.panel2.TabIndex = 2;
            // 
            // ManageProjects_lbl
            // 
            this.ManageProjects_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManageProjects_lbl.AutoSize = true;
            this.ManageProjects_lbl.BackColor = System.Drawing.Color.MidnightBlue;
            this.ManageProjects_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageProjects_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.ManageProjects_lbl.Location = new System.Drawing.Point(216, 53);
            this.ManageProjects_lbl.Name = "ManageProjects_lbl";
            this.ManageProjects_lbl.Size = new System.Drawing.Size(331, 49);
            this.ManageProjects_lbl.TabIndex = 1;
            this.ManageProjects_lbl.Text = "Manage Projects";
            // 
            // projectId
            // 
            this.projectId.DataPropertyName = "projectId";
            this.projectId.HeaderText = "projectId";
            this.projectId.MinimumWidth = 6;
            this.projectId.Name = "projectId";
            this.projectId.Width = 125;
            // 
            // titlDataGridViewTextBoxColumn
            // 
            this.titlDataGridViewTextBoxColumn.DataPropertyName = "titl";
            this.titlDataGridViewTextBoxColumn.HeaderText = "title";
            this.titlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titlDataGridViewTextBoxColumn.Name = "titlDataGridViewTextBoxColumn";
            this.titlDataGridViewTextBoxColumn.Width = 125;
            // 
            // descreptionDataGridViewTextBoxColumn
            // 
            this.descreptionDataGridViewTextBoxColumn.DataPropertyName = "descreption";
            this.descreptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descreptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descreptionDataGridViewTextBoxColumn.Name = "descreptionDataGridViewTextBoxColumn";
            this.descreptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource projectBindingSource;
        private Guna.UI2.WinForms.Guna2Button Save_btn;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
        private System.Windows.Forms.Label Description_lbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox supervisionhour_txtbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn titlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descreptionDataGridViewTextBoxColumn;
    }
}