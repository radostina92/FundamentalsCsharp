using System;
using System.Linq;

namespace largestThreeNumbers
{
    class largestThreeNumbers
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] sorted = arr.OrderByDescending(x => x).ToArray();

            if (sorted.Length >= 3)
            {
                Console.WriteLine(string.Join(" ",sorted.Take(3)));
            }
            else
            {
                Console.WriteLine(string.Join(" ",sorted));
            }
        }
    }
}
