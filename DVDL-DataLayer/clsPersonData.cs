using DVDL_DataLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Security.Policy;

namespace DVDL_DataAccessLayer
{
    public class clsPersonData
    {

        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo, string Email,
            string Phone, string Address, DateTime DateOfBirth, string ImagePath, int NationalityCountryID, byte Gender)
        {
            int ContactID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"INSERT INTO People (NationalNo ,FirstName , SecondName , ThirdName , LastName , DateOfBirth , Gendor , Address , Phone, Email , NationalityCountryID , ImagePath)
                values(@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth,@Gender, @Address, @Phone, @Email ,@NationalityCountryID,@ImagePath)
                SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(Query, Connection);

            // add with value for insert

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            // Handle Image Path
            AddImage(ImagePath, command);

            if (ThirdName != "")
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            /////////
            ///

            try
            {
                Connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    ContactID = InsertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Connection.Close();
            }

            return ContactID;
        }

        public static bool FindPersonByID(int ID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref string NationalNo, ref string Email,
           ref string Phone, ref string Address, ref DateTime DateOfBirth, ref string ImagePath, ref int NationalityCountryID, ref byte Gender)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE PersonID = @ID";
            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    FirstName = Reader["FirstName"].ToString();
                    SecondName = Reader["SecondName"].ToString();
                    ThirdName = Reader["ThirdName"] != DBNull.Value ? Reader["ThirdName"].ToString() : "";
                    LastName = Reader["LastName"].ToString();
                    NationalNo = Reader["NationalNo"].ToString();
                    Email = Reader["Email"] != DBNull.Value ? Reader["Email"].ToString() : "";
                    Phone = Reader["Phone"].ToString();
                    Address = Reader["Address"].ToString();
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    ImagePath = Reader["ImagePath"] != DBNull.Value ? Reader["ImagePath"].ToString() : "";
                    NationalityCountryID = Convert.ToInt32(Reader["NationalityCountryID"]);
                    isFound = true;
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

        public static bool FindPersonByNationalNo(ref int ID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, string NationalNo, ref string Email,
        ref string Phone, ref string Address, ref DateTime DateOfBirth, ref string ImagePath, ref int NationalityCountryID, ref byte Gender)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM People WHERE NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    ID = Convert.ToInt32(Reader["PersonID"]);
                    FirstName = Reader["FirstName"].ToString();
                    SecondName = Reader["SecondName"].ToString();
                    ThirdName = Reader["ThirdName"] != DBNull.Value ? Reader["ThirdName"].ToString() : "";
                    LastName = Reader["LastName"].ToString();
                    Email = Reader["Email"] != DBNull.Value ? Reader["Email"].ToString() : "";
                    Phone = Reader["Phone"].ToString();
                    Address = Reader["Address"].ToString();
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    ImagePath = Reader["ImagePath"] != DBNull.Value ? Reader["ImagePath"].ToString() : "";
                    NationalityCountryID = Convert.ToInt32(Reader["NationalityCountryID"]);
                    isFound = true;
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

        public static bool UpdatePerson(int ID, string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo, string Email,
    string Phone, string Address, DateTime DateOfBirth, string ImagePath, int NationalityCountryID, byte Gender)
        {
            int RowsAffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Update People 
                             set NationalNo = @NationalNo,
                                 FirstName = @FirstName,
                                 SecondName = @SecondName,
                                 ThirdName = @ThirdName,
                                 LastName = @LastName,
                                 DateOfBirth = @DateOfBirth,
                                 Gendor = @Gender,
                                 Address = @Address,
                                 Phone = @Phone,
                                 Email = @Email,
                                 NationalityCountryID = @NationalityCountryID,
                                ImagePath = @ImagePath
                             Where PersonID = @ID;";


            SqlCommand command = new SqlCommand(Query, Connection);


            // add with value for update

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            // Handle optional fields
            if (ThirdName != "")
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);

            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
                    command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
    


