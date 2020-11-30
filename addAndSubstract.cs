using System;

namespace addAndSubstract
{
    class addAndSubstract
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            //int sum = first + second;
            //int newSum = sum - third;
           // Console.WriteLine(newSum);


            int sum = SumOfIntegers(first, second);
            int thirdNum = SubtractIntegers(third);

            int substract = sum - thirdNum;
            Console.WriteLine(substract);
        }

        static int SumOfIntegers(int first, int second)
        {
            return first + second;
        }

        static int SubtractIntegers(int third)
        {
            return third;   
        }


     
    }
}
