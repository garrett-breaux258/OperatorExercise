using System;

namespace OperatorExercise
{
    class Program
    {
        //____________________________________Ex.1_______________________________
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static void Divide(int a, int b)
        {
            var quotient = a / b;
            var remainder = a % b;
            
            Console.WriteLine ($"{a}/ {b} is {quotient} with remainder of {remainder}");

        }
        //Exercise 2
        public static double AreaOfCircle(double r)
        {

              return Math.PI * (r*r);

        }



        static void Main(string[] args)
        {
           Console.WriteLine(Add(4, 5));
            Console.WriteLine(Sub(10, 4));
            Console.WriteLine(Multiply(20, 4));
            Divide(17, 4);

            Console.WriteLine("What is the radius of circle?");
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with a radius of {r} is {AreaOfCircle(r)}");

            var i = 3;
            var j = 4;
            var k = (++i) * (j++);//Answer should be 16
            Console.WriteLine(k);
            
        }
    }
}
