using System;
using System.Collections.Generic;
using System.Text;

namespace coffeHome
{

    internal readonly struct PriceCalculator(double taxRate)
    {
        public  double CalculatePriceWithTax(double price)

            => price * ((100 + taxRate) / 100);
    }
}
