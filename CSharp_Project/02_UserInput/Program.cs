// Simple user input program
using System;
namespace UserInput
{
    class Student
    {
        string name;
        int age;
        void getdata()
        {
             Console.WriteLine("Enter your name:");
            name=Console.ReadLine();//UI
            Console.WriteLine("Enter your age:");
            age=Convert.ToInt32(Console.ReadLine());
        }
        void print()
        {
            Console.WriteLine($"The name of student is {name}");
            Console.WriteLine($"The age of student is {age}");
        }
        public static void Main(string [] args)
        {
           Student s1=new Student();
              s1.getdata();
                s1.print();
        }
    }
}