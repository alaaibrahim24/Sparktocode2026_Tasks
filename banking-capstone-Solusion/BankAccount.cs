namespace banking_capstone_Solution
{
    internal class BankAccount
    {
        // Fields
        private string accountNumber;
        private string customerName;
        private double balance;

        // Properties
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Constructor
        public BankAccount(string accountNumber, string customerName, double balance)
        {
            this.accountNumber = accountNumber;
            this.customerName = customerName;
            this.balance = balance;
        }

        // Methods
        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Balance: " + balance);
        }
    }
}