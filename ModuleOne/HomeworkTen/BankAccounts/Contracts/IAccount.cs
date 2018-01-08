using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Enums;

namespace BankAccounts.Contracts
{
    interface IAccount
    {
        Customer Customer { get; }
        decimal Balance { get; }
        decimal InterestRate { get; }
        void Deposit(decimal moneyAmount);
        decimal CalculateInterest(int numberOfMonths);
    }
}
