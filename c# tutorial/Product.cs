using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial
{
    internal class Product  
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public Product(int id, string Name, string Description,float Price)
        {
            this.Id = id;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
        }
    }
}
