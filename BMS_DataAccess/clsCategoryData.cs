using System;
using System.Data;
using System.Data.SqlClient;

namespace BMS_DataAccess
{
    public class clsCategoryData
    {
        // Get Category Info By ID
        public static bool GetCategoryInfoByID(int CategoryID, ref string CategoryName, ref bool IsActive, ref int CreatedByUserID)
        {
            bool IsFound = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Categories WHERE CategoryID = @CategoryID;";

                using(SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryID", CategoryID);

                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader =  command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFound = true;
                                CategoryName = (string)reader["CategoryName"];
                                IsActive = (bool)reader["IsActive"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
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

        // Get Category Info By Name
        public static bool GetCategoryInfoByName(string CategoryName, ref int CategoryID, ref bool IsActive, ref int CreatedByUserID)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Categories WHERE CategoryName = @CategoryName;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryName", CategoryName);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFound = true;
                                CategoryID = (int)reader["CategoryID"];
                                IsActive = (bool)reader["IsActive"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
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

        // Add
        public static int AddNewCategory(string CategoryName, bool IsActive, int CreatedByUserID)
        {
            int CategoryID = -1;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"INSERT INTO Categories(CategoryName, IsActive, CreatedByUserID)
                                 VALUES(@CategoryName, @IsActive, @CreatedByUserID);
                                 SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@CategoryName", CategoryName);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                            CategoryID = InsertedID;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }

            return CategoryID;
        }

        // Update
        public static bool UpdateCategory(int CategoryID, string CategoryName, bool IsActive)
        {
            int RowsAffected = 0;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"UPDATE Categories SET CategoryName = @CategoryName, IsActive = @IsActive
                                 WHERE CategoryID = @CategoryID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@CategoryID", CategoryID);
                    command.Parameters.AddWithValue("@CategoryName", CategoryName);
                    command.Parameters.AddWithValue("@IsActive", IsActive);

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

        // Delete
        public static bool DeleteCategory(int CategoryID)
        {
            int RowsAffected = 0;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "DELETE FROM Categories WHERE CategoryID = @CategoryID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@CategoryID", CategoryID);

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

        // IsExist
        public static bool IsExist(string CategoryName)
        {
            bool IsFind = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT Found = 1 FROM Categories WHERE CategoryName = @CategoryName;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@CategoryName", CategoryName);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int CategoryID))
                            IsFind = true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }

            return IsFind;
        }

        // Get All Categories
        public static DataTable GetAllCategories()
        {
            DataTable dtAllCategories = null;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT CategoryID, CategoryName, IsActive FROM Categories;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader =  command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dtAllCategories = new DataTable();
                                dtAllCategories.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }

            return dtAllCategories;
        }

        // Get All Categories Active
        public static DataTable GetAllCategoriesActive()
        {
            DataTable dtAllCategories = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT CategoryID, CategoryName, IsActive FROM Categories WHERE IsActive = 1;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtAllCategories = new DataTable();
                                dtAllCategories.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }

            return dtAllCategories;
        }
    }
}