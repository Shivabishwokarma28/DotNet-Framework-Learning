using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text; //for string builder
using System.Diagnostics;
namespace StringBuilderExap
{
    class StingBuilder
    {
        public static void Main(string[] args)
        {
            string name="Ichigo";  //strings are immutable
                                  //Cannot be changed once created
            /*
            Stopwatch sw=new Stopwatch();
            sw.Start();
            for(int i=0;i<10000;i++)
            {
                
             name=name+i;
            
            }
            sw.Stop();
            */
             
            StringBuilder s1= new StringBuilder("Hello");//StringBuilder are mutable
                                                          //can be change once created
            /*
            Stopwatch sw2=new Stopwatch();
               sw2.Start();
            for(int i=0;i<10000;i++)
            {
                
                s1.Append(i);
               
            
            }
             sw2.Stop();
             Console.WriteLine( "Time taken by string: "+sw.ElapsedMilliseconds);
             Console.WriteLine("Time taken by StringBuilder :"+sw2.ElapsedMilliseconds);
             */
            Console.WriteLine( s1.Append(" Shiva"));// Append is used to update the same StringBuilder object
        }
    }
}