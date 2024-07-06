using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// the Customer class that extend  from the person class
namespace c__tutorial
{
    public class Customer : Person
    {
        public string CreditCard { get; set; }
        public IList<Product> ProductBought { get; set; }

        public Customer(int id, string Name, string Address, string Email, string Phone, string CreditCard) : base(id, Name, Address, Email, Phone)
        {
            this.CreditCard = CreditCard;
        }
     
 
    }
}
