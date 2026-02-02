using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnection
{
    class Program
    {
        static string conndb="server=DESKTOP-2V3O8L4\\SQLEXPRESS; Database=Netflix; Integrated Security=true;";
        static void Main(string [] args)
        {
            
            Console.WriteLine("\n--- Netflix Anime Database ---");
                Console.WriteLine("1. Insert Anime");
                Console.WriteLine("2. View Anime");
                Console.WriteLine("3. Update Anime");
                Console.WriteLine("4. Delete Anime");
                Console.WriteLine("5. Exit");
                Console.Write("Choose option: ");
                int choose=int.Parse(Console.ReadLine());
                switch(choose)
            {
                case 1: Insertdata(); break;
                case 2: Selectdata(); break;
                case 3: Updatedata(); break;
                case 4: Deletedata(); break;
                case 5: return; 
                default: Console.WriteLine("Invalid Choice:");
                break;
            }

        }
        //choice 1 to insert data
        static void Insertdata()
        {
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

        // choice 2 to view data
        static void Selectdata()
        {
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
        // choice 3 to update data
        static void Updatedata()
        {
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
        // choice 4 to delete data
        public static void Deletedata()
        {
            using(SqlConnection connection=new SqlConnection(conndb))
            {
                try
                {
                   connection.Open();
                   //Console.WriteLine("Connection Opened Successfully"); 
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
