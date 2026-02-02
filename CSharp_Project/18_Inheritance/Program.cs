using System;
namespace InheritanceExample
{
    /*
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animals can eat");
        }
    }
    class Dog:Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog can bark");
        }
    }
    class Program
    {
        public static void Main(string [] args)
        {
            Dog D1=new Dog();
            D1.Eat();
            D1.Bark();
            
        }
    }
    */
    class Employee
    {
        public double salary=40000;
        public Employee()
        {
            Console.WriteLine("This is the employee of our company");
            Console.WriteLine("The Employee salary is:"+salary);
            
        }
    }
    class Developer:Employee//Derived class
    {
        public double bonus=10000;
        public void WriteCode()
        {
            Console.WriteLine("Developer write code");

            Console.WriteLine("Developer bonus:"+bonus);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Developer d1=new Developer();
            d1.WriteCode();
            double Devsalary=d1.salary + d1.bonus;
            Console.WriteLine("Developer salary is:"+Devsalary);
        }
    }
}