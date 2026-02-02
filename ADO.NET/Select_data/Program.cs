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
                   string selectquery="SELECT * FROM AnimeList";
                   
                   using(SqlCommand Command=new SqlCommand(selectquery,connection))
                    {
                        using(SqlDataReader reader=Command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                int id=reader.GetInt32(0);
                                string name=reader.GetString(1);
                                string genre=reader.GetString(2);
                                int year=reader.GetInt32(3);
                                Console.WriteLine($"ID: {id}, Name: {name}, Genre: {genre}, Year: {year}");
                            }
                        }
                        
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