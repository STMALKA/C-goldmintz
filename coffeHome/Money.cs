using System;
using System.Collections.Generic;
using System.Text;

namespace coffeHome
{
    internal readonly record struct Money
    {
        public required int Amount { get; init; }
        public required string Currency { get; init; }
            
    }
}
