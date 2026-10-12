using System;
using System.Collections.Generic;
using System.Text;

namespace coffeHome
{
    internal class Till
    {
        public int Id { get; init; }
        public int Lest { get; private set; }

        public void pushMoney(int amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Amount cannot be negative");
            }
            Lest += amount;
        }
        public void pullMoney(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount cannot be negative");
            }
            if (Lest < amount)
            {
                throw new InvalidOperationException("Not enough money in the till");
            }
            Lest -= amount;
        }
    }
}
