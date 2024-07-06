using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// the employee class that extend from person class
namespace c__tutorial.Users
{
    public class Employee:Person
    {
        public Position Position { get; set; }
        public float Salary { get; set; }
        public Employee(int id, string Name, string Address, string Email, string Phone, Position Position, float Salary):base(id, Name, Address, Email, Phone)
        {
            this.Position = Position;
            this.Salary = Salary;
        }
        
    }
}
