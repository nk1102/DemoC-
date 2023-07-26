using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoC_
{
    public  class OOP
    {
        private string accountNumber;
        private string accountHolder;
        private decimal balance;


        public OOP(string accountNumber, string accountHolder, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount. Deposit amount must be positive.");
            }
            else
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited {amount:C}. Current balance: {balance:C}");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount. Withdrawal amount must be positive.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient funds. Unable to withdraw.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Successfully withdrew {amount:C}. Current balance: {balance:C}");
            }
        }


        public void CheckBalance()
        {
            Console.WriteLine($"Account Holder: {accountHolder}");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Current Balance: {balance:C}");
        }
    }
}
