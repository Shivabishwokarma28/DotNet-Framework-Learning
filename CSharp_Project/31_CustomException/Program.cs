using System;
namespace CustomExceptionExamp
{
    /*
    public class ExcepDemo
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("Enter your age");
            int age=int.Parse(Console.ReadLine());
            if(age==0)
            {
               //throw new AgeNotValidException("Error! age can't be zero");
               throw new AgeNotValidException("Error! age can't be zero",new Exception("Inner Exception"));
            }
            else
            {
                Console.WriteLine($"Your age is : {age}");
            }
        }
    }
    public class AgeNotValidException:Exception
    {
        public AgeNotValidException(string message):base( message)
        {
            
        }
        public AgeNotValidException(string message,Exception innerException):base( message,innerException)
        {
            
        }
    }
*/
    public class AccountBalanceException:Exception
    {
      AccountBalanceException(string message):base(message) //constructor
        {
            
        }  
    }
    class Program
    {
        public static void Main(string[] args)
        {
        double balance=1000;
        try{
            Console.WriteLine("Enter the amount to withdraw");
            double withdraw=double.Parse(Console.ReadLine());
            if(withdraw>balance)
                {
                    throw new AbandonedMutexException($"Insufficient balance: {balance}");
                   
                }
                 balance-=withdraw;
                    Console.WriteLine("Withdraw successfull  :"+balance);
        }
        catch(AccountBalanceException ex)
            {
                Console.WriteLine(ex.Message+ $"Current balance is {balance}");
            }
        }
    }
}