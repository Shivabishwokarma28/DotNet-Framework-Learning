using System;
namespace MultidimentionalArray
{
    /*
    class ArrayEx
    {
        public static void Main()

        {
            int[,]arr= {{1,2,3},{5,7,9}};
            Console.WriteLine("Elements of 2D array are:");

            for(int i=0;i<arr.GetLength(0);i++)

            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    */

    // Matrix Addition
    class ArrayAdd
    {
        public static void Main(string [] args)
        {
            int[,] arr1=new int[2,2];
            int[,] arr2=new int[2,2];
            int[,] sum=new int[2,2];

            // Input for first 2D array

            Console.WriteLine("Enter elements of first 2D array:");
            for(int i=0;i<arr1.GetLength(0);i++)
            {
                for(int j=0;j<arr1.GetLength(1);j++)
                {
                    arr1[i,j]=Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("The elements of first 2D array are:");
            for(int i=0;i<arr1.GetLength(0);i++)
            {
                for(int j=0;j<arr1.GetLength(1);j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Second Array Input
            Console.WriteLine("Enter elements of second 2D array:");
            for(int i=0;i<arr2.GetLength(0);i++)
            {
                for(int j=0;j<arr2.GetLength(1);j++)
                {
                    arr2[i,j]=Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("The elements of second 2D array are:");
            for(int i=0;i<arr2.GetLength(0);i++)
            {
                for(int j=0;j<arr2.GetLength(1);j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Matrix Addition
            Console.WriteLine("The sum of two matrices is:");
            for(int i=0;i<sum.GetLength(0);i++)
            {
                for(int j=0;j<sum.GetLength(1);j++)
                {
                    sum[i,j]=arr1[i,j]+arr2[i,j];
                    Console.Write(sum[i,j]+" ");
                }
                Console.WriteLine();
            }
        
        }
        
    }
}