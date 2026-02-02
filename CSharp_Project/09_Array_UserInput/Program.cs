//Array
using System;
using System.Data;
using System.Runtime.InteropServices;
namespace ArrayExample

{
    /*
    class Car
    {
       public void Display()
        {
            string[] cars={"Mustang", "BMW","Audi","Ferrari"};
            foreach(string i in cars)
            {
            Console.WriteLine(i);
            }
            Console.WriteLine("Length of the array is: " + cars.Length);
            Console.WriteLine("Index of the BMW is: " + Array.IndexOf(cars, "BMW"));
        }

        public void Creatarr()
        {
            int[] arr1= new int[5];//// Create an array of 5 elements, and add values later
            int[] arr2=new int[5] {1,5,10,15,25};//Create an array of 5 elements and add values right away 
            int[] arr3= new int[] {2,4,6,8};// Create an array of four elements without specifying the size
            int [] arr4={3,4,5,6};// omitting the new keyword, and without specifying the size
                                   //omitting means leaving out

        Console.WriteLine("Elements of arr 2 are:");
        foreach(int i in arr2)
            {
                Console.WriteLine(i);
            }
       
         //// Add values without using new (this will cause an error)
        //cars = {"Volvo", "BMW", "Ford"};
        }
       


    }
    class ProgramDisp
    {
         public static void Main(string [] args)
        {
            Car c1 = new Car();
            c1.Display();
            c1.Creatarr();
        }
    }
    */

    //Array by user input
    class ProgramDisp
    {
        

        public void getdata()
        {
            
            Console.WriteLine("Enter the size of the array:");
            int size= int.Parse(Console.ReadLine());  //Taking size of array from user

            int [] arr= new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for(int i=0; i<arr.Length;i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
                
            }
            
            Console.WriteLine("The elements of the array are:");
            for(int i=0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            
        }
        public static void Main(string [] args)
        {
            ProgramDisp p1= new ProgramDisp();
            p1.getdata();
        }
    }
}