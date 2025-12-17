using System;
using System.Data;
using System.Data.SqlClient;

namespace BMS_DataAccess
{
    public class clsReserveData
    {
        // Get Reserve Info By ID
        public static bool GetReserveInfoByID
            (
                int ReserveID, ref int PersonID, ref int BookCopyID, ref DateTime ReserveDate,
                ref int CreatedByUserID, ref bool ReserveStatus, ref DateTime ReleaseReserveDate,
                ref int ReleasedByUserID
            )
        {
            bool IsFind = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"SELECT * FROM Reservations WHERE ReservationID = @ReservationID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@ReservationID", ReserveID);

                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader =  command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                PersonID = (int)reader["PersonID"];
                                BookCopyID = (int)reader["BookCopyID"];
                                ReserveDate = (DateTime)reader["ReservationDate"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                ReserveStatus = (bool)reader["ReservationStatus"];

                                if (reader["ReleaseReservationDate"] == DBNull.Value)
                                    ReleaseReserveDate = new DateTime(1, 1, 1);
                                else
                                    ReleaseReserveDate = (DateTime)reader["ReleaseReservationDate"];

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


        // Add Reserve
        public static int AddNewReserve
            (
                int PersonID, int BookCopyID, DateTime ReserveDate, int CreatedByUserID, bool ReserveStatus
            )
        {
            int ReserveID = -1;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"
                                    INSERT INTO Reservations
                                                 (PersonID, BookCopyID, ReservationDate, CreatedByUserID, 
                                                  ReservationStatus)
                                    VALUES        (@PersonID,@BookCopyID,@ReservationDate,@CreatedByUserID,
                                                   @ReservationStatus);
                                    SELECT SCOPE_IDENTITY();";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@BookCopyID", BookCopyID);
                    command.Parameters.AddWithValue("@ReservationDate", ReserveDate);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@ReservationStatus", ReserveStatus);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                            ReserveID = InsertedID;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }

            return ReserveID;
        }

        
        // Update Reserve
        public static bool UpdateReserve(int ReserveID, DateTime ReleaseReserveDate, int ReleasedByUserID)
        {
            int RowsAffected = 0;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"UPDATE Reservations 
                                 SET ReleaseReservationDate = @ReleaseReserveDate,
                                     ReleasedByUserID = @ReleasedByUserID,
                                     ReservationStatus = 1
                                 WHERE ReservationID = @ReserveID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@ReserveID", ReserveID);
                    command.Parameters.AddWithValue("@ReleaseReserveDate", ReleaseReserveDate);
                    command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);

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


        // Delete Reserve
        public static bool DeleteReserve(int ReserveID)
        {
            int RowsAffected = 0;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "DELETE FROM Reservations WHERE ReservationID = @ReserveID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@ReserveID", ReserveID);

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


        // Is Book Copy Reserved
        public static bool IsBookCopyReserved(int PersonID, int BookID)
        {
            bool IsReserved = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                //string Query = @"
                //                  SELECT Found = 1 
                //                  FROM Reservations 
                //                  WHERE PersonID = @PersonID AND BookCopyID = @BookCopyID AND ReservationStatus = 0;";


                string Query = @"
                                    SELECT TOP 1 Found = 1 
                                    FROM Reservations R
                                    JOIN BookCopies BC
                                    ON R.BookCopyID = BC.BookCopyID
                                    JOIN People P
                                    ON R.PersonID = P.PersonID
                                    JOIN Books B
                                    ON B.BookID = BC.BookID
                                    WHERE B.BookID = @BookID AND P.PersonID = @PersonID AND R.ReservationStatus = 0;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@BookID", BookID);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int ReserveID))
                            IsReserved = true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }

            return IsReserved;
        }


