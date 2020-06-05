using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace test6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int money = 0;
            List<lab6.Account> account = new List<lab6.Account>();
            for (int i = 0; i < 50; i++)
            {
                Random rand = new Random();
                account.Add(new lab6.Account() { money = rand.Next(10, 100000) });
                money += account[i].money;
            }
            lab6.Bank bank = new lab6.Bank();


            //act
            for (int i = 0; i < 2000; i++)
            {
                Random rand = new Random();
                bank.doTransfer(account[rand.Next(0, account.Count)], account[rand.Next(0, account.Count)], rand.Next(10, 1000));
            }
            int money2 = 0;
            for (int i = 0; i < account.Count; i++)
            {
                money2 += account[i].money;
            }

            //assert
            Assert.AreEqual(money, money2);
        }
    }
}
