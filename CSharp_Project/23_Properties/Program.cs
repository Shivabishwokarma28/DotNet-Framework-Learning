using System;
namespace Properties
{
    class Customer
    {
        private string name;
        private int pin;
        public string Name //A property in C# is a member of a class that provides
         //  a flexible way to read, write or compute the value of a private field.
         //  It acts like a combination of a variable and a method.


        {
            get              //get: returns the value of the field.
            {
                return name;
            }
            set              //staticet: assigns a value to the field.
            {
                name=value;
            }
            
        }
        public int Pin
        {
            get
            {
                return pin;
            }
            set
            {
               pin=value;
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            Customer c1=new Customer();
            c1.Name="Luffy"; 
            c1.Pin=2244;   

            Console.WriteLine($"The name of Customer is:{c1.Name}");
            Console.WriteLine($"The Atm pin of Customer is:{c1.Pin}");
        }
    }
}