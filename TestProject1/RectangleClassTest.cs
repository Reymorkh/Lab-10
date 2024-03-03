using Lab_10;

namespace UnitTestProject1
{
  [TestClass]
  public class RectangleClassTest
  {
    [TestMethod]
    public void GetCountTest()
    {
     int expected = Rectangle.Count;
     int actual = Rectangle.Count;
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LowerLimitTest()
    {
      //Arrange
      Rectangle expected = new Rectangle();
      //Act
      Rectangle actual = new Rectangle(0.0001, 0.0001);
      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void UpperLimitTest()
    {
      //Arrange
      Rectangle expected = new Rectangle(2133213,312312312);
      //Act
      Rectangle actual = new Rectangle(46340.95, 46340.95);
      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void EditLengthTest()
    {
      Rectangle expected = new Rectangle();
      expected.EditLength(30);
      Rectangle actual = new Rectangle(30.0001, 0);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void EditMinusLengthTest()
    {
      Rectangle expected = new Rectangle(50, 0);
      expected.EditLength(-30);
      Rectangle actual = new Rectangle(20, 0);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void EditWidthTest()
    {
      Rectangle expected = new Rectangle();
      expected.EditWidth(30);
      Rectangle actual = new Rectangle(0, 30.0001);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void EditMinusWidthTest()
    {
      Rectangle expected = new Rectangle(0, 50);
      expected.EditWidth(-30);
      Rectangle actual = new Rectangle(0, 20);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IncrementTest()
    {
      Rectangle expected = new Rectangle();
      expected++;
      Rectangle actual = new Rectangle(1.0001, 1.0001);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IncrementMaximumTest()
    {
      Rectangle expected = new Rectangle(46340.95, 46340.95);
      expected++;
      Rectangle actual = new Rectangle(46340.95, 46340.95);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecrementTest()
    {
      Rectangle expected = new Rectangle(2,2);
      expected--;
      Rectangle actual = new Rectangle(1, 1);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecrementMinimalTest()
    {
      Rectangle expected = new Rectangle();
      expected--;
      Rectangle actual = new Rectangle();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RectangleToDoubleExplicitTest()
    {
      double expected = (double)new Rectangle();
      double actual = Math.Sqrt(Math.Pow(0.0001, 2) + Math.Pow(0.0001, 2)) / 2;
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RectangleToBoolImplicitTest()
    {
      bool expected = new Rectangle();
      bool actual = true;
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void RectangleCopyTest()
    {
      Rectangle expected = new Rectangle();
      Rectangle actual = new Rectangle(expected);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RectangleMultiplyTest()
    {
      Rectangle expected = new Rectangle();
      expected.Multiply(4);
      Rectangle actual = new Rectangle(0.0004, 0.0004);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RectangleMultiplyStaticTest()
    {
      Rectangle expected = new Rectangle();
      Rectangle.MultiplyStatic(4, expected);
      Rectangle actual = new Rectangle(0.0004, 0.0004);
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void RectangleBinAdditionRight()
    {
      Rectangle expected = new Rectangle(1, 1);
      Rectangle actual = new Rectangle(3, 3);
      expected += 2;
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RectangleBinAdditionLeft()
    {
      Rectangle expected = new Rectangle(1, 1);
      Rectangle actual = new Rectangle(3, 3);
      expected = 2 + expected;
      Assert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void RectangleBinSubtractionRight()
    {
      Rectangle expected = new Rectangle(3, 3);
      Rectangle actual = new Rectangle(1, 1);
      expected -= 2;
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RectangleBinSubtractionLeft()
    {
      Rectangle expected = new Rectangle(3, 3);
      Rectangle actual = new Rectangle(1, 1);
      expected = 2 - expected;
      Assert.AreEqual(expected, actual);
    }
    //[TestMethod]
    //public void ObjectTest()
    //{
    //  Rectangle expected = new Rectangle();
    //  Assert.AreEqual(expected, new object());
    //}
  }
}
