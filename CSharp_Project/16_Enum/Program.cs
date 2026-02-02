using System;
using System.Security.Authentication;
namespace EnumerationEx
{
    class EnumExample
    {
        public enum Weeks // enum
        {
            Sun,Mon,Tue,Wed,Thus,Fri,Sat
        }
        
        public static void Main(string [] args)
        {
            int num=(int)Weeks.Tue;
            Console.WriteLine("For Tue index: "+num); //for Tue index
            Console.WriteLine(Weeks.Fri);
            Console.WriteLine((int)Weeks.Fri);//shows index
            Console.WriteLine(Weeks.GetName(typeof(Weeks),5));//shows typeof weeks and print 5th index
            foreach(string str in Weeks.GetNames(typeof(Weeks)))
            {
              Console.WriteLine(str);  
            }
            
        }
    }
    
}