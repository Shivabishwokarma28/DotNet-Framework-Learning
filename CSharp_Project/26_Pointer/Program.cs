using System;
namespace PointerExample
// <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
{
    /*
    class Program
    {
        public unsafe void Print()
        {
            int a=10;
            int *ptr=&a;
            Console.WriteLine($"{*ptr}");
        }
        public static void Main(string [] args)
        {
            Program P1=new Program();
            P1.Print();
            
        }
    }
    */
    class PointerEx
    {
        unsafe void Modifyval(int *p)
        {
            *p=100;

        }
        public unsafe static void Main(string[] args) //unsafe context
        {
            PointerEx p=new PointerEx();
            int numb=20;
            p.Modifyval(&numb);
            Console.WriteLine($"The modified value is {numb}");
        }
    }
}