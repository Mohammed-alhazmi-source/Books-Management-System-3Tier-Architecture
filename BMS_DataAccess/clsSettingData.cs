using System;
using System.Data.SqlClient;

namespace BMS_DataAccess
{
    public class clsSettingData
    {
        public static int GetDefaultDaysToBorrow()
        {
            int Days = 3;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT DefualtDaysToBorrow FROM Settings;";

                using(SqlCommand command = new SqlCommand(Query, connection)) 
                {
                    try
                    {
                        connection.Open();


                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int DaysCount))
                            Days = DaysCount;
                    }
                    catch (Exception)
                    {
                        return Days;
                    }
                }
            }

            return Days;
        }


        public static decimal GetDefaultPricePreDay()
        {
            decimal Price = 100;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string Query = "SELECT DefualtPriecPreDay FROM Settings;";

                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    try
                    {
                        connection.Open();


                        object Result = command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int Money))
                            Price = Money;
                    }
                    catch (Exception)
                    {
                        return Price;
                    }
                }
            }

            return Price;
        }
    }
}