using System;
namespace ExceptionExample
{
    class ExcptEx
    {
        
        void getdata()
        {
            try{ // exception handling block

            Console.WriteLine("Enter the first number:");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seond number:");
             int num2=int.Parse(Console.ReadLine());
             if(num2==0)
             {
                Console.WriteLine("Error: Division by zero is not allowed!");
                return; 
             }
             double div=(double) num1/num2;
             Console.WriteLine($"num1/num2 = {div}");

            }

            catch(Exception E)
            {
                  Console.WriteLine("Error: Please enter a valid integer!");
            }
            finally
            {
                Console.WriteLine("this code always execute");
            }
        }
        public static void Main(string [] args)
        {
            ExcptEx E1=new ExcptEx();
            E1.getdata();
        }
    }
}