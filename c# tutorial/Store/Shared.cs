using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// this class contain the shared methods that can be used in the store and the customer
namespace c__tutorial
{
    public static class Shared
    {
        // this function will display the products in a table format 
        public static void DisplayProducts(IDictionary<int,Product> products)
        {
            // get the max length of the product name, price and description
            int columnWidth = products.Max(p => Math.Max(p.Value.ProductName.Length, Math.Max(p.Value.ProductPrice.ToString().Length, p.Value.ProductDescription.Length))) + 5; // Example of dynamic column width calculation
            // create the header of the table
            string header = $"| {"Product Name".PadRight(columnWidth)} | {"Price".PadRight(columnWidth)} | {"Description".PadRight(columnWidth)} |";
            // create the separator of the table
            string separator = new string('-', header.Length);
            // display the header and the separator
            Console.WriteLine(separator);
            Console.WriteLine(header);
            Console.WriteLine(separator);
            // loop through the products and display them in the table
            foreach (Product product in products.Values)
            {
                // create the line of the table
                string line = $"| {product.ProductName?.PadRight(columnWidth) ?? "N/A"} | {product.ProductPrice.ToString().PadRight(columnWidth)} | {product.ProductDescription?.PadRight(columnWidth) ?? "N/A"} |";
                Console.WriteLine(line);
            }

            Console.WriteLine(separator);
        }

        // Display the choices that the user can choose from
        public static void DisplayChoices()
        {
            Console.WriteLine("1- Display products");
            Console.WriteLine("2- Add product");
            Console.WriteLine("3- Remove product");
            Console.WriteLine("4- Update product");
            Console.WriteLine("5- Exit");
        }
    }
}
