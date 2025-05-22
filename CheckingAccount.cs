using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_midterm
{
    public class CheckingAccount : BankAccount
    {
        private double overdraftLimit;
        public CheckingAccount(int accountNumber, Customer customer, double overdraftLimit) : base(accountNumber, customer)
        {
            this.overdraftLimit = overdraftLimit;
        }
        public override void Withdraw(double amount)
        {
            if (amount > 0 && (balance + overdraftLimit) >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Withdrawal denied");
            }
        }
        public override void PrintBalance()
        {
            Console.WriteLine($"Account {accountNumber} Balance: {balance}, Overdraft Limit: {overdraftLimit}");
        }
    }
}
    