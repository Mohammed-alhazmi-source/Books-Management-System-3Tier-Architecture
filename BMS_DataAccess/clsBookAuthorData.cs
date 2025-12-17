using System;
using System.Data;
using System.Data.SqlClient;

namespace BMS_DataAccess
{
    public class clsBookAuthorData
    {
        // Get BookAuthor Info By ID
        public static bool GetBookAuthorInfoByID(int BookAuthorID, ref int AuthorID, ref int BookID, ref DateTime CreatedDate)
        {
            bool IsFind = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Books_Authors WHERE BAID = @BookAuthorID;";

                using (SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@BookAuthorID", BookAuthorID);

                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader =  command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                AuthorID = (int)reader["AuthorID"];
                                BookID = (int)reader["BookID"];
                                CreatedDate = (DateTime)reader["CreatedDate"];
                            }
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }

            return IsFind;
        }

        // Get Author Info By ID
        public static bool GetAuthorInfoByAuthorID(int AuthorID, ref int BookAuthorID, ref int BookID, ref DateTime CreatedDate)
        {
            bool IsFind = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT TOP 1 * FROM Books_Authors WHERE AuthorID = @AuthorID;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@AuthorID", AuthorID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                BookAuthorID = (int)reader["BAID"];
                                BookID = (int)reader["BookID"];
                                CreatedDate = (DateTime)reader["CreatedDate"];
                            }
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }

            return IsFind;
        }

        // Get Book Info By ID
        public static bool GetAuthorInfoByBookID(int BookID,ref int AuthorID, ref int BookAuthorID, ref DateTime CreatedDate)
        {
            bool IsFind = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT TOP 1 * FROM Books_Authors WHERE BookID = @BookID;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@BookID", BookID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                BookAuthorID = (int)reader["BAID"];
                                AuthorID = (int)reader["AuthorID"];
                                CreatedDate = (DateTime)reader["CreatedDate"];
                            }
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }

            return IsFind;
        }


        // Get Authors Book History
        public static DataTable GetAuthorsBookHistory(int BookID)
        {
            DataTable dtAuthorsBookHistory = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"
                                   SELECT 
                                   	A.PersonID,
                                   	A.AuthorID,
                                   	CONCAT(P.FirstName, ' ', P.SecondName, ' ', (ISNULL(P.ThirdName,'')),' ', P.LastName) AS AuthorName,
                                   	P.NationalNo,
                                   	CASE
                                   		WHEN P.Gender = 0 THEN 'Male'
                                   		WHEN P.Gender = 1 THEN 'Female'
                                   		ELSE 'Unknow'
                                   	END AS Gender,
                                   	C.CountryName AS Nationality,
                                   	P.DateOfBirth
                                   FROM Books_Authors BA
                                   JOIN Authors A
                                   ON BA.AuthorID = A.AuthorID
                                   JOIN People P
                                   ON A.PersonID = P.PersonID
                                   JOIN Countries C
                                   ON P.Nationality = C.CountryID
                                   WHERE BA.BookID = @BookID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@BookID", BookID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dtAuthorsBookHistory = new DataTable();
                                dtAuthorsBookHistory.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }

            return dtAuthorsBookHistory;
        }

        // Get Books Author History
        public static DataTable GetBooksAuthorHistory(int AuthorID)
        {
            DataTable dtBooksAuthorHistory = null;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"
                                  SELECT 
                                  	B.BookID, B.Title, B.ISBN, B.PublisherDate, C.CategoryName
                                  FROM Books_Authors BA
                                  JOIN Authors A
                                  ON BA.AuthorID = A.AuthorID
                                  JOIN Books B
                                  ON BA.BookID = B.BookID
                                  JOIN Categories C
                                  ON B.CategoryID = C.CategoryID	
                                  WHERE BA.AuthorID = @AuthorID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@AuthorID", AuthorID);

                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dtBooksAuthorHistory = new DataTable();
                                dtBooksAuthorHistory.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }

            return dtBooksAuthorHistory;
        }

        // Add
        public static int AddNewBookAndAuthor(int AuthorID, int BookID)
        {
            int BAID = -1;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"INSERT INTO Books_Authors(AuthorID, BookID) 
                                 VALUES(@AuthorID, @BookID);
                                 SELECT SCOPE_IDENTITY()";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@AuthorID", AuthorID);
                    command.Parameters.AddWithValue("@BookID", BookID);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                            BAID = InsertedID;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }

            return BAID;
        }
    
        // Update
        public static bool Update(int BAID, int AuthorID, int BookID, DateTime CreatedDate)
        {
            int RowsAffected = 0;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"
                                  UPDATE Books_Authors 
                                  SET AuthorID = @AuthorID, BookID = @BookID,
                                  CreatedDate = @CreatedDate
                                  WHERE BAID = @BAID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@BAID", BAID);
                    command.Parameters.AddWithValue("@AuthorID", AuthorID);
                    command.Parameters.AddWithValue("@BookID", BookID);
                    command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

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
        public static bool Delete(int BAID)
        {
            int RowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "DELETE FROM Books_Authors WHERE BAID = @BAID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@BAID", BAID);

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


        // Is Author And Book Exist
        public static bool IsAuthorAndBookExist(int AuthorID, int BookID)
        {
            bool IsFind = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT Found = 1 FROM Books_Authors WHERE AuthorID = @AuthorID AND BookID = @BookID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@AuthorID", AuthorID);
                    command.Parameters.AddWithValue("@BookID", BookID);

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

        // Is Author Exist
        public static bool IsAuthorExist(int AuthorID)
        {
            bool IsFind = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT Found = 1 FROM Books_Authors WHERE AuthorID = @AuthorID;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@AuthorID", AuthorID);

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

        // Get All Authors With Books
        public static DataTable GetAllAuthorsAndBooks()
        {
            DataTable dtAllAuthorsAndBooks = null;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Books_Authors;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader =  command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dtAllAuthorsAndBooks = new DataTable();
                                dtAllAuthorsAndBooks.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }

            return dtAllAuthorsAndBooks;
        }
    }
}