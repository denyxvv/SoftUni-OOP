using System;
using System.Collections.Generic;

namespace _03.ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty");
                name = value;
            }
        }

        public decimal Money
        {
            get { return this.money; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Bag
        {
            get { return bag.AsReadOnly(); }
        }

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            this.bag = new List<Product>();
        }

        public void BuyProduct(Product product)
        {
            if (this.money >= product.Cost)
            {
                Console.WriteLine($"{this.Name} bought {product}");
                this.money -= product.Cost;
                this.bag.Add(product);
            }
            else
                Console.WriteLine($"{this.Name} can't afford {product}");
        }
    }
}
