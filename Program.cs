using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_midterm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer { Id = "000000000", Name = "Lilian", PhoneNumber = "050-1234567" };
            CheckingAccount acc1 = new CheckingAccount(1111, c1, 1000);
            acc1.Deposit(1500);
            acc1.Withdraw(500);
            acc1.PrintBalance();

            BankBranch branch = new BankBranch { BranchNumber = 101, Address = "hamehkar 10, Netanya" };
            branch.AddAccount(acc1);
            branch.PrintAccounts();
        }
    }
}
