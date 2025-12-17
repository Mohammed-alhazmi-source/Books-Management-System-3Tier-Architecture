using System;
using System.Data;
using System.Data.SqlClient;

namespace BMS_DataAccess
{
    public class clsUserData
    {
        // جلب معلومات المستخدم حسب المعرف
        public static bool GetUserInfoByID(int UserID, ref string UserName, ref string Password, ref bool IsActive, ref int PersonID)
        {
            bool IsFind = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Users WHERE UserID = @UserID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader =  command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                UserName = (string)reader["UserName"];
                                Password = (string)reader["Password"];
                                IsActive = (bool)reader["IsActive"];
                                PersonID = (int)reader["PersonID"];
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }

            return IsFind;
        }

        // جلب معلومات المستخدم حسب معرف الشخص المرتبط بسجل في جدول المستخدمين
        public static bool GetUserInfoByPersonID(int PersonID, ref string UserName, ref string Password, ref bool IsActive, ref int UserID)
        {
            bool IsFind = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Users WHERE PersonID = @PersonID;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                UserName = (string)reader["UserName"];
                                Password = (string)reader["Password"];
                                IsActive = (bool)reader["IsActive"];
                                UserID = (int)reader["UserID"];
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }

            return IsFind;
        }

        // اضافة
        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            int UserID = -1;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"
                                  INSERT INTO Users(UserName,Password,IsActive,PersonID)
                                  VALUES(@UserName,@Password, @IsActive, @PersonID);
                                  SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                            UserID = InsertedID;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }

            return UserID;
        }

        // تعديل
        public static bool UpdateUser(int UserID, string UserName, string Password, bool IsActive, int PersonID)
        {
            int RowsAffected = 0;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"UPDATE Users 
                                 SET UserName = @UserName, Password = @Password, IsActive = @IsActive, 
                                     PersonID = @PersonID  WHERE UserID = @UserID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@PersonID", PersonID);

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

        // حذف
        public static bool DeleteUser(int UserID)
        {
            int RowsAffected = 0;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "DELETE FROM Users WHERE UserID = @UserID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

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

        // الشخص هو مستخدم من قبل ام لا
        public static bool IsExist(int PersonID)
        {
            bool IsFound = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT Found = 1 FROM Users WHERE PersonID = @PersonID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int UserID))
                            IsFound = true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }

            return IsFound;
        }

        // اسم المستخدم يوجد من قبل ام لا
        public static bool IsExist(string UserName)
        {
            bool IsFound = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT Found = 1 FROM Users WHERE UserName = @UserName;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@UserName", UserName);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int UserID))
                            IsFound = true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }

            return IsFound;
        }

        public static bool IsExist(string UserName, string Password, ref int UserID, ref int PersonID, ref bool IsActive)
        {
            bool IsFound = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);

                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader =  command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                IsFound = true;
                                UserID = (int)reader["UserID"];
                                PersonID = (int)reader["PersonID"];
                                IsActive = (bool)reader["IsActive"];
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

        // جلب جميع المستخدمين
        public static DataTable GetAllUsers()
        {
            DataTable dtAllUsers = null;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Users_View;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dtAllUsers = new DataTable();
                                dtAllUsers.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }

            return dtAllUsers;
        }
    }
}