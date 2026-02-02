
// Example of Encapsulation
// It is practice of wrapping the data (variables) and code acting on the data (methods) together as a single unit.
// data can't be accessed by other class
using System;
 namespace EncaptulationEx
{
    class Door
    {
        private int password=2244;
        public void getdata()
        {
            Console.WriteLine("Enter the password to open the deoor:");
            int userinp=Convert.ToInt32(Console.ReadLine());
            if(userinp==password)
            {
                Console.WriteLine("Door is opened");
            }
            else
            {
                Console.WriteLine("Wrong password! Try again");
            }
            
        }

    }
    class SecureDoor
    {
        static void Main(string [] args)
        {
            Door D1= new Door();
            
            D1.getdata();
        }
            
    }
}