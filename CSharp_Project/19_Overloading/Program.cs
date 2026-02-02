// Method overloading
//Multiple methods with same name but different parameters
namespace MathCalculations
{
    class MathCalculations
    {
        int sum(int a, int b)
        {
            return a+b;
        }
        double sum(double a, double b, double z)
        {
            return a + b + z;
        }
        static void Main(string [] args)
        {
            MathCalculations M1= new MathCalculations();
            Console.WriteLine($"The sum of two integers:{M1.sum(5,10)}");
            Console.WriteLine("The sum of three doubles:{0}",M1.sum(5.2,10.8,2.9));
        }
    }
}
