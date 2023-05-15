using System.Threading.Channels;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1 step 1
            int add = 1 + 1;
            int subtract = 1 - 1;
            int multiply = 1 * 1;
            int divide = 1 / 1;
            int modulo = 1 % 1;

            // Exercise 1 step 2
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} = {quotient} remainder {remainder}");

            //Thought exercise
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);

            // Exercise 2
            PrintAreaOfCircle();

        }

        public static void PrintAreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}");
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
