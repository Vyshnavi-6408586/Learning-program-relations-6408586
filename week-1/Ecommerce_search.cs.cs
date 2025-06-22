using System;
using System.Collections.Generic;

namespace EcommerceSearchApp
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product { ProductId = 101, ProductName = "Laptop", Category = "Electronics" },
                new Product { ProductId = 102, ProductName = "Phone", Category = "Electronics" },
                new Product { ProductId = 103, ProductName = "Shoes", Category = "Fashion" },
                new Product { ProductId = 104, ProductName = "Watch", Category = "Accessories" },
                new Product { ProductId = 105, ProductName = "Backpack", Category = "Travel" }
            };

            string searchTerm = "Laptop";

            int linearIndex = LinearSearch(products, searchTerm);
            Console.WriteLine($"Linear Search: '{searchTerm}' found at index {linearIndex}");

            Array.Sort(products, (x, y) => string.Compare(x.ProductName, y.ProductName, StringComparison.OrdinalIgnoreCase));

            int binaryIndex = BinarySearch(products, searchTerm);
            Console.WriteLine($"Binary Search: '{searchTerm}' found at index {binaryIndex}");

            Console.WriteLine("\n--- Analysis ---");
            Console.WriteLine("Linear Search Time Complexity: O(n)");
            Console.WriteLine("Binary Search Time Complexity: O(log n)");
        }

        public static int LinearSearch(Product[] products, string searchName)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ProductName.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(Product[] sortedProducts, string searchName)
        {
            return Array.BinarySearch(
                sortedProducts,
                new Product { ProductName = searchName },
                Comparer<Product>.Create((x, y) => string.Compare(x.ProductName, y.ProductName, StringComparison.OrdinalIgnoreCase))
            );
        }
    }
}