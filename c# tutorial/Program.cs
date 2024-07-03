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
            Product product = new Product(1,"Lenovo Ipad 570","I5 Gen10 8GB RAM ",2500.0f);
            store.addProduct(product);
            store.displayProducts();
        }
    }
}
