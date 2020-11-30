using System;
using System.Linq;

namespace discription
{
    class arrayManipulator
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                String.Join(" ", arr);
            }
            

        }
    }
}

