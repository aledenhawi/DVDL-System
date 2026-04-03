using DVDL_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDL_Driving_License_Management_WindowsForm.Screens.Users.Controls
{
    public partial class ctrUserDetails : UserControl
    {
        private clsUser _User;
        private int _UserID;

        public int UserID { get { return _UserID; } }

        public ctrUserDetails()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID) 
        {
            _UserID = UserID;
            _User = clsUser.Find(UserID);

            if (_User == null)
            {

                MessageBox.Show("No user with UserID = " + UserID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FullUserInfo();

        }

        private void _FullUserInfo() 
        {

            ctrPersonDetails.LoadPersonInfo(_User.PersonID);

            lblIsActive.Text = (Convert.ToInt16(_User.IsActive) == 1) ? "Yes" : "No";

            lblUserID.Text = UserID.ToString();

            lblUsername.Text = _User.Username;

        }

        private void _ResetUserInfo() 
        {
            ctrPersonDetails.ResetPersonInfo();
            lblUserID.Text = "[???]";
            lblUsername.Text = "[???]";
            lblIsActive.Text = "[???]";

    }
    }
}
