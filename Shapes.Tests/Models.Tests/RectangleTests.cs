using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class Tests
  {
    [TestMethod]
    public void Rectangle_GetArea_AreaOfRectangle()
    {
      //arrange
      Rectangle newRectangle = new Rectangle(4, 4);
      //act
      int result = newRectangle.GetArea();
      //assert
      Assert.AreEqual(result, 16);
    }
    [TestMethod]
    public void rectangle_IsSquare_True()
    {
      //arrange
      Rectangle newRectangle = new Rectangle(4, 4);
      //act
      bool result = newRectangle.IsSquare();
      //assert
      Assert.AreEqual(result, true);
    }
    [TestMethod]
    public void Rectangle_IsSquare_False()
    {
      //arrange
      Rectangle newRectangle = new Rectangle(4, 5);
      //act
      bool result = newRectangle.IsSquare();
      //assert
      Assert.AreEqual(result, false);
    }
  }
}