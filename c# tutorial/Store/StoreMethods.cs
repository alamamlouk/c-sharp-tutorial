using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial
{
    public delegate void Notify();
    public partial class Store : IStore
    {
        public event Notify ProductAdded;
        

        protected virtual void OnProcessCompleted()
        {
            ProductAdded?.Invoke();
        }

        public Store(int Store_id, string Store_name)
        {
            this.Store_products = new Dictionary<int, Product>();
            this.Store_id = Store_id;
            this.Store_name = Store_name;
        }
        // Add product to the store by passing the product object
        public void AddProduct(Product product)
        {
            Store_products.Add(product.ProductId, product);
        }

        // add a product to the store using the console
        public void AddProductWithConsole()
        {
            int product_id;
            bool idExists;
            // check if the product id exists
            do
            {
                Console.WriteLine("Enter product Id :");
                product_id = int.Parse(Console.ReadLine());
                idExists = FindProductById(product_id);

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
            string product_discount = Console.ReadLine();
            Product product = new Product(product_id, product_name, product_discount, product_price);
            Store_products.Add(product_id, product);
            OnProcessCompleted();

        }

        // remove a product from the store
        public void RemoveProduct(int product_id)
        {

            if (FindProductById(Store_id))
            {

                Store_products.Remove(Store_products.First(p => p.Key == product_id));
            }
        }
        // find a product by id

        public bool FindProductById(int product_id)
        {
            return Store_products.Any(p => p.Key == product_id);
        }

        public void ExportProducts()
        {
            File.WriteAllLines(@"D:\products.txt", Store_products.Select(p => p.Value.toString()));

        }
    }
    
}
