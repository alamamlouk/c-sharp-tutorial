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

        public void addProductWithConsole()
        {
            int product_id;
            bool idExists;
            do
            {
                Console.WriteLine("Enter product Id :");
                product_id = int.Parse(Console.ReadLine());
                idExists = productExist(product_id);

                if (idExists)
                {
                    Console.WriteLine($"Product with ID {product_id} already exists.");
                }
            }
            while (idExists);

            Console.WriteLine("Enter Name :");
            string product_name = Console.ReadLine();
            Console.WriteLine("Enter Price   :");
            float product_price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter description Id :");
            string product_desc = Console.ReadLine();
            Product product = new Product(product_id, product_name, product_desc, product_price);
            products.Add(product);
        }

        public void removeProductById(int id)
        {
            throw new NotImplementedException();
        }

        public bool productExist(int productId)
        {
            return products.Any(p => p.Id == productId);
        }
    }
}
