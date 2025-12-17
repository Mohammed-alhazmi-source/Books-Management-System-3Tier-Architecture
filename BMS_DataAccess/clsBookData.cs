using System;
using System.Data;
using System.Data.SqlClient;

namespace BMS_DataAccess
{
    public class clsBookData
    {
        // Get Book Info By ID
        public static bool GetBookInfoByID
            (
                int BookID, ref string Title, ref string ISBN, ref int CategoryID, ref string AdditionalDetials,
                ref DateTime PublisherDate, ref string ImagePath, ref int CreatedByUserID
            )
        {
            bool IsFind = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Books WHERE BookID = @BookID;";

                using(SqlCommand command =new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue(@"@BookID", BookID);

                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader =  command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                Title = (string)reader["Title"];
                                ISBN = (string)reader["ISBN"];
                                CategoryID = (int)reader["CategoryID"];

                                if (reader["AdditionalDetials"] == DBNull.Value)
                                    AdditionalDetials = "";
                                else
                                    AdditionalDetials = (string)reader["AdditionalDetials"];

                                PublisherDate = (DateTime)reader["PublisherDate"];

                                if (reader["ImagePath"] == DBNull.Value)
                                    ImagePath = "";
                                else
                                    ImagePath = (string)reader["ImagePath"];

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

            return IsFind;
        }

        // Get Book Info By Title
        public static bool GetBookInfoByTitle
           (
               string Title,ref int BookID, ref string ISBN, ref int CategoryID, ref string AdditionalDetials,
               ref DateTime PublisherDate, ref string ImagePath, ref int CreatedByUserID
           )
        {
            bool IsFind = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Books WHERE Title = @Title;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue(@"@Title", Title);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                BookID = (int)reader["BookID"];
                                ISBN = (string)reader["ISBN"];
                                CategoryID = (int)reader["CategoryID"];

                                if (reader["AdditionalDetials"] == DBNull.Value)
                                    AdditionalDetials = "";
                                else
                                    AdditionalDetials = (string)reader["AdditionalDetials"];

                                PublisherDate = (DateTime)reader["PublisherDate"];

                                if (reader["ImagePath"] == DBNull.Value)
                                    ImagePath = "";
                                else
                                    ImagePath = (string)reader["ImagePath"];

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

            return IsFind;
        }

        // Get Book Info By ISBN
        public static bool GetBookInfoByISBN
           (
               string ISBN, ref int BookID, ref string Title, ref int CategoryID, ref string AdditionalDetials,
               ref DateTime PublisherDate, ref string ImagePath, ref int CreatedByUserID
           )
        {
            bool IsFind = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Books WHERE ISBN = @ISBN;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue(@"@ISBN", ISBN);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                BookID = (int)reader["BookID"];
                                Title = (string)reader["Title"];
                                CategoryID = (int)reader["CategoryID"];

                                if (reader["AdditionalDetials"] == DBNull.Value)
                                    AdditionalDetials = "";
                                else
                                    AdditionalDetials = (string)reader["AdditionalDetials"];

                                PublisherDate = (DateTime)reader["PublisherDate"];

                                if (reader["ImagePath"] == DBNull.Value)
                                    ImagePath = "";
                                else
                                    ImagePath = (string)reader["ImagePath"];

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

            return IsFind;
        }

        // Add New Book
        public static int AddNewBook
            (
                string Title, string ISBN, int CategoryID, string AdditionalDetials, DateTime PublisherDate,
                string ImagePath, int CreatedByUserID
            )
        {
            int BookID = -1;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"
                                  INSERT INTO Books
                                             (Title, ISBN, CategoryID, AdditionalDetials,
                                              PublisherDate, ImagePath, CreatedByUserID)
                                       VALUES
                                             (@Title, @ISBN, @CategoryID, @AdditionalDetials,
                                              @PublisherDate, @ImagePath, @CreatedByUserID);
                                  SELECT SCOPE_IDENTITY();";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@Title", Title);
                    command.Parameters.AddWithValue("@ISBN", ISBN);
                    command.Parameters.AddWithValue("@CategoryID", CategoryID);
                    command.Parameters.AddWithValue("@PublisherDate", PublisherDate);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    if (string.IsNullOrEmpty(ImagePath))
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);

                    if (string.IsNullOrEmpty(AdditionalDetials))
                        command.Parameters.AddWithValue("@AdditionalDetials", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@AdditionalDetials", AdditionalDetials);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                            BookID = InsertedID;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }

            return BookID;
        }

        
        // Update Book
        public static bool UpdateBook
            (
                int BookID, string Title, int CategoryID, string AdditionalDetials, string ImagePath
            )
        {
            int RowsAffected = 0;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"
                                    UPDATE Books 
                                    SET Title = @Title,
                                    CategoryID = @CategoryID,
                                    AdditionalDetials = @AdditionalDetials ,
                                    ImagePath = @ImagePath
                                    WHERE BookID = @BookID;";

                using(SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@BookID", BookID);
                    command.Parameters.AddWithValue("@Title", Title);
                    command.Parameters.AddWithValue("@CategoryID", CategoryID);

                    if (string.IsNullOrEmpty(ImagePath))
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);

                    if (string.IsNullOrEmpty(AdditionalDetials))
                        command.Parameters.AddWithValue("@AdditionalDetials", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@AdditionalDetials", AdditionalDetials);

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


        // Delete Book
        public static bool DeleteBook(int BookID)
        {
            int RowsAffected = 0;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "DELETE FROM Books WHERE BookID = @BookID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@BookID", BookID);

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

        // Is ISBN TO Book Exist
        public static bool IsBookExistByISBN(string ISBN)
        {
            bool IsFind = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT Found = 1 FROM Books WHERE ISBN = @ISBN;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ISBN", ISBN);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int Value))
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

        // Is Title To Book Exist
        public static bool IsBookExistByTitle(string Title)
        {
            bool IsFind = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT Found = 1 FROM Books WHERE Title = @Title;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Title", Title);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int Value))
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

        // Get All Books
        public static DataTable GetAllBooks()
        {
            DataTable dtAllBooks = null;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Books_View;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader =  command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dtAllBooks = new DataTable();
                                dtAllBooks.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }


            }

            return dtAllBooks;
        }
    }
}