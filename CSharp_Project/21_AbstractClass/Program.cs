/* Data abstraction is the process of hiding certain details and 
   showing only essential information to user

 Abstract class is a restricted class that cannot be used to create objects
*/
using System;
namespace AbstractExample
{
    abstract class Person
    {
        public string name;
        public int age;
        public abstract void Getdata();//abstract method only used i abstract class
                                     //it doesnot have body
        public abstract void Display();
    
    }
    class Student : Person
    {

           public override void Getdata()
        {
           Console.WriteLine($"Enter the name of Student:");
          name=Console.ReadLine();

           Console.WriteLine($"Enter the age of Student:");
            age=int.Parse(Console.ReadLine());
            
        }
        public override void Display()
        {
            Console.WriteLine($"The name of Student is:{name}");
             Console.WriteLine($"The age of Student is:{age}");
        }

    }
    class Program
    {
        public static void Main(string [] args)
        {
            Student s1=new Student();
            s1.Getdata();
            s1.Display();
        }
        
    }
    
}