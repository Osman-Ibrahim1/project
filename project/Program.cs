using System;

namespace Project
{
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
                   "\n Vilken beräkning skulle du vilja göra? Välj Metod 1-4." +
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
                    Console.WriteLine("Oops.. Det var fel menyval. Välj istället en siffra mellan 1-5 för att välja metod :) \n");
                    continue;
                }

                switch (menuSelector)
                {
                    case 1:
                        PerformCalculation("+");
                        break;

                    case 2:
                        PerformCalculation("-");
                        break;

                    case 3:
                        PerformCalculation("*");
                        break;

                    case 4:
                        PerformCalculation("/");
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

        static void PerformCalculation(string operation)
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
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        // Kontrollera så att man inte dividerar med noll
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Fel: Kan inte dividera med noll.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Felaktig operatör.");
                        continue;
                }

                // Visa resultatet
                Console.WriteLine($"Resultatet av {num1} {operation} {num2}: {result}");

                // Fråga om användaren vill fortsätta
                Console.WriteLine("Vill du göra en ny beräkning? (ja eller nej): ");
                while (Console.ReadLine().ToLower() == "ja");

               Console.WriteLine("Okej då stänger vi ner");
            }
        }
    }
}
        
    
