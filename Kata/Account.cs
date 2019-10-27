using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
    public class Account
    {
        public int _deposit { get; set; }
        public int _withDraw { get; set; }
        private static int balance = 0;
        private int maximumLimit = 1500;
        private int minimum_limit = 1;
        private static List<string> listStatement = new List<string>();
        private static string day = System.DateTime.Now.Day.ToString();
        private static string month = System.DateTime.Now.Month.ToString();
        private static string year = System.DateTime.Now.Year.ToString();
        private string date = day + "/" + month + "/" + year;
        private string statement = "";

        public Account (int amount)
        {
            _deposit = amount;
            _withDraw = amount;
        }


        public int Deposit()
        {
            balance = balance + _deposit;
            statement = date + " " + "+" + _deposit + " " + balance;
            listStatement.Add(statement);
            return balance;
        }

        public int WithDraw()
        {
            balance = balance - _withDraw;
            statement = date + " " + "-" + _deposit + " " + balance;
            listStatement.Add(statement);
            return balance;
        }


        public int ControlAmount(int amount)
        {
            if(amount != 0)
            {
                if(amount < minimum_limit)
                {
                    return 1;
                }
                else if(amount > maximumLimit)
                {
                    return 2;
                }
            }
            else
            {
                return 3;
            }

            return 0;
        }


        public List<string> PrintStatement()
        {
            return listStatement;
        }
    }
}
