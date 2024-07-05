using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial
{
    public static class Shared
    {
        public static void DisplayProducts(IDictionary<int,Product> products)
        {
            int columnWidth = products.Max(p => Math.Max(p.Value.Name.Length, Math.Max(p.Value.Price.ToString().Length, p.Value.Description.Length))) + 5; // Example of dynamic column width calculation

            string header = $"| {"Product Name".PadRight(columnWidth)} | {"Price".PadRight(columnWidth)} | {"Description".PadRight(columnWidth)} |";
            string separator = new string('-', header.Length);

            Console.WriteLine(separator);
            Console.WriteLine(header);
            Console.WriteLine(separator);

            foreach (Product product in products.Values)
            {
                string line = $"| {product.Name?.PadRight(columnWidth) ?? "N/A"} | {product.Price.ToString().PadRight(columnWidth)} | {product.Description?.PadRight(columnWidth) ?? "N/A"} |";
                Console.WriteLine(line);
            }

            Console.WriteLine(separator);
        }
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
