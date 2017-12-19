using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Enums;
using BankAccounts.Contracts;

namespace BankAccounts
{
    public class Deposit : Account, IDeposit
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public decimal WithDraw(decimal moneyAmount)
        {
            if (moneyAmount < 0 || moneyAmount > this.Balance)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.Balance = this.Balance - moneyAmount;
            return moneyAmount;
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            return this.Balance < 1000 ? 0 : this.InterestRate * numberOfMonths;
        }
    }
}