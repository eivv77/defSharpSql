using DesktopCore.Classes;
using Microsoft.Data.SqlClient;
using System;

namespace DesktopCore
{
    public class DBContext
    {
        private static string connectionString = @"Server = DESKTOP-CS0NR37\SQLEXPRESS; Database = WinLib; Encrypt = false; Trusted_Connection = True;";

        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;

        public static int Execute(string sql, out Message msg)
        {
            msg = new Message();
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(sql, sqlConnection);

            try
            {
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                msg.Code = -1;
                msg.Type = Enums.MessageType.Error;
                msg.Txt = e.Message;
                return -1;
            }
            finally 
            {
                sqlConnection.Close();
            }
        }
    }
}
