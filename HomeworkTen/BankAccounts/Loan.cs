using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Enums;

namespace BankAccounts
{
    public class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            int numberOfMonthWithInterest = numberOfMonths - this.Customer == Customer.individuals ? 3 : 2;
            return numberOfMonthWithInterest < 0 ? 0 : numberOfMonthWithInterest * InterestRate;
        }
    }
}