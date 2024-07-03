using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial
{
    internal interface IStore
    {
        void addProduct(Product product);
        void removeProduct(Product product);
        Product updateProduct(Product product);
        void displayProducts();
    }
}
