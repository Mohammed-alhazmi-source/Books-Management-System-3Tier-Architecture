using System;
using System.Data;
using System.Data.SqlClient;

namespace BMS_DataAccess
{
    public class clsCountryData
    {
        // جلب معلومات الدولة بحسب المعرف
        public static bool GetCountryInfoByID(int CountryID, ref string CountryName)
        {
            bool IsFound = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Countries WHERE CountryID = @CountryID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@CountryID", CountryID);

                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFound = true;
                                CountryName = (string)reader["CountryName"];
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }

            return IsFound;
        }

        // جلب معلومات الدولة بحسب اسمها
        public static bool GetCountryInfoByName(string CountryName, ref int CountryID)
        {
            bool IsFound = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Countries WHERE CountryName = @CountryName;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@CountryName", CountryName);

                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                IsFound = true;
                                CountryID = (int)reader["CountryID"];
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }

            return IsFound;
        }

        // دالة اضافة دولة
        public static int AddNewCountry(string CountryName)
        {
            int CountryID = -1;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"INSERT INTO Countries(CountryName) VALUES(@CountryName);
                                 SELECT SCOPE_IDENTITY();";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@CountryName", CountryName);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                            CountryID = InsertedID;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }

            return CountryID;
        }

        // دالة تعديل اسم دولة
        public static bool UpdateCountry(int CountryID, string CountryName)
        {
            int RowsAffected = 0;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "UPDATE Countries SET CountryName = @CountryName WHERE CountryID = @CountryID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@CountryID", CountryID);
                    command.Parameters.AddWithValue("@CountryName", CountryName);

                    try
                    {
                        connection.Open();

                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }

            return (RowsAffected > 0);
        }

        // حذف دولة 
        public static bool DeleteCountry(int CountryID)
        {
            int RowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "DELETE FROM Countries WHERE CountryID = @CountryID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@CountryID", CountryID);

                    try
                    {
                        connection.Open();

                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }                
            }

            return (RowsAffected > 0);
        }

        // التحقق هل الدولة المراد اضافتها او تعديلها موجودة بنفس الاسم من قبل
        public static bool IsCountryExist(string CountryName)
        {
            bool IsExist = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT Found = 1 FROM Countries WHERE CountryName = @CountryName;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@CountryName", CountryName);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int CountryID))
                            IsExist = true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }

            return IsExist;
        }
        
        // جلب جميع الدول
        public static DataTable GetAllCountries()
        {
            DataTable dtAllCountries = null;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Countries;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtAllCountries = new DataTable();
                                dtAllCountries.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }

            return dtAllCountries;
        }
    }
}