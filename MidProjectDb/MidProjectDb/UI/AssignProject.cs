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
    public partial class AssignProject: Form
    {
        public AssignProject()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            ResearchSuper research = new ResearchSuper();
            research.Show();
            research.Size = this.Size;
            research.Location = this.Location;
            this.Close();
        }
    }
}
