

using System;
using System.Dynamic;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;
namespace DelegateExample
{
    
    public delegate void Calculation(int a,int b); //Delegate
    //In C#, a delegate is a pointer to a method. 
    //That means, a delegate holds the address of a method which can be called using that delegate.
//delegate is a type-safe function pointer that 
     // allows methods to be referenced and invoked dynamically. 
    class Maths
    {
        public static void Add(int x,int y)
        {
            int sum=x+y;
            Console.WriteLine($"The Sum of two number: {sum}");
        }
        public static void Multi(int a,int b)
        {
            int mul=a*b;
            System.Console.WriteLine($"The product of two number: {mul}");

        } 
    }
    class Program
    {
        public static void Main(string [] args)
        {
        Calculation Obj=new Calculation(Maths.Add);
        Obj+=Maths.Multi;
         Obj.Invoke(15,3); 
        // Obj=new Calculation(Maths.Multi);
         //Obj.Invoke(10,4);
         
        }

    }
     
    /*
    class DelegateExample
    {
        public void print1()
        {
            Console.WriteLine("This is the first function");
        }
        public void print2()
        {
            Console.WriteLine("This is the second function");
            
        }
        public delegate void myDel();
        public static void Main(string [] args)
        {
            DelegateExample obj=new DelegateExample();
            myDel D1=new myDel(obj.print1);
            D1 +=obj.print2;//Multi cast delegate
            D1-=obj.print2;//Disconnect
            D1.Invoke();

        }
    }
    */
   
}