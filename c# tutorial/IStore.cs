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
        void addProductWithConsole();
        void removeProduct(Product product);
        void removeProductById(int id);
        Product updateProduct(Product product);
        void displayProducts();
        bool productExist(int productId);
    }
}
