using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// the person class 
namespace c__tutorial
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Person(int id, string Name, string Address, string Email, string Phone)
        {
            this.Id = id;
            this.Name = Name;
            this.Address = Address;
            this.Email = Email;
            this.Phone = Phone;
        }
        

    }
}
