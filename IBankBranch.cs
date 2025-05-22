using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_midterm
{
    public interface IBankBranch
    {
        void AddAccount(BankAccount account);
        void PrintAccounts();
    }
}
