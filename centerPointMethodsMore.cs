using System;

namespace centerPointMethodsMore
{
    class centerPointMethodsMore
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double result1 = TwoPoints(x1, y1);
            double result2 = TwoPoints2(x2, y2);
            if (result1 > result2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (result2 > result1 || result1 == result2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }

        }

      

        private static double TwoPoints2(double x2, double y2)
        {
            double secound = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));
            return secound;
            
        }

        private static double TwoPoints(double x1, double y1)
        {
            double first = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            return first;
        }
    }
}
