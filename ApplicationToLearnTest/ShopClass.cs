using System.Diagnostics;
using System;

namespace ApplicationToLearnTest
{
    public class ShopClass
    {
        public int Quantity { get; set; }
        public int Price { get; set; }

        public ShopClass(int quantity, int price)
        {
            Quantity = quantity;
            Price = price;
        }
        public double CreateDiscount()
        {
            if (Quantity <= 0 || Price <= 0)
            {
                throw new Exception();
            }
            if (Price < 10)
            {
                return 0;
            }

            if (Price < 30)
            {
                return Quantity > 0 ? Quantity * 0.1 : 0;
            }

            if (Price < 50)
            {
                return Quantity > 0 ? Quantity * 0.15 + 5 : 0;
            }

            if (Price < 100)
            {
                return Quantity > 0 ? Quantity * 0.2 + 10 : 0;
            }

            return Quantity > 0 ? Quantity * 0.25 + 15 : 0;
        }
    }
}
