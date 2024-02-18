using System.Xml.Linq;

namespace ClassesAndObjects
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //while (true)
            //{
                try
                {
            GiftCardAccount giftCard = new GiftCardAccount("Gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "Get Expensive Coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "But Groceries");
            giftCard.PerformMonthEndTransactions();
            // Can make additional deposits
            giftCard.MakeDeposit(27.50m, DateTime.Now, "Add funds for spending money");
            Console.WriteLine("Balance of gift card " + giftCard.Balance);
                var savings = new InterestEarningAccount("Savings account", 10000);
                savings.MakeDeposit(750, DateTime.Now, "Save same money");
                savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
                savings.MakeWithdrawal(250, DateTime.Now, "For monthly bills");
                savings.PerformMonthEndTransactions();
                Console.WriteLine("Current savings balance: " + savings.Balance);

                var lineOfCredit = new LineOfCreditAccount("Line of credit", 0, 2000);
                // how much is too much to borrow?
                lineOfCredit.MakeWithdrawal(1000, DateTime.Now, "Take out monthly advance");
                lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
                lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
                lineOfCredit.MakeDeposit(150m, DateTime.Now, "partial restoration of repairs");
                lineOfCredit.PerformMonthEndTransactions();
                Console.WriteLine("Current line of credit: " + lineOfCredit.Balance);

                    Console.Write("Enter your name >> ");
                    string name = Console.ReadLine();
                    Console.Write("Enter your initial balance >> ");
                    decimal initialBalance = Convert.ToDecimal(Console.ReadLine()); //Initial balance
                    BankAccount account = new BankAccount(name, initialBalance);
                    Console.WriteLine($"Account {account.AccountNumber} was created for {account.Owner} with ${account.Balance} initial balance");
                    Console.Write("Withdraw/Deposit >> ");
                    string note;
                    string option = Console.ReadLine();
                    if (option.Equals("Withdraw"))
                    {
                        Console.Write("Enter the amount of withdrawal >> ");
                        decimal withdrawal = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Input a note >> ");
                        note = Console.ReadLine();
                        account.MakeWithdrawal(withdrawal, DateTime.Now, note);

                    }
                    else if (option.Equals("Deposit"))
                    {
                        Console.Write("Enter the amount of deposit >> ");
                        decimal deposit = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Input a note >> ");
                        note = Console.ReadLine();
                        account.MakeDeposit(deposit, DateTime.Now, note);
                    }
                    Console.WriteLine(account.GetAccountHistory());
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Exception caught creating account with negative balance.");
                    Console.WriteLine(e.Message);
                    return;
                }
                /*
                Console.Write("Do you want to continue? >> ");
                string option1 = Console.ReadLine();
                if (option1.Equals("yes"))
                {
                    continue;
                }
                else if (option1.Equals("no"))
                {
                    break;
                }
                else
                {
                    break;
                }
                */

            //}

        }
    }
}
