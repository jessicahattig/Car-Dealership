using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using CarDealership.Models;

namespace CarDealership.TestTools
{
  [TestClass]
  public class CarTests : IDisposable
  {
    public void Dispose()
    {
      Car.ClearAll();
    }

    [TestMethod]
    public void CarsConstructor_CreateInstanceOfCars_Car()
    {
      Car newCar = new Car();
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Hyundai Kona EV";

      //Act
      Car newCar = new Car(description);
      string result = newCar.Description;

      //Assert
      Assert.AreEqual(description, result);
    }
  }
}