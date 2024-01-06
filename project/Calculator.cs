using System;

public class Class1
{
	public Class1()
	{

         internal class Miniräknare
    {
        public double Addera(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtrahera(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicera(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividera(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Kan inte dividera med noll.");
            }

            return num1 / num2;
        }
    }
}
}
