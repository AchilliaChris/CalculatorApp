using System;
using static CalculatorApp.Program;

namespace CalculatorApp
{
    internal class Program
    {
        public interface ICalculator
        {
            int Adding(int x, int y);
            int Subtracting(int x, int y);
            int Multiplying(int x, int y);
            int Dividing(int x, int y);
        }

        public class MyCalculator : ICalculator
        {

            public int Adding(int x, int y)
            {
                return x + y;
            }

            public int Subtracting(int x, int y)
            {
                return x - y;
            }

            public int Multiplying(int x, int y)
            {
                int result = 0;
                bool isNegative = false;

                if (y < 0)
                {
                    y = -y;
                    isNegative = true;
                }

                for (int i = 0; i < y; i++)
                {
                    result += x;
                }

                return isNegative ? -result : result;
            }

            public int Dividing(int x, int y)
            {
                if (y == 0)
                {
                    throw new ArgumentException("Cannot divide by zero");
                }

                int quotient = 0;
                bool isNegative = false;

                if (x < 0)
                {
                    x = -x;
                    isNegative = !isNegative;
                }

                if (y < 0)
                {
                    y = -y;
                    isNegative = !isNegative;
                }

                while (x >= y)
                {
                    x -= y;
                    quotient++;
                }

                return isNegative ? -quotient : quotient;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Adding 3 to 5");
            Console.WriteLine(Solution.Run("adding", 3, 5));
            Console.WriteLine("");
            Console.WriteLine("Subtracting 2 from 22");
            Console.WriteLine(Solution.Run("subtracting", 22, 2));
            Console.WriteLine("");
            Console.WriteLine("Mulipying 5 by 3");
            Console.WriteLine(Solution.Run("multiplying", 5, 3));
            Console.WriteLine("");
            Console.WriteLine("Dividing 20 by 2");
            Console.WriteLine(Solution.Run("dividing", 20, 2));
            //Pause
            Console.ReadLine();
        }


    }
    public class Solution
    {
        public static string Run(string operation, int x, int y)
        {
            ICalculator calculator = new MyCalculator();

            switch (operation)
            {
                case "adding":
                    return calculator.Adding(x, y).ToString();
                case "subtracting":
                    return calculator.Subtracting(x, y).ToString();
                case "multiplying":
                    return calculator.Multiplying(x, y).ToString();
                case "dividing":
                    return calculator.Dividing(x, y).ToString();
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }
    }
}
