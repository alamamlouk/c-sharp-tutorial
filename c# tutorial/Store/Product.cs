using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// the product class 
namespace c__tutorial
{
    public class Product  
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public float ProductPrice { get; set; }
        public Product(int id, string Name, string Description,float Price)
        {
            this.ProductId = id;
            this.ProductName = Name;
            this.ProductDescription = Description;
            this.ProductPrice = Price;
        }
        public Product()
        {
               
        }
        public string toString()
        {
            return $"Product ID : {ProductId} \n Product Name : {ProductName} \n Product Description : {ProductDescription} \n Product Price : {ProductPrice}";
        }
    }
}
