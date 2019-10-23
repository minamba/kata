using System;

namespace Kata
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Sectionnez votre opération :");
                Console.WriteLine("'D' pour faire un dépot | 'R' pour faire un retrait");
                var choice = Console.ReadLine().ToUpper();
                Console.WriteLine("Veuillez saisir un montant :");
                int amount = int.Parse(Console.ReadLine());

                Account _account = new Account();
                Console.WriteLine(_account.PrintStatement(choice, amount));
                Console.ReadLine();
            }
        }
    }
}