              try
              {
                  Connection.Open();

                  RowsAffected = command.ExecuteNonQuery();
              }
              catch (Exception ex)
              {

              }
              finally
              {
                  Connection.Close();
              }

              return (RowsAffected > 0);
        }
        

        public static void AddImage(string ImagePath, SqlCommand command)
        {
            try
            {
                if (ImagePath != "")
                {


                    string Sourse = Convert.ToString(ImagePath);
                    string DestinationFolder = "C:\\DVLD-Images";
                    if (!Directory.Exists(DestinationFolder))
                    {
                        Directory.CreateDirectory(DestinationFolder);
                    }
                    string extension = Path.GetExtension(Sourse);
                    string DestinationPath = Path.Combine(DestinationFolder, $"{Guid.NewGuid()}{extension}");

                    File.Copy(Sourse, DestinationPath);

                    command.Parameters.AddWithValue("@ImagePath", DestinationPath);

                }
                else
                    command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex);
            }

        }

        public static bool GetImagePath(int ID, out string Path)
        {
            Path = "";
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Select ImagePath from People 
                             Where PersonID = @ID;";
            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    Path = result.ToString();
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Connection.Close();
            }

            return (Path != "");

        }

        public static bool RemoveImage(int ID)
        {
            int RowsAffected = 0;

            if (GetImagePath(ID, out string OldImagePath))
            {
                // Delete the old image file from the file system

                try
                {
                    File.Delete(OldImagePath);
                }
                catch (Exception ex)
                {
                    // Console.WriteLine(ex);
                }

                // Delete the image path from the database

                SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string Query = @"UPDATE People
                                     set ImagePath = NULL
                                     where PersonID = @ID;";


                SqlCommand command = new SqlCommand(Query, Connection);

                command.Parameters.AddWithValue("@ID", ID);

                try
                {
                    Connection.Open();

                    RowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Connection.Close();
                }

            }
            return (RowsAffected > 0);
        }

        public static void SetImage(int ID, string ImagePath)
        {
            RemoveImage(ID);

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = @"Update People 
                             set ImagePath = @ImagePath
                             Where PersonID = @ID;";
            SqlCommand command = new SqlCommand(Query, Connection);

            command.Parameters.AddWithValue("@ID", ID);

            // Change the image path and move the file to the new location
            AddImage(ImagePath, command);


            try
            {
                Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex);
            }
            finally
            {
                Connection.Close();
            }
        }

        public static bool DeletePerson(int ID)
        {
            int RowsAffected = 0;

            string Query = @"DELETE FROM People 
                     WHERE PersonID = @ID";

            GetImagePath(ID, out string ImagePath);

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(Query, connection))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                    connection.Open();

                    try
                    {
                    RowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {

                    }
                }
            }

            if (RowsAffected > 0 && !string.IsNullOrEmpty(ImagePath) && File.Exists(ImagePath))
            {
                File.Delete(ImagePath);
            }

            return (RowsAffected > 0);
        }

        public static DataTable GetAllCountries()
        {
            DataTable CountriesTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "SELECT * FROM Countries;";
            SqlDataReader Reader = null;
            SqlCommand command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    CountriesTable.Load(Reader);
                }

                Reader.Close();

            }
            catch (Exception ex)
            {
                //  Console.WriteLine(ex);
            }
            finally
            {
                Connection.Close();
            }
            return CountriesTable;
        }

        public static DataTable GetAllPeople()
        {
            DataTable PeopleTable = new DataTable();

            string Query = "SELECT * FROM PeopleListView;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        PeopleTable.Load(reader);
                    }
                }
                catch (Exception ex)
                {

                }
            }
            return PeopleTable;
        }

        public static bool IsNationalNumberExists(string NationalNo)
        {
            string Query = "SELECT COUNT(*) FROM People WHERE NationalNo = @NationalNo";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        // Console.WriteLine(ex);
                        return false;
                    }
                }
            }
        }

    }
}
