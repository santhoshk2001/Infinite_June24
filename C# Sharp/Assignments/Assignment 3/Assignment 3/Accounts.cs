using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    using System;

    class Accounts
    {
        private string accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;

        public Accounts(string accountNo, string customerName, string accountType)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.balance = 0;
        }

        public void UpdateBalance(char transactionType, double amount)
        {
            this.transactionType = transactionType;
            this.amount = amount;

            if (transactionType == 'D')
            {
                Credit(amount);
            }
            else if (transactionType == 'W')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type!");
            }
        }

        private void Credit(double amount)
        {
            this.balance += amount;
        }

        private void Debit(double amount)
        {
            if (amount <= balance)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }

        public void ShowData()
        {
            Console.WriteLine($"Account Number: {accountNo}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Balance: {balance}");
        }

        public static void Main()
        {
            Accounts account1 = new Accounts("ACC001", "Santhosh K", "Savings");

            account1.UpdateBalance('D', 1000);  // Deposit 1000
            account1.UpdateBalance('W', 500);   // Withdraw 500

            account1.ShowData();

            Console.ReadLine();
        }
    }

}
