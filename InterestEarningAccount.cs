using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string owner, decimal initialBalance) : base(owner, initialBalance) {

        }
            public override void PerformMonthEndTransactions() {
            if(Balance > 500m)
            {
                decimal interest = Balance * 0.02m;
                MakeDeposit(interest, DateTime.Now, "Apple monthly interest");

            }

        }
        

    }
}
