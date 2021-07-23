using System;
using System.Collections.Generic;
using System.Globalization;
using TaxPayer.Entities;

namespace TaxPayer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayers> list = new List<TaxPayers>();

            Console.Write("Enter the numbers of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company? (i/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, health));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            foreach (TaxPayers tax in list)
            {
                double tp = tax.Tax();
                Console.WriteLine(tax.Name + ": $ " + tp.ToString("F2", CultureInfo.InvariantCulture));
                sum += tp;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
