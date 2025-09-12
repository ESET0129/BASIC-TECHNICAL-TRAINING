using System.Diagnostics.CodeAnalysis;
using System.Numerics;
namespace ConsoleApp1
{
    internal class Program
    {
        static int sum;
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("The sum is: " + sum);
            var myResult = Addition(num1, num2);
            string name = "abcd";
            string displayName = name ?? "Unknown";
            Console.WriteLine(displayName); // Output: Unknown
            Console.WriteLine(myResult.firstnumber); // Output: Unknown


        }
        static (int firstnumber, int secondnumber, int result) Addition(int firstnumber, int secondnumber)
        {
            Console.WriteLine("Reached Addition method");
            sum = firstnumber + secondnumber;
            Console.WriteLine("The sum of {0} and {1} is :{2}", firstnumber, secondnumber, sum);
            return (firstnumber, secondnumber, sum);
        }
    }
}
