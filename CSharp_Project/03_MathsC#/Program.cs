using System;
namespace Maths
{
    class Square
    {
        double length;
        void getdata()
        {
            Console.WriteLine("Enter the length of the square garden :");
            length=Convert.ToDouble(Console.ReadLine());
        }
        public void display()
        {
            double area=length*length;
            Console.WriteLine($"The area of square garden is:{area}");
            double l=Math.Sqrt(area);//SquareRoot
             Console.WriteLine($"The squre root of the area is:{l}");//just to show the use of Math class
        }
        public static void Main(string [] args)
        {
            Square s=new Square();
            s.getdata();
            s.display();
            
           
        }
    }



}