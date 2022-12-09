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
    public void GetCost_ReturnsTotalCostOfBread_TotalCost()
    {
      int breadCount = 1;
      Bread bread = new Bread(breadCount);
      double totalCost = bread.GetCost();
      Assert.AreEqual(totalCost, 5);
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetCost_ReturnsTotalCostOfPastry_TotalCost()
    {
      int pastryCount = 5;
      Pastry pastry = new Pastry(pastryCount);
      double totalCost = pastry.GetCost();
      Assert.AreEqual(totalCost, 7);
    }


   


  }
  


}