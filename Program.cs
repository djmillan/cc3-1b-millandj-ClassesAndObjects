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
