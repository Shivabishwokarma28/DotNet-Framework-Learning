using System;
using System.Threading;
using System.Threading.Tasks;
/*
Task Parallel Library is a collection of APIs that provides more control over parallel
and asynchronous programming
TPL reduces CPU overheatung in long-running tasks
*/
namespace TPLExample
{
    class TaskParallelEx
    {
        public static void Main(string [] args)
        {
            //task to run concurrently
            Task task1= Task.Run(()=>PrintData());
            Task task2= Task.Run(()=>PrintData());
            Task.WhenAll(task1,task2).Wait();//Waits until both tasks finish

                                            //Prevents the program from exiting early
            //Task.Run(PrintData()); // PrintData runs immediately on main thread
        }
         static void PrintData()
        {
            for(int i=1;i<=20;i++)
            {
               System.Console.WriteLine($" {i}"); 
               if(i==15)
                {
                    Console.WriteLine("Thread Sleep for 8 sec");
                    Thread.Sleep(8000);
                }
            }
        
        }
    }
}