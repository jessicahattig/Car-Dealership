using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using CarDealership.Models;

namespace CarDealership.TestTools
{
  [TestClass]
  public class Items
  {
    [TestMethod]
    public void ItemsConstructor_CreateInstanceOfItems_Item()
    {
      Item newItem = new Item();
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }
    [TestMethod]
    public void 
  }
}