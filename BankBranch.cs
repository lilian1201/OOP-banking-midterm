using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_midterm
{
    public class BankBranch : IBankBranch
    {
        public int BranchNumber { get; set; }
        private string Address { get; set; }
        private CheckingAccount[] accounts = new CheckingAccount[20];
        private int accountCount = 0;
   public BankBranch(int branchNumber, string address)
        {
            this.BranchNumber = branchNumber;
            this.Address = address;
        }
        public void AddAccount(BankAccount account)
        {
            if (accountCount < 20)
            {
                CheckingAccount checking = (CheckingAccount)account;

                accounts[accountCount] = checking;
                accountCount++;
            }
            else
            {
                Console.WriteLine("Cant add more accounts.");
            }
        }
    public void PrintAccounts()
        {
            Console.WriteLine($"Accounts in Branch {BranchNumber}:");
            for (int i = 0; i < accountCount; i++)
            {
                accounts[i].PrintBalance();
            }
        }



    }
}
