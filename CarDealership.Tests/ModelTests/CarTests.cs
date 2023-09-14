using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using CarDealership.Models;

namespace CarDealership.TestTools
{
  [TestClass]
  public class Car
  {
    [TestMethod]
    public void CarsConstructor_CreateInstanceOfCars_Car()
    {
      Car newCar = new Car();
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }
  //   [TestMethod]
  //   public void 
  }
}