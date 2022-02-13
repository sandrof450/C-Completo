using System.Globalization;
using Exercicio2.Entities;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine().ToLower());

                if(typeProduct == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product p = new Product(name, price);

                    list.Add(p);
                }

                else if(typeProduct == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Manufacture Date: ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    Product p = new UsedProduct(name, price, manufactureDate);

                    list.Add(p);
                }

                else if(typeProduct == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Custims fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product p = new ImportProduct(name, price, customsFee);

                    list.Add(p);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            foreach(Product p in list)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }

}