using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;
using System;
namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {
    [TestMethod]
    public void Sphere_GetVolume()
    {
      //arrange
      Circle newCircle = new Circle(3);
      Sphere newSphere = new Sphere(newCircle);
      //act
      double result = Math.Round(newSphere.GetVolume(), 3);
      Console.WriteLine(result + " ---");
      //assert
      Assert.AreEqual(result, 110.214);

    }
  }
}