//Collection in c#
using System;
using System.Collections; // 
namespace CollectionExample
{
    //Array Resize Example:
    /*
    class program
    {
        public static void Main(string[] args)
        {
            int [] arr=new int[3];
            arr[0]=9;
            arr[1]=8;
            arr[2]=7;
            // arr[3]=55; // This will cause an IndexOutOfRangeException
            Array.Resize(ref arr, 5); // Resizing the array to hold 5 elements
            // Now we can add more elements without causing an exception
            arr[3]=55;
            Console.WriteLine(arr[3]);
            
        // Note: Resize() method of an array destroys the old array
        //and creates a new one with new length .   
        }
    }
    */
    class CollectionExamp
    {
        public static void Main(string[] args)
        {
            //ArrayList Example
           ArrayList arr= new ArrayList();
           Console.WriteLine("Before adding "+arr.Capacity); // Capacity property shows the current capacity of the ArrayList
           arr.Add(19);
           arr.Add(30);
           arr.Add("Shiva");
           arr.Add(21.22);
           arr.Add("Luffy");
              Console.WriteLine("After adding "+arr.Capacity);
            arr.Insert(5,"Zoro");// Insert method to insert an element at a specific index 

            arr.Remove(19); // Remove method to remove a specific element

            arr.RemoveAt(2);// RemoveAt method to remove an element at a specific index
           foreach(object item in arr) // we use object because ArrayList can store any type of data
            {
                Console.Write(item+" ");
            }
        }
    }
}