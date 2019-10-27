using System;
using System.Collections.Generic;

namespace Kata
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> listStatement = new List<string>();
            int amount;
            int control;
            string choice;
            Account account;

            //initialization of the balance
            Account baseBalance = new Account(500);
            baseBalance.Deposit();
            listStatement = baseBalance.PrintStatement();

            while (true)
            {
                Console.WriteLine("Sectionnez votre opération :");
                Console.WriteLine("'D' pour faire un dépot | 'R' pour faire un retrait | 'S' pour voir vos dernières opérations");
                choice = Console.ReadLine().ToUpper();

                if (choice != "S")
                {
                    Console.WriteLine("Veuillez saisir un montant :");
                    amount = int.Parse(Console.ReadLine());
                    account = new Account(amount);
                    control = account.ControlAmount(amount);


                    switch (choice)
                    {
                        case "D":
                            switch (control)
                            {
                                case 1:
                                    Console.WriteLine("Veuillez saisir un montant positif");
                                    break;
                                case 2:
                                    Console.WriteLine("Veuillez saisir montant inferieur à 1500");
                                    break;
                                case 3:
                                    Console.WriteLine("Veuillez saisir un montant différent de 0");
                                    break;
                                default:
                                    account.Deposit();
                                    break;
                            }
                            break;

                        case "R":
                            switch (control)
                            {
                                case 1:
                                    Console.WriteLine("Veuillez saisir un montant positif");
                                    break;
                                case 2:
                                    Console.WriteLine("Veuillez saisir montant inferieur à 1500");
                                    break;
                                case 3:
                                    Console.WriteLine("Veuillez saisir un montant différent de 0");
                                    break;
                                default:
                                    account.WithDraw();
                                    break;
                            }
                            break;
                    }
                }
                else
                {
                    foreach (var i in listStatement)
                    {
                        Console.WriteLine(i);                       
                    }                  
                }
            }
        }
    }
}
