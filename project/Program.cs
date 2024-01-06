using System;

namespace Project
{
    class Adder
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    class Subtractor
    {
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    class Multiplier
    {
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
    }

    class Divider
    {
        public double Divide(double num1, double num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
            {
                Console.WriteLine("Kan inte dela med noll!");
                return double.NaN; // Not a Number
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Osman!");
            Console.WriteLine("Osman!");
            Console.WriteLine("bos!");
        }
    }
}