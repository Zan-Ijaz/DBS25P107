namespace MidProjectDb.UI
{
    partial class FacultyRequest
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
            this.Save_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Date_lbl = new System.Windows.Forms.Label();
            this.Quantity_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemname_lbl = new System.Windows.Forms.Label();
            this.facultyrequest_lbl = new System.Windows.Forms.Label();
            this.Back_lbl = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Facultyreq_lbl = new System.Windows.Forms.Label();
            this.itemname_txtBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.itemname_txtBox);
            this.panel1.Controls.Add(this.Save_btn);
            this.panel1.Controls.Add(this.Date_lbl);
            this.panel1.Controls.Add(this.Quantity_txtbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.itemname_lbl);
            this.panel1.Controls.Add(this.facultyrequest_lbl);
            this.panel1.Controls.Add(this.Back_lbl);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 728);
            this.panel1.TabIndex = 0;
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
            this.Save_btn.Location = new System.Drawing.Point(789, 604);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(174, 55);
            this.Save_btn.TabIndex = 31;
            this.Save_btn.Text = "Add";
            // 
            // Date_lbl
            // 
            this.Date_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Date_lbl.AutoSize = true;
            this.Date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_lbl.Location = new System.Drawing.Point(144, 502);
            this.Date_lbl.Name = "Date_lbl";
            this.Date_lbl.Size = new System.Drawing.Size(169, 32);
            this.Date_lbl.TabIndex = 29;
            this.Date_lbl.Text = "Select Date:";
            // 
            // Quantity_txtbox
            // 
            this.Quantity_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Quantity_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_txtbox.Location = new System.Drawing.Point(663, 439);
            this.Quantity_txtbox.Name = "Quantity_txtbox";
            this.Quantity_txtbox.Size = new System.Drawing.Size(301, 27);
            this.Quantity_txtbox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Enter quantity:";
            // 
            // itemname_lbl
            // 
            this.itemname_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.itemname_lbl.AutoSize = true;
            this.itemname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemname_lbl.Location = new System.Drawing.Point(144, 379);
            this.itemname_lbl.Name = "itemname_lbl";
            this.itemname_lbl.Size = new System.Drawing.Size(229, 32);
            this.itemname_lbl.TabIndex = 25;
            this.itemname_lbl.Text = "Enter item name:";
            // 
            // facultyrequest_lbl
            // 
            this.facultyrequest_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.facultyrequest_lbl.AutoSize = true;
            this.facultyrequest_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyrequest_lbl.Location = new System.Drawing.Point(144, 142);
            this.facultyrequest_lbl.Name = "facultyrequest_lbl";
            this.facultyrequest_lbl.Size = new System.Drawing.Size(241, 32);
            this.facultyrequest_lbl.TabIndex = 21;
            this.facultyrequest_lbl.Text = "Faculty Requests:";
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
            this.Back_lbl.Location = new System.Drawing.Point(167, 604);
            this.Back_lbl.Name = "Back_lbl";
            this.Back_lbl.Size = new System.Drawing.Size(174, 55);
            this.Back_lbl.TabIndex = 20;
            this.Back_lbl.Text = "Back";
            this.Back_lbl.Click += new System.EventHandler(this.Back_lbl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(150, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(813, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Facultyreq_lbl);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 125);
            this.panel2.TabIndex = 5;
            // 
            // Facultyreq_lbl
            // 
            this.Facultyreq_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Facultyreq_lbl.AutoSize = true;
            this.Facultyreq_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Facultyreq_lbl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facultyreq_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Facultyreq_lbl.Location = new System.Drawing.Point(345, 43);
            this.Facultyreq_lbl.Name = "Facultyreq_lbl";
            this.Facultyreq_lbl.Size = new System.Drawing.Size(331, 49);
            this.Facultyreq_lbl.TabIndex = 0;
            this.Facultyreq_lbl.Text = "Make a  Request";
            // 
            // itemname_txtBox
            // 
            this.itemname_txtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.itemname_txtBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemname_txtBox.FormattingEnabled = true;
            this.itemname_txtBox.Location = new System.Drawing.Point(663, 379);
            this.itemname_txtBox.Name = "itemname_txtBox";
            this.itemname_txtBox.Size = new System.Drawing.Size(301, 24);
            this.itemname_txtBox.TabIndex = 32;
            // 
            // FacultyRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1090, 728);
            this.Controls.Add(this.panel1);
            this.Name = "FacultyRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacultyRequest";
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
        private System.Windows.Forms.Label Facultyreq_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultymemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button Back_lbl;
        private System.Windows.Forms.Label facultyrequest_lbl;
        private System.Windows.Forms.Label itemname_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Date_lbl;
        private System.Windows.Forms.TextBox Quantity_txtbox;
        private Guna.UI2.WinForms.Guna2Button Save_btn;
        private System.Windows.Forms.ComboBox itemname_txtBox;
    }
}