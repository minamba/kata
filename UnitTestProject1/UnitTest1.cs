using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestKata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DepositTest()
        {
            int balance = 20;
            int d = 10;
            var depo = new Account();

            depo._deposit = d;
            balance = balance - depo.Deposit(depo._deposit);

            Assert.AreEqual(10, balance);
        }


        [TestMethod]
        public void WithDrawTest()
        {
            int balance = 20;
            int wd = 5;
            var withD = new Account();

            withD._withDraw = wd;
            balance = balance - withD.WithDraw(withD._withDraw);

            Assert.AreEqual(15, balance);
        }


        [TestMethod]
        public void PrintStatementTestDeposit()
        {
            string date = "23/10/2019";
            string statement="";
            int balance = 0;
            int d = 500;
            var depo = new Account();

            depo._deposit = d;
            balance = balance + depo.Deposit(depo._deposit);
            statement = date + " " + "+"+ depo.Deposit(depo._deposit) + " " + balance;

            Assert.AreEqual("23/10/2019 +500 500", statement);
        }


        [TestMethod]
        public void PrintStatementTestWithDraw()
        {
            string date = "23/10/2019";
            string statement = "";
            int balance = 500;
            int wd = 100;
            var withD = new Account();

            withD._withDraw = wd;
            balance = balance - withD.WithDraw(withD._withDraw);
            statement = date + " " + "-" + withD.WithDraw(withD._withDraw) + " " + balance;

            Assert.AreEqual("23/10/2019 -100 400", statement);
        }
    }
}
