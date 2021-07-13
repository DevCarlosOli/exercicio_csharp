using System;
using System.Globalization;
using System.Collections.Generic;
using TagProgram.Entities;

namespace TagProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("--> TAG PRICE <--");
            Console.WriteLine();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, Used or Imported - [c / u / i]: ");
                char choice = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(choice == 'c')
                {
                    products.Add(new Product(name, price));                   
                }
                else if(choice == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Custom Fee: ");
                    double customfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customfee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            foreach(Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
