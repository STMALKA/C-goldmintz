using System;
using System.Collections.Generic;
using System.Text;

namespace coffeHome
{
    internal record Customer
    {
        public string Name { get; set=> field = string.IsNullOrWhiteSpace(value) || value.Contains(' ') ? throw new ArgumentException("Name cannot contain spaces"): value; }
        public int Age { get; set=> field = value >= 0 && value<=120 ? value : throw new ArgumentException("Age cannot be negative"); }

    }
}
