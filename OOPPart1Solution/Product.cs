using System;

namespace OOPPart1Solution
{
    internal class Product
    {
        public string Name;
        public int Quantity;
        public double Price;

        public void Restock(int amount)
        {
            Quantity += amount;
        }

        public void ApplyDiscount(double percentage)
        {
            if (percentage >= 0 && percentage <= 100)
            {
                Price = Price - (Price * percentage / 100);
            }
            else
            {
                Console.WriteLine("Invalid discount percentage.");
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine("Product: " + Name);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Price: " + Price);
        }
    }
}