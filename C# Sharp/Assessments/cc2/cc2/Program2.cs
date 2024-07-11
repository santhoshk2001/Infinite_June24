using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc2
{
    class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Products(int productId, string productName, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            List<Products> productList = new List<Products>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for product {i + 1}:");

                Console.Write("Product ID: ");
                int productId = int.Parse(Console.ReadLine());

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                double price;
                while (!double.TryParse(Console.ReadLine(), out price))
                {
                    Console.Write("Invalid input. Please enter a valid price: ");
                }

                productList.Add(new Products(productId, productName, price));
            }

            BubbleSort(productList);

            Console.WriteLine("\nSorted Products by Price:");
            foreach (var product in productList)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.Price}");
            }

            Console.Read();
        }

        static void BubbleSort(List<Products> productList)
        {
            int n = productList.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (productList[j].Price > productList[j + 1].Price)
                    {
                        Products temp = productList[j];
                        productList[j] = productList[j + 1];
                        productList[j + 1] = temp;
                    }
                }
            }
        }
    }
}
