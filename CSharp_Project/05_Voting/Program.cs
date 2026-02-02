using System;
namespace VotingSystem
{

 class Voting
    {
        int age;
        void getdata()
        {
            Console.WriteLine("Enter your age:");
            age=Convert.ToInt32(Console.ReadLine());
        }
        void print()
        {
            string result=(age>=18)?"You are eligible to vote"
            :"You can't vote";  //ternary operator
            Console.WriteLine(result);
        }
        public static void Main(string[] args)
        {
        Voting v1=new Voting();

        v1.getdata();
        v1.print();
        }
    }   
}