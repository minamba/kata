using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
    public class Account
    {
        /////////////////Properties///////////////////////////
        public int _deposit { get; set; }
        public int _withDraw { get; set; }
        private static int balance = 500;

        ////////////////////Methods///////////////////////////
        public int Deposit(int d)
        {
            d = _deposit;
            balance = balance + d; 
            return d;
        }

        public int WithDraw(int wd)
        {
            wd = _withDraw;
            balance = balance - wd;
            return wd;
        }


        public string PrintStatement(string choice, int amount)
        {
            string day = System.DateTime.Now.Day.ToString();
            string month = System.DateTime.Now.Month.ToString();
            string year = System.DateTime.Now.Year.ToString();
            string date = day + "/" + month + "/" + year;
            string statement="";
            _deposit = amount;
            _withDraw = amount;

            switch (choice)
            {
                case "D":
                        statement = date + " " + "+" + Deposit(amount) + " " + balance.ToString();
                        return statement;

                case "R":
                        statement = date + " " + "-" + WithDraw(amount) + " " + balance.ToString();
                        return statement;
            }

            return statement;
        }
    }
}
