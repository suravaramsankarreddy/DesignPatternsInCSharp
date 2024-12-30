using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.OppPrinciples.Encapsulation
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Deposit Amount Must be Positive");
            }
            this.balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Withdraw Amount Must be Positive");
            }

            if(amount > balance)
            {
                throw new ArgumentException("Insufficiant Funds");
            }

            this.balance -= amount;
        }
    }
}