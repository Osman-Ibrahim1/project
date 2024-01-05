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
            bool exitBool = false;

            while (!exitBool)
            {
                Console.WriteLine(
                   "\n Meny till Miniräknare" +
                   "\n-------------------------------------------" +
                   "\n Vilken beräkning skulle du vilja göra? Välj Metod/Operatör 1-4." +
                   "\n1. Addition" +
                   "\n2. Subtraktion" +
                   "\n3. Multiplikation" +
                   "\n4. Division " +
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

                switch (menuSelector)
                {
                    case 1:
                        PerformCalculation(new Adder(), "+");
                        break;

                    case 2:
                        PerformCalculation(new Subtractor(), "-");
                        break;

                    case 3:
                        PerformCalculation(new Multiplier(), "*");
                        break;

                    case 4:
                        PerformCalculation(new Divider(), "/");
                        break;

                    case 5:
                        Console.WriteLine("Avslutas...");
                        exitBool = true;
                        break;

                    default:
                        Console.WriteLine("Oops.. Det var fel menyval. Välj istället en siffra mellan 1-5 för att välja metod :) \n");
                        break;
                }
            }
        }

        static void PerformCalculation(object calculator, string operation)
        {
            while (true)
            {
                Console.Write("Ange det första talet: ");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Felaktig inmatning. Försök igen.");
                    continue;
                }

                Console.Write("Ange det andra talet: ");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Felaktig inmatning. Försök igen.");
                    continue;
                }

                // Utför beräkningen beroende på operatören
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = ((Adder)calculator).Add(num1, num2);
                        break;
                    case "-":
                        result = ((Subtractor)calculator).Subtract(num1, num2);
                        break;
                    case "*":
                        result = ((Multiplier)calculator).Multiply(num1, num2);
                        break;
                    case "/":
                        result = ((Divider)calculator).Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Felaktig operatör.");
                        continue;
                }

                // Visa resultatet
                Console.WriteLine($"Resultatet av {num1} {operation} {num2}: {result}");
                Console.WriteLine($"Resultat: {result}");

                // Fråga om användaren vill fortsätta
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