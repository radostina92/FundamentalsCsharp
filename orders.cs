using System;
using System.Collections.Generic;
using System.Linq;

namespace orders
{
    class orders
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> product = new Dictionary<string, double>();

            Dictionary<string, long> productQuantity = new Dictionary<string, long>();

            string productInput = string.Empty;


            while ((productInput = Console.ReadLine()) != "buy")
            {
                string[] arguments = productInput
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = arguments[0];
                double price = double.Parse(arguments[1]);
                int quantity = int.Parse(arguments[2]);

                if (!productQuantity.ContainsKey(name))
                {
                    productQuantity[name] = 0;
                    product[name] = 0;
                }

                productQuantity[name] += quantity;
                product[name] = price;
            }

            foreach (var item in product)
            {
                string name = item.Key;
                double price = item.Value;
                long quantity = productQuantity[name];
                double totalPrice = quantity * price;

                Console.WriteLine($"{name} -> {totalPrice:f2}");
            }
        }

    

       
    }
}
