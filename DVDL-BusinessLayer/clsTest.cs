using DVDL_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVDL_BusinessLayer
{
    public class clsTest
    {
        enum enMode { AddNew = 1, Update = 2 }

        private enMode _Mode;

        public int TestID { get; set; }

        public bool TestResult { get; set; }

        public int TestAppointmentID { get; set; }

        public string Notes { get; set; }

        public int CreatedByUserID { get; set; }

        public clsUser User
        {
            get
            {
                return clsUser.Find(this.CreatedByUserID);
            }
        }

        public clsTestAppointment TestAppointment
        {
            get
            {
                return clsTestAppointment.Find(this.TestAppointmentID);
            }
        }

        public clsTest()
        {
            _Mode = enMode.AddNew;
            TestID = -1;
            TestResult = false;
            TestAppointmentID = -1;
            CreatedByUserID = -1;
            Notes = default;
        }

        clsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            _Mode = enMode.Update;
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
        }

        bool _AddNewTest()
        {
            this.TestID = clsTestData.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

            return TestID != -1;
        }

        bool _UpdateTest()
        {
            return clsTestData.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }

        public static clsTest Find(int TestID)
        {
            int TestAppointmentID = -1;
            int CreatedByUserID = -1;
            bool TestResult = false;
            string Notes = default;

            if (clsTestData.GetTestInfoByID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
                return new clsTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            else
                return null;
        }

        public bool Save()
        {
            if (this._Mode == enMode.AddNew)
            {
                if (_AddNewTest())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                return false;
            }
            else
                return _UpdateTest();
        }

        public static bool Delete(int TestID)
        {
            return clsTestData.DeleteTest(TestID);
        }

        public static DataTable GetAllTests()
        {
            return clsTestData.GetAllTests();

        }

        public static bool IsTestExists(int TestID)
        {
            return clsTestData.IsTestExists(TestID);
        }
    }
}
