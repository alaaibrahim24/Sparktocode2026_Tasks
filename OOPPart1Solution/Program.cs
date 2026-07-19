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
                Console.WriteLine("6. Register Student");
                Console.WriteLine("7. Compare Two Account Balances");
                Console.WriteLine("8. Restock Product");
                Console.WriteLine("9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("20. Exit");

                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        account1.PrintInformation();
                        break;

                    case 2:
                        Console.Write("Enter new address: ");
                        string address = Console.ReadLine();
                        student1.UpdateAddress(address);
                        student1.PrintInformation();
                        break;

                    case 3:
                        Console.Write("Deposit amount: ");
                        double dep = double.Parse(Console.ReadLine());
                        account1.Deposit(dep);
                        account1.PrintInformation();
                        break;

                    case 4:
                        Console.Write("Withdraw amount: ");
                        double with = double.Parse(Console.ReadLine());
                        account1.Withdraw(with);
                        account1.PrintInformation();
                        break;

                    case 5:
                        product1.PrintDetails();
                        break;

                    case 6:
                        Console.Write("Enter Student Name: ");
                        student2.Name = Console.ReadLine();

                        Console.Write("Enter Student ID: ");
                        student2.Id = int.Parse(Console.ReadLine());

                        Console.Write("Enter Student Address: ");
                        student2.Address = Console.ReadLine();

                        Console.WriteLine("Student Registered Successfully.");
                        student2.PrintInformation();
                        break;


                    case 7:
                        if (account1.Balance > account2.Balance)
                        {
                            Console.WriteLine(account1.CustomerName + " has the higher balance.");
                        }
                        else if (account2.Balance > account1.Balance)
                        {
                            Console.WriteLine(account2.CustomerName + " has the higher balance.");
                        }
                        else
                        {
                            Console.WriteLine("Both accounts have the same balance.");
                        }
                        break;

                    case 8:
                        Console.Write("Enter quantity to add: ");
                        int quantity = int.Parse(Console.ReadLine());

                        product1.Restock(quantity);

                        Console.WriteLine("Stock Updated Successfully.");
                        product1.PrintDetails();
                        break;

                    case 9:
                        Console.Write("Enter amount to transfer: ");
                        double amount = double.Parse(Console.ReadLine());

                        if (account1.Balance >= amount)
                        {
                            account1.Withdraw(amount);
                            account2.Deposit(amount);

                            Console.WriteLine("Transfer completed successfully.");

                            Console.WriteLine("\nAccount 1:");
                            account1.PrintInformation();

                            Console.WriteLine("\nAccount 2:");
                            account2.PrintInformation();
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance.");
                        }
                        break;

                    case 10:
                        Console.Write("Enter new grade (0-100): ");
                        double grade = double.Parse(Console.ReadLine());

                        student1.UpdateGrade(grade);

                        student1.PrintInformation();
                        break;

                    case 11:
                        Console.WriteLine("===== Student Report =====");
                        Console.WriteLine("Name: " + student1.Name);
                        Console.WriteLine("Address: " + student1.Address);

                        if (student1.Grade >= 60)
                        {
                            Console.WriteLine("Result: PASS");
                        }
                        else
                        {
                            Console.WriteLine("Result: FAIL");
                        }

                        break;


                    case 20:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}