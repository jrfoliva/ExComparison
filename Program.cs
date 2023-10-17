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

            // Este método implementa delegate e neste caso passamos uma
            // referência para o método estático CompareProducts, que fará a comparação pela propriedade Name.
            products.Sort(CompareProducts);

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }

        // Método implementado, neste caso não será necessário a alteração da classe Product
        // pois iremos delegar ao método sort da lista.
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}