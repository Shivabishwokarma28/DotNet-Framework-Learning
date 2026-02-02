using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitEx
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            // Start tasks but DON'T await yet
           Task t1=Task1();
           Task t2=Task2();
           Task t3=Task3();

            // Wait for all of them to finish
            await Task.WhenAll(t1, t2, t3);

            Console.WriteLine("All tasks completed");
        }

        public static async Task Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("This is task 1 to print even number 1 to 20");
                for (int i = 1; i <= 20; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i);
                }

                Console.WriteLine("Task 1 sleep for 6sec");
                Thread.Sleep(6000);
                Console.WriteLine("Task 1 completed");
            });
        }

        public static async Task Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("This is task 2 to print characters");
                string[] str = { "Luffy","Zoro","Sanji","Nami","Robin","Brook","Usop","Franky","Chopper","Jimbe" };
                foreach (string i in str)
                    Console.WriteLine(i);

                Console.WriteLine("Task 2 sleep for 2sec");
                Thread.Sleep(2000);
                Console.WriteLine("Task 2 completed");
            });
        }

        public static async Task Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("This is task 3 ");
                Console.WriteLine("Task 3 sleep for 5 sec");
                Thread.Sleep(5000);
                Console.WriteLine("Task 3 completed");
            });
        }
    }
}
