using DVDL_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVDL_BusinessLayer.clsLicense;

namespace DVDL_BusinessLayer
{
    public class clsInternationalLicense : clsApplication
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode;

        public int InternationalLicenseID { get; set; }

        public int DriverID { get; set; }

        public clsDriver DriverInfo { get => clsDriver.Find(DriverID); }

        public int IssuedUsingLocalLicenseID { get; set; }

        public clsLicense LocalLicenseInfo { get => clsLicense.Find(IssuedUsingLocalLicenseID); }

        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }

        public clsInternationalLicense() : base()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = false;
            _Mode = enMode.AddNew;
        }

        clsInternationalLicense(int applicationID, int applicantPersonID, DateTime applicationDate, int applicationTypeID, int createdByUserID, DateTime lastStatusDate,
            enApplicationStatus applicationStatus, float paidFees, int internationalLicenseID, int driverID,
            int issuedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive): base(applicationID, applicantPersonID, applicationDate, applicationTypeID, createdByUserID, lastStatusDate, applicationStatus, paidFees)
        {
            InternationalLicenseID = internationalLicenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            _Mode = enMode.Update;

        }

        private bool _AddNewInternationalLicenseApplication()
        {
            this.InternationalLicenseID = clsInternationalLicenseData.AddNewInternationalLicensesApplication(this.ApplicationID, this.DriverID,
                this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return this.InternationalLicenseID != 1;

        }

        private bool _UpdateInternationalLicenseApplication()
        {
            return clsInternationalLicenseData.UpdateInternationalLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID,
                this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
        }

        public new bool Save()
        {
            if (!base.Save())
                return false;

            if (_Mode == enMode.AddNew)
            {
                if (_AddNewInternationalLicenseApplication())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                return false;
            }
            else
            {
                return _UpdateInternationalLicenseApplication();
            }
        } 

        public static DataTable GetAllInternationalLicenses() 
        {
            return clsInternationalLicenseData.GetAllInternationalLicenses();
        }

        public static DataTable GetDriverInternationalLicense(int driverID)
        {
            return clsInternationalLicenseData.GetAllDriverInternationalLicenses(driverID);
        }

        public static int GetDriverActiveInternationalLicenseID(int driverID)
        {
            return clsInternationalLicenseData.GetActiveInternationalLicenseIDForDriverID(driverID);
        }

        public static clsInternationalLicense Find(int InternationalLicenseID) 
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            int CreatedByUserID = -1;
            bool IsActive = false;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;

            bool IsFound = clsInternationalLicenseData.GetInternationalLicenseInfoByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID,
                ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID);


            if (IsFound)
            {
                clsApplication Application = clsApplication.FindBaseApplication(ApplicationID);

                return new clsInternationalLicense(ApplicationID,Application.ApplicantPersonID,Application.ApplicationDate,Application.ApplicationTypeID
                    ,Application.CreatedByUserID,Application.LastStatusDate,Application.ApplicationStatus,Application.PaidFees,InternationalLicenseID,
                    DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive);
            }
            else
                return null;
        }

    }
}
