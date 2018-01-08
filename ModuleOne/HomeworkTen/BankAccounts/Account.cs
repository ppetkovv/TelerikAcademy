using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Enums;

namespace BankAccounts
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get { return this.customer; } private set { this.customer = value; } }
        public decimal Balance { get { return this.balance; } protected set { if (balance < 0 || balance > 1000000) { throw new ArgumentOutOfRangeException(); } this.balance = value; } }
        public decimal InterestRate { get { return this.interestRate; } private set { if (value < 1.5m || value > 8.0m) { throw new ArgumentOutOfRangeException(); } this.interestRate = value; } }

        public void Deposit(decimal moneyAmmount)
        {
            if (moneyAmmount < 0)
                throw new ArgumentOutOfRangeException();
            this.balance += moneyAmmount;
        }

        public abstract decimal CalculateInterest(int numberOfMonths);
    }
}