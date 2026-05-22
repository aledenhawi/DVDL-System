using DVDL_BusinessLayer;
using DVDL_Driving_License_Management_WindowsForm.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL_Driving_License_Management_WindowsForm.Screens.Licenses.Local_Licenses.Controls
{
    public partial class ctrLicenseInfoWithFilter : UserControl
    {
        public ctrLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        public event Action<int> OnLicenseSelected;

        protected virtual void LicenseSelected(int LicenseID) 
        {
            Action<int> Handler = OnLicenseSelected;
           
            if (Handler != null)
                Handler(LicenseID);
        }

        bool _FilterEnable = true;

        public bool FilterEnable 
        {
            get => _FilterEnable; 
            set 
            { 
                _FilterEnable = value;
                gbFilter.Enabled = value; 
            } 
        }
        private int _LicenseID = -1;

         public int LicenseID { get => ctrLicenseInfo1.LicenseID; }
         public clsLicense SelectedLicenseInfo { get => ctrLicenseInfo1.SelectedLicenseInfo; }

        public void TxbLicenseIDFocus()
        {
            txbLicenseID.Focus();
        }

        private void btnFindLicense_Click(object sender, EventArgs e)
        {
            if(txbLicenseID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a License ID to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbLicenseID.Focus();
                return;
            }

            _LicenseID = int.Parse(txbLicenseID.Text);
            LoadLicenseInfo(_LicenseID);
        }

        private void txbLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter) 
            {
                btnFindLicense.PerformClick();
                return;
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            _LicenseID = LicenseID;
            txbLicenseID.Text = LicenseID.ToString();
            ctrLicenseInfo1.LoadInfo(LicenseID);
            if (OnLicenseSelected != null && FilterEnable)
                // Raise the event with a parameter
                OnLicenseSelected(ctrLicenseInfo1.LicenseID);
        }
    }
}
