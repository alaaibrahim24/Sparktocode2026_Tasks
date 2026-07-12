using System;

namespace banking_capstone_Solution
{
    internal class Product
    {
        // Fields
        private string productName;
        private double price;
        private int stock;

        // Properties
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        // Constructor
        public Product(string productName, double price, int stock)
        {
            this.productName = productName;
            this.price = price;
            this.stock = stock;
        }

        // Methods
        public void PrintDetails()
        {
            Console.WriteLine("Product: " + productName);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Stock: " + stock);
        }

        public void Restock(int quantity)
        {
            if (quantity > 0)
            {
                stock += quantity;
            }
        }
    }
}