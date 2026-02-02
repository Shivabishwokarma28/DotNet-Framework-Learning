/*Interface 

It is like an abstract class but it can only contain abstract Method
(Method with no body)
Used to Implement Multiple inheritance
Class or Struct Implementing the interface must override the method
abstract classes, interfaces cannot be used to create objects

 */
using System;
using System.Formats.Asn1;
public interface Maths
{
     void Calculation(int a,int b);
}
public interface MathsDiv
{
      void Division(int x,int y);
    
}

class Mcalculation : Maths,MathsDiv//Multiple interface
{
    public void  Calculation(int a, int b)
    {
        int sum=a+b;
        Console.WriteLine($"The sum of two number is:{sum}");
        
    }
    public void Division(int x,int y)
    {
        double Div=(double)x/y;
        Console.WriteLine($"The Division of {x}/{y} is:{Div}");
        
    }

}
class Program
{
    public static void Main(string [] args)
    {
    Mcalculation M1=new Mcalculation();
    M1.Calculation(12,22);
    M1.Division(44,3);
    }
}