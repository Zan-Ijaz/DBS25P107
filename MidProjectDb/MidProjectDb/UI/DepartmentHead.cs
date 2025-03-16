using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Ocsp;
using MidProjectDb.BL;
namespace MidProjectDb.UI
{
    public partial class DepartmentHead: Form
    {
        public DepartmentHead()
        {
            InitializeComponent();
        }

        private void Assignworkload_btn_Click(object sender, EventArgs e)
        {
            WorkLoad work = new WorkLoad();
            work.Show();
            work.Size = this.Size;
            work.Location = this.Location;
            this.Close();
        }

        private void Approvereq_btn_Click(object sender, EventArgs e)
        {
            Fulfulreqs req = new Fulfulreqs();
            req.Show();
            req.Size = this.Size;
            req.Location = this.Location;
            this.Close();
        }

        private void Allocation_btn_Click(object sender, EventArgs e)
        {
            //ResourseAllocation resourseAllocation = new ResourseAllocation();
            //resourseAllocation.Show();
            //resourseAllocation.Size = this.Size;
            //resourseAllocation.Location = this.Location;
            //this.Close();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoggedInUser.ClearSession();
            SignIn signIn = new SignIn();
            signIn.Show();
            signIn.Size = this.Size;
            signIn.Location = this.Location;
            this.Close();
        }
    }
}
