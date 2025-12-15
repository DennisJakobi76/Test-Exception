using System.Threading.Channels;

namespace Test_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            int choice;

            do
            {
                Console.WriteLine("\n\n\n\n-------- BANK ACOOUNT MENU --------");
                Console.WriteLine("1 - Deposit");
                Console.WriteLine("2 - Withdraw");
                Console.WriteLine("3 - Show Current Balance");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("Select an option: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Deposit Amount: ");
                        try
                        {
                            account.Deposit(double.Parse(Console.ReadLine()));
                        }
                        catch (InsufficientFundException e)
                        {

                            Console.WriteLine(e.Message);
                        }
                        break;
                        case 2:
                        Console.WriteLine("Current Balance: " + account.Balance);
                        Console.WriteLine("Withdraw Amount: ");
                        try
                        {
                            account.Withdraw(double.Parse(Console.ReadLine()));
                        }
                        catch (InsufficientFundException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Current Balance: " + account.Balance);
                        break;
                }

            } while (choice >= 1&& choice <= 3);

            Console.WriteLine("Bye...");
            Console.ReadLine();
        }
    }
}
