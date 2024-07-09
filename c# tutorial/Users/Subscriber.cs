﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial.Users
{
    public  class Subscriber
    {
        public void Subscribe(Store process)
        {
            process.ProductAdded += OnProcessCompleted;
        }

        private void OnProcessCompleted()
        {
            Console.WriteLine("Subcribers: Product added");
        }
    }
}
