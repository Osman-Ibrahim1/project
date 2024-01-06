using System;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("Välkommen till miniräknaren!");
                Console.WriteLine("Ange ett tal:");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Felaktigt tal. Försök igen.");
                    continue;
                }

                Console.WriteLine("Ange en operation (+, -, *, /):");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine(); // För att lägga till radbrytning efter operationen.

                Console.WriteLine("Ange det andra talet:");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Felaktigt tal. Försök igen.");
                    continue;
                }

                double result = 0;
                try
                {
                    switch (operation)
                    {
                        case '+':
                            result = calculator.Add(num1, num2);
                            break;
                        case '-':
                            result = calculator.Subtract(num1, num2);
                            break;
                        case '*':
                            result = calculator.Multiply(num1, num2);
                            break;
                        case '/':
                            result = calculator.Divide(num1, num2);
                            break;
                        default:
                            Console.WriteLine("Ogiltig operation.");
                            continue;
                    }

                    Console.WriteLine("Resultatet är: " + result);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Vill du fortsätta? (ja/nej)");
                string continueInput = Console.ReadLine().ToLower();
                if (continueInput != "ja")
                {
                    break;
                }
            }
        }
    }
}
