using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            Balance = initialBalance;
        }


        public void MakeDeposit(decimal Amount, DateTime date, string note)
        {

        }
        public void MakeWithdrawal(decimal Amount, DateTime date, string note)
        {

        }

    }
}
