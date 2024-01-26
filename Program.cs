namespace ClassesAndObjects
{
    internal class Program
    {


        static void Main(string[] args)
        {
            while(true)
            {
            Console.Write("Enter your name >> ");
            string user = Console.ReadLine();
            Console.Write("Enter your initial balance >> ");
            decimal ibal = Convert.ToDecimal(Console.ReadLine());
            BankAccount account = new BankAccount(user,ibal);
            Console.WriteLine($"{account.AccountNumber} | {account.Owner} | ${account.Balance}");
            Console.Write("Withdraw/Deposit >> ");
                string note;
            string opt = Console.ReadLine();
            if (opt.Equals("Withdraw"))
            {
                Console.Write("Enter the amount of withdrawal >> ");
                decimal withdrawal = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Input a note >> ");
                note = Console.ReadLine();
                account.MakeWithdrawal(withdrawal, DateTime.Now, note);

            }
            else if (user.Equals("Deposit"))
            {
                Console.Write("Enter the amount of deposit >> ");
                decimal deposit = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Input a note >> ");
                note = Console.ReadLine();
                account.MakeDeposit(deposit, DateTime.Now, note);
            }
            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("Invalid", -55);
            } 
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance.");
                Console.WriteLine(e.Message);
                return;
            }
            
            Console.Write("Do you want to continue? >> ");
            string option = Console.ReadLine();
            if(option.Equals("yes"))
                {
                    continue;
                }
            else if(option.Equals("no"))
                {
                    break;
                }
            else
                {
                    break;
                }
            }

        }
    }
}
