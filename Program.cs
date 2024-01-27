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
                    Console.Write("Enter your name >> ");
                    string name = Console.ReadLine();
                    Console.Write("Enter your initial balance >> ");
                    decimal inbal = Convert.ToDecimal(Console.ReadLine()); //Initial balance
                    BankAccount account = new BankAccount(name, inbal);
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
