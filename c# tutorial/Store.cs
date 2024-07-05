using System;
using System.Collections.Generic;
using System.Linq;

namespace c__tutorial
{
    public  class Store : IStore

    {
        public int id { get; set; }
        public string name { get; set; }
        public string owner { get; set; }
        public IDictionary<int, Product> products { get; set; }
        public Store()
        {
            products = new Dictionary<int, Product>();
        }

        public void addProduct(Product product)
        {
            products.Add(product.Id, product);
        }
        public void updateProduct(Product product)
        {
            Console.WriteLine("Update Product");
        }

        public void addProductWithConsole()
        {
            int product_id;
            bool idExists;
            do
            {
                Console.WriteLine("Enter product Id :");
                product_id = int.Parse(Console.ReadLine());
                idExists = findProductById(product_id);

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
            products.Add(product_id, product);
        }


        public void removeProduct(int product_id)
        {
            if (findProductById(id))
            {
                products.Remove(products.First(p => p.Key == product_id));
            }
        }

        public bool findProductById(int product_id)
        {
            return products.Any(p => p.Key == product_id);
        }






    }
}
