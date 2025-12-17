using System;

namespace BMS_DataAccess
{
    public static class clsDataAccessSettings
    {
        public static readonly string ConnectionString = $"Server = {Environment.MachineName}\\MSSQLSERVER2022; Database = BMS; User ID = sa; Password = 123456";
    }
}