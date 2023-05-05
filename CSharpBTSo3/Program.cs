using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBTSo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[5];
            products[0] = new Book(1, "The Alchemist", 15.99);
            products[1] = new Book(2, "To Kill a Mockingbird", 10.99);
            products[2] = new Book(3, "Lord of the Flies", 12.99);
            products[3] = new Phone(4, "iPhone 12", 799.99);
            products[4] = new Phone(5, "Samsung Galaxy S21", 699.99);

            double totalBookTax = 0;
            double totalPhoneTax = 0;

            foreach (Product p in products)
            {
                if (p is Book)
                {
                    totalBookTax += p.computeTax();
                }
                else if (p is Phone)
                {
                    totalPhoneTax += p.computeTax();
                }
            }

            Console.WriteLine("Total tax on Books: $" + totalBookTax);
            Console.WriteLine("Total tax on Phones: $" + totalPhoneTax);
            Console.ReadLine();
        }
    }
}
