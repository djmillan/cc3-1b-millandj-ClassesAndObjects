namespace ClassesAndObjects
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //while(true)
            //{
            //Console.Write("Enter your name >> ");
            //string user = Console.ReadLine();
            //Console.Write("Enter your initial balance >> ");
            //decimal ibal = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Withdraw/Deposit >> ");
            //string with = Console.ReadLine();
            BankAccount account = new BankAccount("Joe",1000);
            Console.WriteLine($"{account.AccountNumber} | {account.Owner} | ${account.Balance}");
                //if(user.Equals("Withdraw"))
                //{
                    //Console.Write("Enter the amount of withdrawal >> ");
                    //decimal withdrawal = Convert.ToDecimal(Console.ReadLine());

                    //Console.Write("Input a note >> ");
                    //string note = Console.ReadLine();
                    account.MakeWithdrawal(500,DateTime.Now, "Pay rent");

                //} else if(user.Equals("Deposit"))
                //{
                    //Console.Write("Enter the amount of deposit >> ");
                    //decimal deposit = Convert.ToDecimal(Console.ReadLine());

                    //Console.Write("Input a note >> ");
                    //string notes = Console.ReadLine();
                    account.MakeDeposit(100, DateTime.Now, "Friend's payment");
                //}

                /*
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
                */
            //}

        }
    }
}
