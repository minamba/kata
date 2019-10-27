using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestKata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Shoud_add_amount_when_deposit()
        {
            int d = 10;
            var account = new Account(d);
            int balance;

            balance = account.Deposit();

            Assert.AreEqual(510, balance);
        }

        [TestMethod]
        public void Shoud_add_amount_when_deposit_with_zero()
        {
            int d = 0;
            var account = new Account(d);
            int balance;

            balance = account.Deposit();

            Assert.AreEqual(0, balance);
        }

        [TestMethod]
        public void Shoud_add_amount_when_deposit_with_minimum_limit()
        {
            int d = -100;
            var account = new Account(d);
            int balance;

            balance = account.Deposit();

            Assert.AreEqual(-1, balance);
        }

        [TestMethod]
        public void Shoud_add_amount_when_deposit_with_maximum_limit()
        {
            int d = 1501;
            var account = new Account(d);
            int balance;

            balance = account.Deposit();

            Assert.AreEqual(-2, balance);
        }


        [TestMethod]
        public void Shoud_add_amount_when_withdraw()
        {
            int wd = 5;
            var account = new Account(wd);
            int balance;

            balance = account.WithDraw();

            Assert.AreEqual(495, balance);
        }

        [TestMethod]
        public void Shoud_add_amount_when_withdraw_with_zero()
        {
            int wd = 5;
            var account = new Account(wd);
            int balance;

            balance = account.WithDraw();

            Assert.AreEqual(495, balance);
        }

        [TestMethod]
        public void Shoud_add_amount_when_withdraw_with_minimum_limit()
        {
            int wd = -5;
            var account = new Account(wd);
            int balance;

            balance = account.WithDraw();

            Assert.AreEqual(-1, balance);
        }


        [TestMethod]
        public void Shoud_add_amount_when_withdraw_with_maximum_limit()
        {
            int wd = 1501;
            var account = new Account(wd);
            int balance;

            balance = account.Deposit();

            Assert.AreEqual(-2, balance);
        }


        [TestMethod]
        public void PrintStatementTestDeposit()
        {
            List<string> listExpected = new List<string>();
            List<string> listStatement = new List<string>();          
            string date = "23/10/2019";
            int d = 500;
            int d2 = 300;
            string statement;
            string statement2;
            var account = new Account(d);
            var account2 = new Account(d2);

            listExpected.Add("23/10/2019 +500 500");
            listExpected.Add("23/10/2019 +300 800");
            statement = date + " " + "+" + d.ToString() + " " + account.Deposit();   
            statement2 = date + " " + "+" + d2.ToString() + " " + account2.Deposit();
            listStatement.Add(statement);
            listStatement.Add(statement2);

            CollectionAssert.AreEqual(listExpected, listStatement);
        }


        [TestMethod]
        public void PrintStatementTestWithDraw()
        {
            List<string> listExpected = new List<string>();
            List<string> listStatement = new List<string>();
            string date = "23/10/2019";
            int d = 100;
            int d2 = 50;
            string statement;
            string statement2;
            var account = new Account(d);
            var account2 = new Account(d2);

            listExpected.Add("23/10/2019 -100 -100");
            listExpected.Add("23/10/2019 -50 -150");
            statement = date + " " + "-" + d.ToString() + " " + account.WithDraw();
            statement2 = date + " " + "-" + d2.ToString() + " " + account2.WithDraw();
            listStatement.Add(statement);
            listStatement.Add(statement2);

            CollectionAssert.AreEqual(listExpected, listStatement);
        }
    }
}
