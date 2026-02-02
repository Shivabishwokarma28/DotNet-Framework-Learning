using System;
using System.Collections.Generic; 
namespace List_Generic
{
  class ListExample
    {
        public static void Main(string [] args)
        {
            List<int> numb= new List<int>(); //List of integers
            Console.WriteLine("Before Addding Elements:" +numb.Count);
            numb.Add(20);
            numb.Add(45);
            numb.Add(78);
            Console.WriteLine("List of Numbers:");
            numb.Insert(3,51);
            foreach(int i in numb)
            {
               Console.WriteLine(i); 
            }   
            Console.WriteLine("After Adding Elements:" +numb.Count); 
            //for string
            List<string> str= new List<string>();
            Console.WriteLine("Before Addding Elements:" +str.Count);
            str.Add("Shiva");
            str.Add("Luffy");
            str.Add("Isagi");
            str.Add("Ichigo");
            Console.WriteLine("List of Numbers:");
            str.Insert(4,"Eren");
            foreach(string i in str)
            {
               Console.WriteLine(i); 
            }   
            Console.WriteLine("After Adding Elements:" +str.Count); 
        }
    }
}