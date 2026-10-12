using System;
using System.Collections.Generic;
using System.Text;

namespace coffeHome
{
    internal record OrderItem

    {
        public Product product { get; set; }
        public int quantity { get; set; }

        public int Sum()
        {
            return product.Price * quantity;
        }
    }
}
