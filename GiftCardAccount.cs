using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class GiftCardAccount : BankAccount
    {
        private readonly decimal _monthlyDeposit = 0m;
        public GiftCardAccount(string owner, decimal initialAmount, decimal monthlyDeposit = 0) : base(owner, initialAmount)
        {
            _monthlyDeposit = monthlyDeposit;

        }

        public override void PerformMonthEndTransactions()
        {
            if(_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
            }
        }
    }
}
