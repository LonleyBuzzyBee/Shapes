using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CircleTests
  {
    [TestMethod]
    public void Circle_GetCircumfrence()
    {
      //arrange
      Circle newCircle = new Circle(3);
      //act
      double result = newCircle.GetCircumference();
      //assert
      Assert.AreEqual(result, 18.84);
    }
    [TestMethod]
    public void Circle_GetDiameter()
    {
      //arrange
      Circle newCircle = new Circle(3);
      //act
      double result = newCircle.GetDiameter();
      //assert
      Assert.AreEqual(result, 6);
    }
  }
}