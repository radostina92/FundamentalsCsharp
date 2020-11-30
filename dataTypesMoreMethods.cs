using System;

namespace dataTypesMoreMethods
{
    class dataTypesMoreMethods
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            if (input == "int")
            {
                int num = int.Parse(output);
                int result = IntInput(input, num);
                Console.WriteLine(result);
               
            }
            else if (input == "real")
            {
                double number = double.Parse(output);
                double result =  DoubleInput(input, number);
                Console.WriteLine($"{result:f2}");
            }
            else if (input == "string")
            {
                Console.WriteLine($"${output}$");
            }
            
        }

        private static int IntInput(string input, int num)
        {
            return num * 2;
        }
        private static double DoubleInput(string input, double num)
        {
            return num * 1.5;
        }
        private static string StringInput(string input, string output)
        {
            return output;
        }
    }
}
