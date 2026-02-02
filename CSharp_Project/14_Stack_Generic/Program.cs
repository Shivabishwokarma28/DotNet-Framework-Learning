// Stack Program
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
using System.Xml;

namespace GenericExample
{
    class Stack
    {
        Stack<string> name= new Stack<string>(); // anime names
        void getdata()
        {
            Console.WriteLine("Before push:"+ name.Count);
            name.Push("One Piece");// used to add item to the top of the stack
            name.Push("Attack On Titan");
            name.Push("Gachiakuta");
            name.Push("Blue Lock");
            Console.WriteLine("");
             Console.WriteLine("After push:"+ name.Count);
             Console.WriteLine("Peek element : "+ name.Peek());//top element

             foreach(string i in name)
            {
               Console.WriteLine(i); 
            }
            Console.WriteLine("After Pop:");
            name.Pop();
             foreach(string i in name)
            {
               Console.WriteLine(i); 
            }

        }
        public static void Main(string[] args)
        {
            Stack S1=new Stack();
            S1.getdata();
            
        }
    }
    
}