        // Get Reserve Info By ISBN And Book Copy ID
        public static bool GetReserveInfoByISBNAndBookCopyID
            (
                string ISBN, int BookCopyID, int PersonID, ref int ReserveID, ref DateTime ReserveDate,
                ref int CreatedByUserID, ref bool ReserveStatus, ref DateTime ReleaseReserveDate,
                ref int ReleasedByUserID
            )
        {
            bool IsFind = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                //                                    		R.PersonID,
                //R.BookCopyID,
                string Query = @"
                                    SELECT TOP 1
                                            R.ReservationID,
                                            R.ReservationDate,
                                            R.CreatedByUserID,
                                    		R.ReservationStatus,
                                    		R.ReleaseReservationDate,
                                    		R.ReleasedByUserID
                                    FROM Reservations R
                                    JOIN BookCopies BC
                                    ON R.BookCopyID = BC.BookCopyID
                                    JOIN Books B
                                    ON B.BookID = BC.BookID
                                    JOIN People P
                                    ON R.PersonID = P.PersonID
                                    WHERE B.ISBN = @ISBN AND R.BookCopyID = @BookCopyID AND
                                          R.ReservationStatus = 0 AND R.PersonID = @PersonID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@ISBN", ISBN);
                    command.Parameters.AddWithValue("@BookCopyID", BookCopyID);
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                ReserveID = (int)reader["ReservationID"];
                                //PersonID = (int)reader["PersonID"];
                                //BookCopyID = (int)reader["BookCopyID"];
                                ReserveDate = (DateTime)reader["ReservationDate"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                ReserveStatus = (bool)reader["ReservationStatus"];

                                if (reader["ReleaseReservationDate"] == DBNull.Value)
                                    ReleaseReserveDate = new DateTime(1, 1, 1);
                                else
                                    ReleaseReserveDate = (DateTime)reader["ReleaseReservationDate"];

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


        // Get Reserve Info By Title And Book Copy ID
        public static bool GetReserveInfoByTitleAndBookCopyID
            (
                string Title, int BookCopyID, int PersonID, ref int ReserveID, ref DateTime ReserveDate,
                ref int CreatedByUserID, ref bool ReserveStatus, ref DateTime ReleaseReserveDate,
                ref int ReleasedByUserID
            )
        {
            bool IsFind = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                //                                    		R.PersonID,
                //R.BookCopyID,
                string Query = @"
                                    SELECT TOP 1
                                            R.ReservationID,
                                            R.ReservationDate,
                                            R.CreatedByUserID,
                                    		R.ReservationStatus,
                                    		R.ReleaseReservationDate,
                                    		R.ReleasedByUserID
                                    FROM Reservations R
                                    JOIN BookCopies BC
                                    ON R.BookCopyID = BC.BookCopyID
                                    JOIN Books B
                                    ON B.BookID = BC.BookID
                                    JOIN People P
                                    ON R.PersonID = P.PersonID
                                    WHERE B.Title = @Title AND R.BookCopyID = @BookCopyID AND
                                          R.ReservationStatus = 0 AND R.PersonID = @PersonID;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Title", Title);
                    command.Parameters.AddWithValue("@BookCopyID", BookCopyID);
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                ReserveID = (int)reader["ReservationID"];
                                ReserveDate = (DateTime)reader["ReservationDate"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                ReserveStatus = (bool)reader["ReservationStatus"];

                                if (reader["ReleaseReservationDate"] == DBNull.Value)
                                    ReleaseReserveDate = new DateTime(1, 1, 1);
                                else
                                    ReleaseReserveDate = (DateTime)reader["ReleaseReservationDate"];

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

        // Get Reserve Info By Title And Book Copy ID
        public static bool GetReserveInfoByBookIDAndBookCopyID
            (
                int BookID, int BookCopyID, int PersonID, ref int ReserveID, ref DateTime ReserveDate,
                ref int CreatedByUserID, ref bool ReserveStatus, ref DateTime ReleaseReserveDate,
                ref int ReleasedByUserID
            )
        {
            bool IsFind = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                //                                    		R.PersonID,
                //R.BookCopyID,
                string Query = @"
                                    SELECT TOP 1
                                            R.ReservationID,
                                            R.ReservationDate,
                                            R.CreatedByUserID,
                                    		R.ReservationStatus,
                                    		R.ReleaseReservationDate,
                                    		R.ReleasedByUserID
                                    FROM Reservations R
                                    JOIN BookCopies BC
                                    ON R.BookCopyID = BC.BookCopyID
                                    JOIN Books B
                                    ON B.BookID = BC.BookID
                                    JOIN People P
                                    ON R.PersonID = P.PersonID
                                    WHERE B.BookID = @BookID AND R.BookCopyID = @BookCopyID AND
                                          R.ReservationStatus = 0 AND R.PersonID = @PersonID;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@BookID", BookID);
                    command.Parameters.AddWithValue("@BookCopyID", BookCopyID);
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                ReserveID = (int)reader["ReservationID"];
                                ReserveDate = (DateTime)reader["ReservationDate"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                ReserveStatus = (bool)reader["ReservationStatus"];

                                if (reader["ReleaseReservationDate"] == DBNull.Value)
                                    ReleaseReserveDate = new DateTime(1, 1, 1);
                                else
                                    ReleaseReserveDate = (DateTime)reader["ReleaseReservationDate"];

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

        // Get All Reservations
        public static DataTable GetAllReservations()
        {
            DataTable dtAllReservations = null;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Reservations_View ORDER BY ReservationDate, ReservationStatus;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader =  command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dtAllReservations = new DataTable();
                                dtAllReservations.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }

            return dtAllReservations;
        }
    }
}