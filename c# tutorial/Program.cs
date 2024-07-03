using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Store store = new Store();

            store.id = 1;

            store.owner = "Ala";

            store.name = "Play tech";

            Product product = new Product(1,"Lenovo Ipad 570","I5 Gen10 8Go RAM ",2500.0f);

            Product product2 = new Product(2, "MSI thin  GF 63", "I5 Gen12 24Go RAM ", 6500);

            Product product3 = new Product(3, "MAC  ", "M3 8 Go ", 2500.0f);

            Product product4 = new Product(4, "Hp omen desktop", "I7 Gen 12 16GO ", 70000.0f);

            store.addProduct(product);

            store.addProduct(product2);

            store.addProduct(product3);

            store.addProduct(product4);

            store.displayProducts();

            store.removeProduct(product);

            store.displayProducts();

            store.addProductWithConsole();

            store.displayProducts();

        }
    }
}
