using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial
{
    internal class Store : IStore

    {
        public int id {  get; set; }
        public string name { get; set; }
        public string owner {  get; set; }
        public List<Product> products { get; set; }
        public Store()
        {
            products = new List<Product>();
        }

        public void addProduct(Product product)
        {
            products.Add(product);
        }

        public void displayProducts()
        {
            const int nameWidth = 20;
            const int priceWidth = 10;
            const int descWidth = 30;

            string header = $"| {"Product Name".PadRight(nameWidth)} | {"Price".PadRight(priceWidth)} | {"Description".PadRight(descWidth)} |";
            string separator = new string('-', header.Length);

            Console.WriteLine(separator);
            Console.WriteLine(header);
            Console.WriteLine(separator);

            foreach (Product product in products)
            {
                string line = $"| {product.Name.PadRight(nameWidth)} | {product.Price.ToString().PadRight(priceWidth)} | {product.Description.PadRight(descWidth)} |";
                Console.WriteLine(line);
            }

            Console.WriteLine(separator);
        }

        public void removeProduct(Product product)
        {
            products.Remove(product);
        }

        public Product updateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
