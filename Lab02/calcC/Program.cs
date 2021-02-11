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
        public Calculator() { Accumulator = 0; }

        public double Add(double a, double b)
        { return Accumulator = a + b; }

        public double Subtract(double a, double b)
        { return Accumulator = a - b; }

        public double Power(double a, double b)
        { return Accumulator = Math.Pow(a, b); }

        public double Multiply(double a, double b)
        { return Accumulator = a * b; }

        public double Divide(double a, double b)
        {
            if(b==0)
                throw new DivideByZeroException("Divided by zero");

            return Accumulator = a / b;
        }

        public double Accumulator { get; private set; }

        public void Clear()
        { Accumulator = 0; }

        public double Add(double addend)
        { return Accumulator += addend; }

        public double Subtract(double subtractor)
        { return Accumulator -= subtractor; }

        public double Multiply(double multiplier)
        { return Accumulator *= multiplier; }

        public double Divide(double divisor)
        { return Accumulator /= divisor; }

        public double Power(double exponent)
        { return Accumulator = Math.Pow(Accumulator, exponent); }
    }
}
