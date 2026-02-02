using System;
using System.Data.SqlClient;
namespace DatabaseSchool
{
    class Program
    {
        public static void Main(string[] args)
        {
            string conndb="Server=DESKTOP-2V3O8L4\\SQLEXPRESS;Database=School Management;Integrated Security=true;";
            using(SqlConnection connection=new SqlConnection(conndb))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection to database established successfully.");
                    string selectqur="SELECT * FROM Student";
                    using(SqlCommand command=new SqlCommand(selectqur,connection))
                    {
                        using(SqlDataReader reader=command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                               int id=reader.GetInt32(0);
                                 string name=reader.GetString(1);
                                 int phone=reader.GetInt32(2);
                                 int roll=reader.GetInt32(3);
                                    Console.WriteLine($"ID: {id}, Name: {name}, Phone: {phone}, Roll: {roll}");
                            }
                            
                        }
                        
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                
            }
    }
}
}