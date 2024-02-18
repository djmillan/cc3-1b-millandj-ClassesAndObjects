using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string owner, decimal initialBalance, decimal creditLimit) : base(owner, initialBalance, -creditLimit)
        {
        }

        public override void PerformMonthEndTransactions()
        {
            if(Balance < 0)
            {
                // Negate the balance to get a positive interest charge:
                decimal interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
            }
            
        }
        protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn)
        {
            if(isOverdrawn)
            {
                return new Transaction(-20, DateTime.Now, "Apply overdraft fee");

            } else
            {
                return default;
            }
        }
    }
}
