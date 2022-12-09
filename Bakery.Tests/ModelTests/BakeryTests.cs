using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using Bakery.Program;
using System.Collections.Generic;
using System;


namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetCost_ReturnsTotalCost_TotalCost()
    {
      int breadCount = 1;
      Bread bread = new Bread(breadCount);
      double totalCost = bread.GetCost();
      Assert.AreEqual(totalCost, 5);
    }


   


  }
  


}