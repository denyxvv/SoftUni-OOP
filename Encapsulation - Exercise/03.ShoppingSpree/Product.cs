﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace _03.ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty");
                name = value;
            }
        }

        public decimal Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Money cannot be negative");
                cost = value;
            }
        }

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public override string ToString() => this.Name;
    }
}
