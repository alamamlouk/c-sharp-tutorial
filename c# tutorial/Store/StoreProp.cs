using c__tutorial.Users;
using System;
using System.Collections.Generic;
using System.Linq;
// the store class that implement the IStore interface and initialize the store products
namespace c__tutorial
{
    public partial class Store 

    {
        public int Store_id { get; set; }
        public string Store_name { get; set; }
        public Employee StoreOwner;
        public IDictionary<int, Product> Store_products { get; set; }

        public Employee Owner
        {

            get { return StoreOwner; }
            set
            {
                // check if the employee is an owner
                try{if (value.Position == Position.Owner)
                    {
                        StoreOwner = value;
                        Console.WriteLine("Owner set Welcome Sir {0}", StoreOwner.Name);
                    }
                    else
                    {
                        throw new Exception("you must be an owner to have a store");
                    } }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
       






    }
}
