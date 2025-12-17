using System;
using System.Data;
using System.Data.SqlClient;

namespace BMS_DataAccess
{
    public class clsBorrowData
    {
        // Get Borrowing Info By ID
        public static bool GetBorrowInfoByID
            (
                int BorrowID, ref int BookCopyID, ref int PersonID, ref DateTime BorrowingDate,
                ref int CreatedByUserID, ref DateTime DueDate, ref DateTime ActualReturnDate,
                ref bool IsActive, ref int ReleasedByUserID
            )
        {
            bool IsFind = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Borrowing WHERE BorrowID = @BorrowID;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@BorrowID", BorrowID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                BookCopyID = (int)reader["BookCopyID"];
                                PersonID = (int)reader["PersonID"];
                                BorrowingDate = (DateTime)reader["BorrowingDate"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                DueDate = (DateTime)reader["DueDate"];

                                if (reader["ActualReturnDate"] == DBNull.Value)
                                    ActualReturnDate = DateTime.MinValue;
                                else
                                    ActualReturnDate = (DateTime)reader["ActualReturnDate"];

                                IsActive = (bool)reader["IsActive"];

                                if (reader["ReleasedByUserID"] == DBNull.Value)
                                    ReleasedByUserID = -1;
                                else
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
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


        // Get Borrow Info By BookID And CopyID
        public static bool GetBorrowInfoByBookIDAndCopyID
            (
                int BookID, int BookCopyID, ref int BorrowID, ref int PersonID, ref DateTime BorrowingDate,
                ref int CreatedByUserID, ref DateTime DueDate, ref DateTime ActualReturnDate,
                ref bool IsActive, ref int ReleasedByUserID
            )
        {
            bool IsFind = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string Query = @"
                                    SELECT 
                                    	    Bor.BorrowID,
                                            Bor.BookCopyID,
                                            Bor.PersonID,
                                            Bor.BorrowingDate,
                                            Bor.CreatedByUserID,
                                            Bor.DueDate,
                                            Bor.ActualReturnDate,
                                            Bor.IsActive,
                                            Bor.ReleasedByUserID                                    
                                    
                                    FROM Borrowing Bor
                                    JOIN BookCopies BC
                                    ON Bor.BookCopyID = BC.BookCopyID
                                    JOIN Books B
                                    ON B.BookID = BC.BookID
                                    JOIN People P
                                    ON Bor.PersonID = P.PersonID
                                    WHERE B.BookID = @BookID  AND Bor.BookCopyID = @BookCopyID;"; // AND Bor.IsActive = 0

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@BookID", BookID);
                    command.Parameters.AddWithValue("@BookCopyID", BookCopyID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                BorrowID = (int)reader["BorrowID"];
                                PersonID = (int)reader["PersonID"];
                                BorrowingDate = (DateTime)reader["BorrowingDate"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                DueDate = (DateTime)reader["DueDate"];

                                if (reader["ActualReturnDate"] == DBNull.Value)
                                    ActualReturnDate = new DateTime(1, 1, 1);
                                else
                                    ActualReturnDate = (DateTime)reader["ActualReturnDate"];

                                IsActive = (bool)reader["IsActive"];

                                if (reader["ReleasedByUserID"] == DBNull.Value)
                                    ReleasedByUserID = -1;
                                else
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
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

        // Get Borrow Info By BookTitle And CopyID
        public static bool GetBorrowInfoByTitleAndCopyID
            (
                string Title, int BookCopyID, ref int BorrowID, ref int PersonID, ref DateTime BorrowingDate,
                ref int CreatedByUserID, ref DateTime DueDate, ref DateTime ActualReturnDate,
                ref bool IsActive, ref int ReleasedByUserID
            )
        {
            bool IsFind = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string Query = @"
                                    SELECT 
                                            Bor.BorrowID,
                                            Bor.BookCopyID,
                                            Bor.PersonID,
                                            Bor.BorrowingDate,
                                            Bor.CreatedByUserID,
                                            Bor.DueDate,
                                            Bor.ActualReturnDate,
                                            Bor.IsActive,
                                            Bor.ReleasedByUserID
                                   
                                    FROM Borrowing Bor
                                    JOIN BookCopies BC
                                    ON Bor.BookCopyID = BC.BookCopyID
                                    JOIN Books B
                                    ON B.BookID = BC.BookID
                                    JOIN People P
                                    ON Bor.PersonID = P.PersonID
                                    WHERE B.Title = @Title AND Bor.BookCopyID = @BookCopyID;";//AND Bor.IsActive = 0

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Title", Title);
                    command.Parameters.AddWithValue("@BookCopyID", BookCopyID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                BorrowID = (int)reader["BorrowID"];
                                PersonID = (int)reader["PersonID"];
                                BorrowingDate = (DateTime)reader["BorrowingDate"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                DueDate = (DateTime)reader["DueDate"];

                                if (reader["ActualReturnDate"] == DBNull.Value)
                                    ActualReturnDate = new DateTime(1, 1, 1);
                                else
                                    ActualReturnDate = (DateTime)reader["ActualReturnDate"];

                                IsActive = (bool)reader["IsActive"];

                                if (reader["ReleasedByUserID"] == DBNull.Value)
                                    ReleasedByUserID = -1;
                                else
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
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


        // Get Borrow Info By BookISBN And CopyID
        public static bool GetBorrowInfoByISBNAndCopyID
            (
                string ISBN, int BookCopyID, ref int BorrowID, ref int PersonID, ref DateTime BorrowingDate,
                ref int CreatedByUserID, ref DateTime DueDate, ref DateTime ActualReturnDate,
                ref bool IsActive, ref int ReleasedByUserID
            )
        {
            bool IsFind = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                string Query = @"
                                    SELECT 
                                            Bor.BorrowID,
                                            Bor.BookCopyID,
                                            Bor.PersonID,
                                            Bor.BorrowingDate,
                                            Bor.CreatedByUserID,
                                            Bor.DueDate,
                                            Bor.ActualReturnDate,
                                            Bor.IsActive,
                                            Bor.ReleasedByUserID

                                    FROM Borrowing Bor
                                    JOIN BookCopies BC
                                    ON Bor.BookCopyID = BC.BookCopyID
                                    JOIN Books B
                                    ON B.BookID = BC.BookID
                                    JOIN People P
                                    ON Bor.PersonID = P.PersonID
                                    WHERE B.ISBN = @ISBN AND Bor.BookCopyID = @BookCopyID;";//AND Bor.IsActive = 0

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ISBN", ISBN);
                    command.Parameters.AddWithValue("@BookCopyID", BookCopyID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                BorrowID = (int)reader["BorrowID"];
                                PersonID = (int)reader["PersonID"];
                                BorrowingDate = (DateTime)reader["BorrowingDate"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                DueDate = (DateTime)reader["DueDate"];

                                if (reader["ActualReturnDate"] == DBNull.Value)
                                    ActualReturnDate = new DateTime(1, 1, 1);
                                else
                                    ActualReturnDate = (DateTime)reader["ActualReturnDate"];

                                IsActive = (bool)reader["IsActive"];

                                if (reader["ReleasedByUserID"] == DBNull.Value)
                                    ReleasedByUserID = -1;
                                else
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
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


        // Add
        public static int AddNewBorrow
            (
                int BookCopyID, int PersonID, DateTime BorrowingDate, int CreatedByUserID, DateTime DueDate
            )
        {
            int BorrowID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"
                                  UPDATE BookCopies SET IsActive = 0 WHERE BookCopyID = @BookCopyID;

                                  INSERT INTO Borrowing(BookCopyID, PersonID, BorrowingDate, CreatedByUserID, DueDate)
                                    VALUES(@BookCopyID, @PersonID, @BorrowingDate, @CreatedByUserID, @DueDate);
                                  SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@BookCopyID", BookCopyID);
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@DueDate", DueDate);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                            BorrowID = InsertedID;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }

            return BorrowID;
        }


        // Update
        public static bool UpdateBorrow(int BorrowID, int BookCopyID,DateTime ActualReturnDate, bool IsActive, int ReleasedByUserID)
        {
            int RowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"
                                    UPDATE BookCopies SET IsActive = 1 WHERE BookCopyID = @BookCopyID;

                                    UPDATE Borrowing 
                                    SET ActualReturnDate = @ActualReturnDate,
                                    IsActive = @IsActive,
                                    ReleasedByUserID = @ReleasedByUserID
                                    WHERE BorrowID = @BorrowID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                    command.Parameters.AddWithValue("@BorrowID", BorrowID);
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
    

        // Delete
        public static bool DeleteBorrow(int BorrowID)
        {
            int RowsAffected = 0;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "DELETE FROM Borrowing WHERE BorrowID = @BorrowID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@BorrowID", BorrowID);

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
    

        // Does Person Has Borrowed For BookCopy
        public static bool DoesPersonHasBorrowForBookCopy(int BookID, int PersonID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                //string Query = @"SELECT Found = 1 FROM Borrowing 
                //                 WHERE PersonID = @PersonID AND BookCopyID = @BookCopyID AND IsActive = 0;";

                string Query = @"
                                    SELECT TOP 1 Found = 1 
                                    FROM Borrowing Bor
                                    JOIN BookCopies BC
                                    ON Bor.BookCopyID = BC.BookCopyID
                                    JOIN People P
                                    ON Bor.PersonID = P.PersonID
                                    JOIN Books B
                                    ON B.BookID = BC.BookID
                                    WHERE B.BookID = @BookID AND P.PersonID = @PersonID AND Bor.IsActive = 0;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@BookID", BookID);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        return (Result != null);
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }


        // Get All Borrowing
        public static DataTable GetAllBorrowing()
        {
            DataTable dtAllBorrowing = null;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Borrowing_View ORDER BY IsActive ASC;";
                
                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader =  command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dtAllBorrowing = new DataTable();
                                dtAllBorrowing.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }

            return dtAllBorrowing;
        }
    
    }
}