// Parameterized Constructor
using System;

namespace ConstructorExample
{
   

    class Employee
    {
         public double Salary;
         public string Name;
         public Employee(double salary, string name)//Parameterized Constructor
         {
             Salary = salary;
             Name = name;
         }
         ~Employee() //destructor cannot have access modifiers or parameters    
         {
         Console.WriteLine($"Destructor called {Name}");
         }
         public static void Main(string [] args)
        {
            Employee E1= new Employee(60000,"Eric");    //arguments are passed
            Console.WriteLine($"The name of the employee is {E1.Name}");
             Console.WriteLine($"The salary of the employee is {E1.Salary}");

               E1 = null;                 // remove reference
    GC.Collect();              // request garbage collection
    GC.WaitForPendingFinalizers(); //wait for destructor
        }
    }
}