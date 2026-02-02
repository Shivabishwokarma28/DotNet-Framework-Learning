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
                   //Table creation code
                   string tablecreatequery=@"
                   CREATE TABLE AnimeList(
                   AnimeId INT IDENTITY(1,1) PRIMARY KEY,
                   AnimeName NVARCHAR(100) NOT NULL,
                   Genre NVARCHAR(50) NOT NULL,
                   ReleaseYear INT NOT NULL
                   );
                   ";
                   using(SqlCommand Command=new SqlCommand(tablecreatequery,connection))
                    {
                        Command.ExecuteNonQuery(); //FOR EXECUTING QUERIES THAT DO NOT RETURN DATA
                        Console.WriteLine("Table Created Successfully");
                        
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }
    }
}