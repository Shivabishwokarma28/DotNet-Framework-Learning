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
                   // insert data into table
                    Console.WriteLine("Insert Anime name,genre and release year");
                        Console.WriteLine("Enter the ID to update");
                        int Id=Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Enter the name");
                        string Name=Console.ReadLine();
                        Console.WriteLine("Enter the genre");
                        string Genre=Console.ReadLine();
                        
                        Console.WriteLine("Enter the release year");
                        int Year=Convert.ToInt32(Console.ReadLine());
                   string updatetbl="UPDATE AnimeList SET AnimeName=@name,Genre=@genre,ReleaseYear=@year WHERE AnimeId=@id";
                   using(SqlCommand command=new SqlCommand(updatetbl,connection))
                    {

                        command.Parameters.AddWithValue("@id",Id);
                        command.Parameters.AddWithValue("@name",Name);
                        command.Parameters.AddWithValue("@genre",Genre);
                        command.Parameters.AddWithValue("@year",Year);
                        command.ExecuteNonQuery();
                        Console.WriteLine("Data Updated Successfully");
                        
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