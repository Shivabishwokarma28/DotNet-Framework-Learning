//Array Methods in C#
//Array Sorting in C#
//There are many array methods available,
// for example Sort(), which sorts an array alphabetically or in an ascending order
using System;
using System.Linq;
namespace ArraySortExample
{
    class ArraySortExa
    {
        void getdata()
        {
            string[] bike={"Crossfire","kawasaki","benalli","CX250"};
            int[] num={23,45,12,67,34};

            Console.WriteLine("Before Sorting:");
            foreach(string i in bike)
            {
                Console.WriteLine(i);
            }
            Array.Sort(bike);//Sorting the array
            Console.WriteLine("After Sorting:");
            foreach(string i in bike)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Largest Element"+ num.Max());//Max()
             Console.WriteLine("Smallest Element"+ num.Min());//Min()
            Console.WriteLine("The sum of array Element"+ num.Sum());//Sum()
             Console.WriteLine("Index of 67"+ Array.IndexOf(num,67));//IndexOf()

        }
    
    public static void Main(string [] args)
        {
            ArraySortExa a1=new ArraySortExa();
            a1.getdata();
            
        }
}
}