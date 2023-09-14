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
      Car newCar = new Car("test");
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

    [TestMethod]

    public void SetDescription_SetDescription_String()
    {

      //Arrange 
      string description = "Hyundai Kona EV";
      Car newCar = new Car(description);

      //Act 
      string updatedDescription = "BMW X1 x28i";
      newCar.Description = updatedDescription;
      string result = newCar.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_CarList()
    {
      //Arrange
      List<Car> newList = new List<Car> { };

      //Act 
      List<Car> result = Car.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsCars_CarList()
    {

      //Arrange
      string description01 = "Hyundai Kona EV";
      string description02 = "BMW X1 x28i";
      Car newCar1 = new Car(description01);
      Car newCar2 = new Car(description02);
      List<Car> newList = new List<Car> { newCar1, newCar2 };

      //Act 
      List<Car> result = Car.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}