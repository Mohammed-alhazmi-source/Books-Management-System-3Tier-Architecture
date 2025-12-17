using System;
using System.Data;
using System.Data.SqlClient;

namespace BMS_DataAccess
{
    public class clsBookCopyData
    {
        // Get BookCopy Info By ID
        public static bool GetBookCopyInfoByID(int BookCopyID, ref string BookCopyName, ref int BookID, ref bool IsActive)
        {
            bool IsFind = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM BookCopies WHERE BookCopyID = @BookCopyID;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@BookCopyID", BookCopyID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                BookID = (int)reader["BookID"];
                                BookCopyName = (string)reader["BookCopyName"];
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

            return IsFind;
        }

        // Get BookCopies Info By BookID
        public static DataTable GetBookCopiesInfoByBookID(int BookID)
        {
            DataTable dtBookCopies = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM BookCopies WHERE BookID = @BookID;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@BookID", BookID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtBookCopies = new DataTable();
                                dtBookCopies.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }

            return dtBookCopies;
        }


        // Add
        public static int AddBookCopy(int BookID, string BookCopyName, bool IsActive)
        {
            int BookCopyID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"INSERT INTO BookCopies(BookID, BookCopyName, IsActive)
                                 VALUES(@BookID, @BookCopyName, @IsActive);
                                 SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@BookID", BookID);
                    command.Parameters.AddWithValue("@BookCopyName", BookCopyName);
                    command.Parameters.AddWithValue("@IsActive", IsActive);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                            BookCopyID = InsertedID;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }

            return BookCopyID;
        }

        // Update
        public static bool UpdateBookCopy(int BookCopyID, int BookID, string BookCopyName, bool IsActive)
        {
            int RowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"UPDATE BookCopies 
                                 SET BookID = @BookID, BookCopyName = @BookCopyName, IsActive = @IsActive
                                 WHERE BookCopyID = @BookCopyID;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@BookCopyID", BookCopyID);
                    command.Parameters.AddWithValue("@BookID", BookID);
                    command.Parameters.AddWithValue("@BookCopyName", BookCopyName);
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
        public static bool DeleteBookCopy(int BookCopyID)
        {
            int RowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "DELETE FROM BookCopies WHERE BookCopyID = BookCopyID;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@BookCopyID", BookCopyID);

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

        // Update Stats Book Copy
        public static bool UpdateBookCopyStatus(int BookCopyID, bool IsActive)
        {
            int RowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"UPDATE BookCopies 
                                 SET IsActive = @IsActive
                                 WHERE BookCopyID = @BookCopyID;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@BookCopyID", BookCopyID);
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

        // Get All Book Copies
        public static DataTable GetAllBookCopies()
        {
            DataTable dtAllBookCopies = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM BookCopies;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtAllBookCopies = new DataTable();
                                dtAllBookCopies.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }

            return dtAllBookCopies;
        }

        // Get Book Copies Count For Book
        public static int GetBookCopiesCount(int BookID)
        {
            int Count = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"
                                  SELECT 
                                  	COUNT(BC.BookID) AS BookCopiesCount
                                  FROM Books B
                                  JOIN BookCopies BC
                                  ON B.BookID = BC.BookID
                                  WHERE B.BookID = @BookID;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@BookID", BookID);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int BookCopiesCount))
                            Count = BookCopiesCount;
                    }
                    catch (Exception)
                    {
                        return 0;
                    }
                }
            }

            return Count;
        }


        // Get Book Copies History
        public static DataTable GetBookCopiesHistory(int BookID)
        {
            DataTable dtBookCopiesHistory = null;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"
                                   SELECT 
                                   BC.BookCopyID, B.BookID, B.Title AS BookName, BC.BookCopyName, 
                                   C.CategoryName, BC.IsActive
                                   FROM BookCopies BC
                                   JOIN Books B
                                   ON BC.BookID = B.BookID
                                   JOIN Categories	C
                                   ON B.CategoryID = C.CategoryID
                                   WHERE B.BookID = @BookID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@BookID", BookID);

                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader =  command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dtBookCopiesHistory = new DataTable();
                                dtBookCopiesHistory.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }

            return dtBookCopiesHistory;
        }
    }
}