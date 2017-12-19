using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Enums;

namespace BankAccounts
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            bool isForCompanies = this.Customer == Customer.companies;
            if (isForCompanies)
            {
                if (numberOfMonths <= 12)
                {
                    return (this.InterestRate * numberOfMonths) / 2;
                }
                else
                {
                    decimal wholeInterest = (this.InterestRate * 12) / 2;
                    wholeInterest += (numberOfMonths - 12) * this.InterestRate;
                    return wholeInterest;
                }
            }
            else
            {
                return numberOfMonths - 6 <= 0 ? 0 : (numberOfMonths - 6) * this.InterestRate;
            }
        }
    }
}