using System.ComponentModel;

namespace Calculator
{
    
    internal class Program
    {

        class MyCalculator
        {
            public double num1;
            public double num2;
            

            public static double AddCalculator(double num1, double num2)
            {
                Console.WriteLine(num1 + num2);

                return num1 + num2;
            }

            public static double Abstract(double num1, double num2)
            {
                
                Console.WriteLine(num1 - num2);

                return num1 - num2;
            }

            public static double Multiple(double num1, double num2)
            {
                
                Console.WriteLine(num1 * num2);

                return num1 * num2;
            }

            public static double Divide(double num1, double num2)
            {
                
                if (num2 == 0)
                {
                    Console.WriteLine("0으로 나누면 안됩니다.");
                }
                
                Console.WriteLine(num1 / num2);

                return num1 / num2;
            }

            public static double Squared(double num1, double num2)
            {                                
                Console.WriteLine(Math.Pow(num1, num2));                

                return Math.Pow(num1, num2);
            }
        }
        static void Main(string[] args)
        {
            MyCalculator.AddCalculator(2.0f, 3.0f);
            MyCalculator.Abstract(2.0f, 3.0f);
            MyCalculator.Multiple(2.0f, 3.0f);
            MyCalculator.Divide(2.0f, 0);
            MyCalculator.Squared(2.4f, 3.0f);
        }
    }
}
