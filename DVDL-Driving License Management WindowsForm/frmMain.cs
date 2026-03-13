using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL_Driving_License_Management_WindowsForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void sdPeople_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmPeople)
                {
                    form.Activate();
                    return;
                }
            }

            frmPeople frmPeople = new frmPeople();
            frmPeople.MdiParent = this;
            frmPeople.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
