namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Användarens input
                Console.Write("Ange det första talet: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ange operatören (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.Write("Ange det andra talet: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Utför beräkningen beroende på operatören
                double result = 0;
                switch (op)
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
                Console.WriteLine("Resultatet: " + result);
                Console.WriteLine("Resultatet: " + result);

                // Fråga om användaren vill fortsätta
                Console.Write("Vill du göra en ny beräkning? (ja/nej): ");
                string continueInput = Console.ReadLine().ToLower();

                if (continueInput != "ja")
                {
                    break;
                }
            }

        }
    }
}