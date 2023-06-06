using System;
using System.Globalization;
using Composition.Entities;

namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Produto: ");
            string Name = Console.ReadLine();
            Console.Write("Preço: ");
            Double Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product product = new Product(Name, Price);

            Console.WriteLine(product.Name + ", R$ " + product.Price.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}