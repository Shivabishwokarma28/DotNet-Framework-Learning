using System;
/*
namespace RectangleArea
{
    
    class Rectangle
    {
        static void Area(double length=8, double breadth=4)//default parameters
        {
            double area = length * breadth;
            Console.WriteLine("Area of Rectangle: {0}", area);
        }
        static void Main(string [] args)
        {
            Area(20.5,15.7);//passing values
            Area(10.5,25.3);
            Area();//ddefault values
        }
    }*/
    /*
    class Circle
    {
        static double Area(float radius)//Returning a value
        {
            double area = 3.14 * radius * radius;
             return area;
        }
        static void Main(string [] args)
        {
            Console.WriteLine($"Area of Circle: { Area(8.5f)}");

        }
    }
    
}
*/
 //Named arguments
namespace Anime
{
    class OnePiece
    {
        static void Characters(string name1, string name2, string name3)
        {
            Console.WriteLine("Character 1: {0}", name1);
           
        }
        public static void Main(string[] args)
        {
            Characters(name1:"Luffy",name2:"Zoro",name3:"sanji");
        }
    }
}