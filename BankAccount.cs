using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_midterm
{
    public class BankAccount
    {
        protected int accountNumber;
        protected double balance;
        protected Customer customerOwner;

        public BankAccount(int accountNumber, Customer customer)
        {
            this.accountNumber = accountNumber;
            this.customerOwner = customer;
            this.balance = 0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }
        //overload
        public void Deposit(double amount, DateTime date)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount} on {date.ToShortDateString()}");
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Not enough balance to withdraw.");
            }

        }


        public virtual void PrintBalance()
        {
            Console.WriteLine($"Account {accountNumber} Balance: {balance}");
        }
    }
}
