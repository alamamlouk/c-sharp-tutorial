using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// this interface contain the methods that the store should implement
namespace c__tutorial
{
    internal interface IStore
    {
        void AddProduct(Product product);
        void AddProductWithConsole();
        void RemoveProduct(int id);
        bool FindProductById(int productId);
        void ExportProducts();
    }
}
