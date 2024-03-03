using Lab_10;
namespace TestProject1
{
  [TestClass]
  public class DigitalWatchClassTests
  {
    [TestMethod]
    public void RandomInitConstructorTest()
    {
      DigitalWatch expected = new DigitalWatch();
      expected.RandomInit();
      DigitalWatch actual = new DigitalWatch(expected.BrandName, expected.YearOfIssue, expected.DisplayType);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RandomInitCopyTest()
    {
      DigitalWatch expected = new DigitalWatch();
      expected.RandomInit();
      DigitalWatch actual = (DigitalWatch)expected.Clone();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RandomInitShallowCopyTest()
    {
      DigitalWatch expected = new DigitalWatch();
      expected.RandomInit();
      DigitalWatch actual = (DigitalWatch)expected.ShallowCopy();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RandomInitToStringTest()
    {
      DigitalWatch expected = new DigitalWatch();
      expected.RandomInit();
      DigitalWatch actual = (DigitalWatch)expected.Clone();
      Assert.AreEqual(expected.ToString(), actual.ToString());
    }

    [TestMethod]
    public void RandomInitCompareToTest()
    {
      DigitalWatch expected = new DigitalWatch();
      expected.RandomInit();
      DigitalWatch actual = (DigitalWatch)expected.Clone();
      Assert.AreEqual(expected.CompareTo(actual), 0);
    }

    [TestMethod]
    public void RandomInitCompareToRectangleTest()
    {
      DigitalWatch expected = new DigitalWatch();
      expected.RandomInit();
      Rectangle actual = new();
      Assert.AreEqual(expected.CompareTo(actual), 1);
    }

    [TestMethod]
    public void RandomInitCompareToOtherWatchesTest()
    {
      DigitalWatch expected = new DigitalWatch();
      expected.RandomInit();
      AnalogWatch actual = new AnalogWatch();
      actual.RandomInit();
      actual.YearOfIssue = expected.YearOfIssue;
      Assert.AreEqual(expected.CompareTo(actual), 0);
    }

    [TestMethod]
    public void RandomInitCompareToNullTest()
    {
      DigitalWatch expected = new DigitalWatch();
      Assert.ThrowsException<ArgumentNullException>(() => expected.CompareTo(null));
    }
  }
}