using System;

namespace ConsoleApp13
{
    class counterStrike2
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int cnt = 0;
            int wins = 0;
            bool isWinner = false;
            while (command != "End of battle")
            {
                int distance = int.Parse(command);
                cnt++;
                if (energy >= distance)
                {
                    wins++;
                    energy -= distance;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    isWinner = true;

                    break;
                }
                
                if (cnt % 3 == 0)
                {
                    energy += cnt;
                }




                command = Console.ReadLine();
            }
            if (!isWinner)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
            }
        }
    }
}
