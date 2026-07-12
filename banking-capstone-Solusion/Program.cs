using System;
using System.Collections.Generic;

namespace banking_capstone_Solution
{
    internal class Program
    {
        // Shared Lists
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts");
                Console.WriteLine("7. Search Customer");
                Console.WriteLine("8. Exit");

                Console.Write("Choose an option: ");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;

                    case 2:
                        DepositMoney();
                        break;

                    case 3:
                        WithdrawMoney();
                        break;

                    case 4:
                        ShowBalance();
                        break;

                    case 5:
                        TransferAmount();
                        break;

                    case 6:
                        ListAllAccounts();
                        break;

                    case 7:
                        SearchCustomer();
                        break;

                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for using Spark Bank.");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
        }

        static void AddAccount()
        {
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Account Number: ");
            string account = Console.ReadLine();

            if (accountNumbers.Contains(account))
            {
                Console.WriteLine("Account already exists.");
                return;
            }

            Console.Write("Enter Starting Balance: ");
            double balance = double.Parse(Console.ReadLine());

            if (balance < 0)
            {
                Console.WriteLine("Balance cannot be negative.");
                return;
            }

            customerNames.Add(name);
            accountNumbers.Add(account);
            balances.Add(balance);

            Console.WriteLine("Account created successfully.");
        }

        static void DepositMoney()
        {

        }

        static void WithdrawMoney()
        {

        }

        static void ShowBalance()
        {

        }

        static void TransferAmount()
        {

        }

        static void ListAllAccounts()
        {

        }

        static void SearchCustomer()
        {

        }
    }
}