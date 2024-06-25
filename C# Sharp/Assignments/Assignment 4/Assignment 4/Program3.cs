using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException() : base("Insufficient balance for the requested withdrawal.")
        {
        }

        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }

    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal initialBalance = 0)
        {
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance is {balance}.");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > balance)
            {
                throw new InsufficientBalanceException($"Cannot withdraw {amount}. Current balance is {balance}.");
            }
            balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New balance is {balance}.");
        }

        public decimal GetBalance()
        {
            Console.WriteLine($"Current balance is {balance}.");
            return balance;
        }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000); 

            try
            {
                account.Deposit(500);
                account.Withdraw(300);
                account.GetBalance();
                account.Withdraw(1500); // This will throw InsufficientBalanceException
            }
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred: " + e.Message);
            }
            Console.ReadLine();
        }
    }
}
