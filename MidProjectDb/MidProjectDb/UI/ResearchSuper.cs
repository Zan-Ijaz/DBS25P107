using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProjectDb.UI
{
    public partial class ResearchSuper: Form
    {
        public ResearchSuper()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            WorkLoad work = new WorkLoad();
            work.Show();
            work.Size = this.Size;
            work.Location = this.Location;
            this.Close();
        }

        private void Assign_btn_Click(object sender, EventArgs e)
        {
            AssignProject assignProject = new AssignProject();
            assignProject.Show();
            assignProject.Size = this.Size;
            assignProject.Location = this.Location;
            this.Close();
        }
    }
}
