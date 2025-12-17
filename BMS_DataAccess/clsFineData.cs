using System;
using System.Data;
using System.Data.SqlClient;

namespace BMS_DataAccess
{
    public class clsFineData
    {
        // Get Fine Info By ID
        public static bool GetFineInfoByID
            (
                int FineID, ref int PersonID, ref int BorrowID, ref decimal FineAmount, ref int CreatedByUserID
            )
        {
            bool IsFind = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Fines WHERE FineID = @FineID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@FineID", FineID);

                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader =  command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                PersonID = (int)reader["PersonID"];
                                BorrowID = (int)reader["BorrowID"];
                                FineAmount = (decimal)reader["FineAmount"];
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


        // Get Fine Info By PersonID And BorrowID
        public static bool GetFineInfoByPersonIDAndBorrowID
            (
                int PersonID,int BorrowID, ref int FineID, ref decimal FineAmount, ref int CreatedByUserID
            )
        {
            bool IsFind = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Fines WHERE PersonID = @PersonID AND BorrowID = @BorrowID;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@BorrowID", BorrowID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IsFind = true;
                                FineID = (int)reader["FineID"];
                                FineAmount = (decimal)reader["FineAmount"];
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


        // Add New Fine
        public static int AddNewFine(int PersonID, int BorrowID, decimal FineAmount, int CreatedByUserID)
        {
            int FineID = -1;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"INSERT INTO Fines(PersonID, BorrowID, FineAmount, CreatedByUserID)
                                 VALUES(@PersonID, @BorrowID, @FineAmount, @CreatedByUserID);
                                 SELECT SCOPE_IDENTITY();";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@BorrowID", BorrowID);
                    command.Parameters.AddWithValue("@FineAmount", FineAmount);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        connection.Open();

                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                            FineID = InsertedID;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                }
            }

            return FineID;
        }


        // Update Fine Never Used
        public static bool UpdateFine(int FineID, int PersonID, int BorrowID, decimal FineAmount, int CreatedByUserID)
        {
            int RowsAffected = 0;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = @"UPDATE Fines 
                                SET PersonID = @PersonID, 
                                    BorrowID = @BorrowID, 
                                    FineAmount = @FineAmount, 
                                    CreatedByUserID = @CreatedByUserID WHERE FineID = @FineID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@FineID", FineID);
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@BorrowID", BorrowID);
                    command.Parameters.AddWithValue("@FineAmount", FineAmount);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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


        // Delete Fine
        public static bool DeleteFine(int FineID)
        {
            int RowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "DELETE FROM Fines WHERE FineID = @FineID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@FineID", FineID);

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


        // Get All Fines
        public static DataTable GetAllFines()
        {
            DataTable dtAllFines = null;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT * FROM Fines_View;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    try
                    {
                        connection.Open();

                        using(SqlDataReader reader =  command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dtAllFines = new DataTable();
                                dtAllFines.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }

            return dtAllFines;
        }

        // Is Person Fine Fees To Borrow
        public static bool IsPersonFineFeesToBorrow(int PersonID, int BorrowID)
        {
            bool IsFind = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT Found = 1 FROM Fines WHERE PersonID = @PersonID and BorrowID = @BorrowID;";

                using(SqlCommand command = new SqlCommand(Query,connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@BorrowID", BorrowID);

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
    }
}