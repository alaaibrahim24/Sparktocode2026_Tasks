using System;

namespace OOPPart1Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bank Accounts
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount();

            // Students
            Student student1 = new Student();
            Student student2 = new Student();

            // Products
            Product product1 = new Product();
            Product product2 = new Product();

            // Sample Data
            account1.AccountNumber = "A100";
            account1.CustomerName = "Alaa";
            account1.Deposit(500);

            account2.AccountNumber = "A200";
            account2.CustomerName = "Sara";
            account2.Deposit(800);

            student1.Name = "Ali";
            student1.Id = 1;
            student1.Address = "Muscat";

            student2.Name = "Ahmed";
            student2.Id = 2;
            student2.Address = "Sohar";

            product1.Name = "Laptop";
            product1.Price = 350;
            product1.Quantity = 5;

            product2.Name = "Mouse";
            product2.Price = 10;
            product2.Quantity = 20;

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n==  MENU == ");
                Console.WriteLine("1. View Account Details");
                Console.WriteLine("2. Update Student Address");
                Console.WriteLine("3. Make Deposit");
                Console.WriteLine("4. Make Withdrawal");
                Console.WriteLine("5. View Product Details");
                Console.WriteLine("20. Exit");

                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        account1.PrintInformation();
                        break;

                }
            }
        }
    }
}