using System;

namespace calcC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator calc = new Calculator();

            Console.Write("Number 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Number 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Added: " + calc.Add(a, b).ToString());
            Console.WriteLine("Subtracted: " + calc.Subtract(a, b).ToString());
            Console.WriteLine("Powered: " + calc.Power(a, b).ToString());
            Console.WriteLine("Multiplied: " + calc.Multiply(a, b).ToString());
        }
    }

    public class Calculator
    {
        public Calculator() { }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
