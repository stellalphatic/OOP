using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class Product
    {
        public string name;
        public string category;
        public int price;

        public float calculateTax()
        {
            return (float)price * 5 / 10;
        }
    }
    public class Customer
    {
        public string customerName;
        public string customerContact;
        public string customerAddress;
        public List<Product> products = new List<Product>();
        public List<Product> getAllProducts()
        {
            return products;
        }
        public void addProduct(Product p)
        {
            products.Add(p);
        }
    }
}
