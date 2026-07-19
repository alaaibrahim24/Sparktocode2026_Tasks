using System;

namespace OOPPart1Solution
{
    internal class BankAccount
    {
        public string AccountNumber;
        public string CustomerName;
        public double Balance;

        private List<string> transactions = new List<string>();

        public void Deposit(double amount)
        {
            Balance += amount;
            LogTransaction("Deposited: " + amount);
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                LogTransaction("Withdrawn: " + amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public void PrintInformation()
        {
            Console.WriteLine("Customer: " + CustomerName);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: " + Balance);
        }

        private void LogTransaction(string message)
        {
            transactions.Add(message);
        }
    }
}

