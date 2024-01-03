namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {


                exitBool = false;

                while (exitBool == false)
                {
                    Console.WriteLine(
                   "\n Meny till Miniräknare" +
                   "\n------------------------------------------- +
                   "\n Vilken beräkning skulle du vilja göra? +
                   "\n1. Additon?" +
                   "\n2. Substration" +
                   "\n3. Multiplikation" +
                   "\n4. Division " +
                   "\n5. Eller skulle du vilja avsluta programmet?" +
                   "\n------------------------------------------");
                    Console.WriteLine();
                    Console.Write("Välj ett alternativ");
                    
                }



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