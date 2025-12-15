using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Exception
{
    public class BankAccount
    {
        private double balance;

        public BankAccount()
        {
            balance = 0.0;
        }

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new InsufficientFundException("Deposit amount must be positive.");
            }
            else
            {
                balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientFundException("Insufficient Balance. Withdraw process couldn`t be completed.");
            }
            else
            {
                balance -= amount;
            }

        }

    }
}
