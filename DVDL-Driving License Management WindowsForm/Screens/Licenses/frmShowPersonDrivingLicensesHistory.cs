using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL_Driving_License_Management_WindowsForm.Screens.Licenses
{
    public partial class frmShowPersonDrivingLicensesHistory : Form
    {
        private int _PersonID = -1;
        public frmShowPersonDrivingLicensesHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        public frmShowPersonDrivingLicensesHistory()
        {
            InitializeComponent();
        }

        private void frmShowPersonDrivingLicensesHistory_Load(object sender, EventArgs e)
        {
            if(_PersonID != -1)
            {
                ctrPersonDetailsWithFilter1.LoadPersonInfo(_PersonID);
                ctrPersonDetailsWithFilter1.FilterEnabled = false;
            }
            else 
            {
                ctrPersonDetailsWithFilter1.FilterEnabled = true;
                ctrPersonDetailsWithFilter1.FilterFocus();
            }
        }

        private void ctrPersonDetailsWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = (int)obj;

            if(_PersonID == -1)
            {
                ctrDriverLicenses1.Clear();
            }
            else
                ctrDriverLicenses1.LoadInfoByPersonID(_PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
