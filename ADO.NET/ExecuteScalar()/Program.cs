using System;
using System.Data;
using System.Data.SqlClient;
namespace DatabaseConnection
{
    class Program
    {
        public static void Main(string [] args)
        {
            string conndb="server=DESKTOP-2V3O8L4\\SQLEXPRESS; Database=Netflix; Integrated Security=true;";
            using(SqlConnection connection=new SqlConnection(conndb))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection to database established successfully.");
                    
                    string SelectScalar="SELECT COUNT(*) FROM AnimeList";
                    using(SqlCommand command=new SqlCommand(SelectScalar,connection))
                    {
                        int count=(int)command.ExecuteScalar(); 
                        Console.WriteLine("Total number of records in AnimeList: " + count);
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