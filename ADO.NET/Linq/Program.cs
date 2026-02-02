using System;
using System.Linq;
namespace Linque
{
    class Program
    {
        public static void Main(string[] args)
        {
            int [] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers=from num in numbers where num%2==0 select num;
            Console.WriteLine("Even Numbers:");
            foreach(var num in evenNumbers)
            {
                Console.WriteLine(num);
            }  

            int[] numbers2={21,22,23,24,25,26,27,28,29,30};
            var oddnumbers=from num in numbers2 where num%2!=0 select num;
            Console.WriteLine("Odd Numbers:");
            foreach(var num in oddnumbers)
            {
                Console.WriteLine(num);
            }
            int [] ages={18,22,25,30,35,40,45,50};
            var AgeAscending=from age in ages orderby age descending select age;
            Console.WriteLine("Ages in Descending Order:");
            foreach(var age in AgeAscending)
            {
                Console.WriteLine(age);
            }

        }
    }
}
