using System;
namespace StringProgram
 {
    class Employee
    {
        string fname;//first name
        string lname;//last name
        void getdata()
        {
            Console.WriteLine("Enter first name:");
            fname=Console.ReadLine();
            Console.WriteLine("Enter last name:");
            lname=Console.ReadLine();

            //Note: if we add two string the result will be concatenated:
            //string a=12; string b=14;
            // string c=a+b; //c=1214
        }
        void print()
        {
            Console.WriteLine($"The employee name is:{string.Concat(fname," \t",lname)}");
        }
        
        public static void Main(string[] args)
        {
            Employee emp=new Employee();
            emp.getdata();
            emp.print();

            //String Interpolation
             //String interpolation lets us embed variables directly inside a string using $"...".
             string college1="Pulco College";
             string collage2="Thapathali";
             
             // backslash escape character

             string combined=$"Tribhuvan University top collages:\"{college1}\" and \"{collage2}\"";
             
             Console.WriteLine(combined);

             string extract=collage2.Substring(5);
             Console.WriteLine(extract.ToUpper());
             Console.WriteLine(extract.IndexOf("l"));
             
        }
    }

    
}