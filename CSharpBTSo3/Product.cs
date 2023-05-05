using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBTSo3
{
    abstract class Product
    {
        protected int productId;
        protected string productName;
        protected double productPrice;

        public Product(int id, string name, double price)
        {
            productId = id;
            productName = name;
            productPrice = price;
        }

        public abstract double computeTax();
    }
}
