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
                   // Delete row into table
                    ;
                        Console.WriteLine("Enter the ID to delete");
                        int Id=Convert.ToInt32(Console.ReadLine());
                        
                        



                   string updatetbl="DELETE FROM AnimeList WHERE AnimeId=@id";
                   using(SqlCommand command=new SqlCommand(updatetbl,connection))
                    {

                        command.Parameters.AddWithValue("@id",Id);
                        
                        command.ExecuteNonQuery();
                        Console.WriteLine("Row Deleted Successfully");
                        
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