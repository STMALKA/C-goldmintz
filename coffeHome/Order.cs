using System;
using System.Collections.Generic;
using System.Text;

namespace coffeHome
{
    internal class Order
    {
        public int Id { get; init; }

        public Customer Customer { get; set; }

        public List<Product> Products { get; private set; } = new List<Product>();
        public string statuse { get; private set; } = "new";

        public void pay()
        {
            if (statuse == "paied")
            {
                throw new InvalidOperationException("Order is already paied.");
            }
            statuse = "paied";
        }
        public void addProduct(Product product)
        {
            if(statuse == "paied")
            {
                throw new InvalidOperationException("Cannot add product to a paied order.");
            }
            Products.Add(product);
        }
        public int sumPrice()
        {
            int sum = 0;
            foreach (var product in Products)
            {
                sum += product.Price;
            }
            return sum;
        }
    }
}
