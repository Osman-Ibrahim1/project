using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project
{
    internal class Calculator
    {
        public interface IOperation
        {
            double Operate(double num1, double num2);
        }

        public class Adder : IOperation
        {
            public double Operate(double num1, double num2)
            {
                return num1 + num2;
            }
        }

        public class Subtractor : IOperation
        {
            public double Operate(double num1, double num2)
            {
                return num1 - num2;
            }
        }

        public class Multiplier : IOperation
        {
            public double Operate(double num1, double num2)
            {
                return num1 * num2;
            }
        }

        public class Divider : IOperation
        {
            public double Operate(double num1, double num2)
            {
                if (num2 != 0)
                    return num1 / num2;
                else
                {
                    Console.WriteLine("Kan inte delas med noll!");
                    return double.NaN; // Not a Number
                }
            }
        }
    }
}