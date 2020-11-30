using System;

namespace beerKegs2
{
    class beerKegs2
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string currentName = "";
            double biggestVolume = 0;

            for (int i = 0; i < input; i++)
            {
                string kegName = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int heigth = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius , 2) * heigth;

                if (volume > biggestVolume)
                {
                    currentName = kegName;
                    biggestVolume = volume;
                }
            }
            Console.WriteLine(currentName);
        }
    }
}
