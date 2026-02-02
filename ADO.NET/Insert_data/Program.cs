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
                   // Insert data
                   string insertqur="INSERT INTO AnimeList(AnimeName,Genre,ReleaseYear) VALUES(@name,@genre,@year)";
                   using(SqlCommand command=new SqlCommand(insertqur,connection))
                    {
                        Console.WriteLine("Insert Anime name,genre and release year");
                        Console.WriteLine("Enter Number of Records to be Inserted:");
                        int n=Convert.ToInt32(Console.ReadLine());
                        for(int i=1;i<=n;i++)
                        {
                        Console.WriteLine("Enter the name");
                        string Name=Console.ReadLine();
                        Console.WriteLine("Enter the genre");
                        string Genre=Console.ReadLine();
                        // IMPORTANT: Clear previous parameters in each iteration
                            command.Parameters.Clear();
                        Console.WriteLine("Enter the release year");
                        int Year=Convert.ToInt32(Console.ReadLine());
                        command.Parameters.AddWithValue("@name",Name);
                        command.Parameters.AddWithValue("@genre",Genre);
                        command.Parameters.AddWithValue("@year",Year);
                        command.ExecuteNonQuery();
                        Console.WriteLine("Data Inserted Successfully");
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