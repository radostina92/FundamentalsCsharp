using System;

namespace computerStore
{
    class computerStore
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double totalPriceWithoutTax = 0;
            double tax = 0;
            bool check = false;

            while (command != "special" && command != "regular")
            {
                double price = double.Parse(command);

                    if (price < 0)
                    {

                        Console.WriteLine("Invalid price!");
                        command = Console.ReadLine();
                        if (command == "special" || command == "regular")
                        {
                            check = true;
                            break;
                        }
                       
                    continue;
                    }
                

                if (check)
                {
                    break;
                }

                totalPriceWithoutTax += price;
                tax += price * 0.2;

                command = Console.ReadLine();
            }

            double totalPrice = totalPriceWithoutTax + tax;

            if (command == "special")
            {
                totalPrice = totalPrice - (totalPrice * 0.10);
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithoutTax:f2}$");
                Console.WriteLine($"Taxes: {tax:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }

        }

    }
}
