using System.Security.Principal;

namespace MoneyTransactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bankAccountsInfo = Console.ReadLine().Split(",");
            Dictionary<int, double> bankAccounts = new Dictionary<int, double>();

            int number;
            double balance;

            foreach (string bankAccount in bankAccountsInfo)
            {
                string[] strings = bankAccount.Split("-");
                number = int.Parse(strings[0]);
                balance = double.Parse(strings[1]);

                bankAccounts.Add(number, balance);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] data = input.Split();
                    string command = data[0];
                    int accountNumber = int.Parse(data[1]);
                    double sum = double.Parse(data[2]);

                    if (!bankAccounts.ContainsKey(accountNumber))
                    {
                        throw new ArgumentException("Invalid account!");
                    }

                    if (command == "Deposit")
                    {
                        bankAccounts[accountNumber] += sum;
                    }
                    else if (command == "Withdraw")
                    {
                        if (sum > bankAccounts[accountNumber])
                        {
                            throw new ArgumentException("Insufficient balance!");
                        }
                        else
                        {
                            bankAccounts[accountNumber] -= sum;
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                    Console.WriteLine($"Account {accountNumber} has new balance: {bankAccounts[accountNumber]:f2}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }
    }
}