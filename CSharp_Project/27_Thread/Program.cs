using System;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
namespace ThreadingDemo
{
    class ThreadEx
    {
        public static void fun1()
        {
            for(int i=1;i<=40;i++)
            {
               System.Console.WriteLine($"Func 1= {i}"); 
            }
        }
         public static void fun2()
        {
            for(int i=1;i<=40;i++)
            {
               System.Console.WriteLine($"Func 2 = {i}"); 
                if(i==20)
                {
                    System.Console.WriteLine("Thread is going to sleep for 5 sec");
                     Thread.Sleep(5000);
                }
            }
        }
         public static void fun3()
        {
            for(int i=1;i<=40;i++)
            {
               System.Console.WriteLine($"Func 3 = {i}"); 
            }
        }
        public static void Main(string [] args)
        {
            Thread t1=new Thread(fun1);
            Thread t2=new Thread(fun2);
            Thread t3=new Thread(fun3);
            t1.Start();
            t2.Start();
            t3.Start();
            //  ThreadEx.fun1();
            // ThreadEx.fun2();
            // ThreadEx.fun3();
            // Thread t= Thread.CurrentThread;
            // t.Name="Main Thread";
            // System.Console.WriteLine($"Current Executing Thread is: {Thread.CurrentThread.Name}");
            // Console.ReadLine();

        }
    }
}