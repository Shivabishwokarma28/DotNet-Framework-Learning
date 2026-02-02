using System;
using System.Data.SqlTypes;// we can use class from System namespace
namespace simpleapp // container for classes
{
    class Program //container for  data and methods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a simple c# program.");
            //Console is a class in System namespace
            //WriteLine is a method of Console class
            
            double b=20.55999;
            const int a=20;
            Console.WriteLine("The value of a is :"+a);
            Console.WriteLine($"The value of b is:{b}");
            bool isCsharp=true;
            Console.WriteLine("Is C# is a programming language?\n"+isCsharp);
            string name="Sanji";
            string lastname="kun";
            string fname=string.Concat(name," ",lastname);
            Console.WriteLine(fname);
            long num=122323232L;
            Console.WriteLine("The long value is:"+num);

            //Signed types can store negative and positive numbers.
            int temperature=-19;
            Console.WriteLine("The temperature is:"+temperature);
            //unsigned types can store only positive numbers.
            uint positiveNum=19;
            Console.WriteLine("The positive number is:"+positiveNum);
            //Nullable types allow null value
            int? nullnum=null;
            Console.WriteLine("The nullable number is :"+nullnum);
            

        }
    }
}