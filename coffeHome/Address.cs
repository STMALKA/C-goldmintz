using System;
using System.Collections.Generic;
using System.Text;

namespace coffeHome
{
    internal record Address
    {
        public required string streetName { get; init; }
        public required int streetNumber { get; init; }

    }
}
