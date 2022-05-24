using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckoutKata;
using System.Collections.Generic;
using System;

namespace CheckoutTests
{
    [TestClass]
    public class UnitTest1
    {
        private Item Biscuits = new Item("B15", 0.30m);
        private Item Apple = new Item("A99", 0.50m);
        private Item Coffee = new Item("C40", 0.60m);
        
        [TestMethod]
        public void Scan()
        {
            Checkout chkout = new Checkout();
            chkout.Scan(Biscuits);
            chkout.Scan(Apple);
            chkout.Scan(Biscuits);

            //Find an apple item in the list
            Assert.IsTrue(chkout.ShowScannedItems().Contains(Apple));
            //Find biscuits in the list and check the count is 2
            if(chkout.ShowScannedItems().Contains(Biscuits))
            {
                int count = chkout.ShowScannedItems().Find(x => x.Sku == Biscuits.Sku).ItemCount;
                Assert.AreEqual(2, count);
            }
            else
            { 
                //Biscuits were not in the list
                Assert.Fail();
            }

        }

        [TestMethod]
        public void TotalPrice()
        {
            Checkout chkout = new Checkout();
            chkout.Scan(Biscuits);
            chkout.Scan(Apple);
            chkout.Scan(Biscuits);

            //check the total price
            Assert.AreEqual(1.10m, chkout.calculateTotal());

        }
    }
}
