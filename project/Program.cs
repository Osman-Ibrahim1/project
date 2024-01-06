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
                Console.WriteLine("Kan inte delas med noll!");
                return double.NaN; // Not a Number
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitBool = false;

            while (!exitBool)
            {
                Console.WriteLine(
                   "\n Meny till Miniräknare" +
                   "\n-------------------------------------------" +
                   "\n Vilken beräkning skulle du vilja göra? Välj Metod/Operatör 1-4." +
                   "\n1. Addition + " +
                   "\n2. Subtraktion -" +
                   "\n3. Multiplikation *" +
                   "\n4. Division /" +
                   "\n5. Avsluta programmet" +
                   "\n------------------------------------------");
                Console.WriteLine();
                Console.Write("Välj ett alternativ: ");

                int menuSelector;

                if (!int.TryParse(Console.ReadLine(), out menuSelector) || menuSelector < 1 || menuSelector > 5)
                {
                    Console.WriteLine("Oops.. Det var fel menyval. Välj istället en siffra mellan 1-5 :) \n");
                    continue;
                }

                Calculator.IOperation calculatorOperation = null;
                var operation = "";

                switch (menuSelector)
                {
                    case 1:
                        calculatorOperation = new Calculator.Adder();
                        operation = "+";
                        break;

                    case 2:
                        calculatorOperation = new Calculator.Subtractor();
                        operation = "-";
                        break;

                    case 3:
                        calculatorOperation = new Calculator.Multiplier();
                        operation = "*";
                        break;

                    case 4:
                        calculatorOperation = new Calculator.Divider();
                        operation = "/";

                        break;

                    case 5:
                        Console.WriteLine("Avslutas...");
                        exitBool = true;
                        break;

                    default:
                        Console.WriteLine("Oops.. Det var fel menyval. Välj istället en siffra mellan 1-5 för att välja metod :) \n");
                        break;
                }

                if (operation != "" && calculatorOperation != null)
                {
                    PerformCalculation(calculatorOperation, operation);
                }
            }
        }

        static void PerformCalculation(Calculator.IOperation calculator, string operation)

        {
            bool continueCalculation = true;

            while (continueCalculation)
            {
                Console.Write("Ange det första talet: ");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Tyvärr skrivfel. Testa igen.");
                    continue;
                }

                Console.Write("Ange det andra talet: ");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Tyvärr skrivfel. Testa igen.");
                    continue;
                }

                double result = calculator.Operate(num1, num2);


                Console.WriteLine($"Resultatet av {num1} {operation} {num2}: {result}");

                Console.WriteLine("Vill du göra en ny beräkning? (ja eller nej): ");
                if (Console.ReadLine().ToLower() != "ja")
                {
                    Console.WriteLine("Okej då stänger vi ner");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}