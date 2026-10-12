using System;
using System.Collections.Generic;
using System.Text;

namespace coffeHome
{
    internal record Product
    {
        public required string Name { get; init; }
        public required int Price { get; init; }
        public string? Description { get; init; }

     


    }

}
