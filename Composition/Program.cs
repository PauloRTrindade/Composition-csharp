using System.Globalization;
using Composition.Entities;
using Composition.Entities.Enums;

namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime BirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, os, new Client(Name, Email, BirthDate), new List<OrderItem>());

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                OrderItem item = new OrderItem();
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product Name: ");
                string ProductName = Console.ReadLine();
                Console.Write("Product Price: ");
                double ProductPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int Quantity = int.Parse(Console.ReadLine());
                order.AddItem(new OrderItem(Quantity, ProductPrice, new Product(ProductName, ProductPrice)));
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}