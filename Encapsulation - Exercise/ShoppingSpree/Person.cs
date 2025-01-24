using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private readonly List<Product> products;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            products = new List<Product>();
            Products = products.AsReadOnly();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name cannot be empty");
                else name = value;
            }
        }

        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Money cannot be negative");
                else money = value;
            }
        }

        public IReadOnlyCollection<Product> Products { get; }

        public bool Purchase(Product product)
        {
            if(product.Cost>Money)
            {
                return false;
            }
            else
            {
                products.Add(product);
                Money-=product.Cost;
                return true;
            }
        }
    }
}
