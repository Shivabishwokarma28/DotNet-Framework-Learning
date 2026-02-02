using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string [] args)
        {
            string conndb="server=DESKTOP-2V3O8L4\\SQLEXPRESS; Database=Netflix; Integrated Security=true;";
            using(SqlConnection connection=new SqlConnection(conndb))
            {
                try
                {
                   connection.Open();
                   Console.WriteLine("Connection Opened Successfully"); 
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }
    }
}