using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
namespace OverridingExample
{
    class CalcArea
    {
        public void Area()
        {
            Console.WriteLine("Area Calculation for shapes");
        }
    }
    class Square:CalcArea
    {
        public int l=10;// length
        
         public void Area()
        {
            base.Area(); //Now CalcArea method call first
            Console.WriteLine("Area of square table is:"+(l*l));
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Square s1= new Square();
            s1.Area();
        
        }
    }
}