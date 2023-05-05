using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBTSo3
{
    internal class Book : Product
    {
        public Book(int id, string name, double price) : base(id, name, price)
        {
        }

        public override double computeTax()
        {
            return productPrice * 5 / 100;
        }
    }
}
