using ExComparison.Entities;

namespace System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Notebook", 1200.00));
            products.Add(new Product("Tablet", 450.00));

            //products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); // Sort por Name
            // ou
            products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price)); // Sort por Price.

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}