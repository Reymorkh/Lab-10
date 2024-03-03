using Lab_10;
namespace TestProject1
{
  [TestClass]
  public class SmartWatchClassTests
  {
    [TestMethod]
    public void RandomInitConstructorTest()
    {
      SmartWatch expected = new SmartWatch();
      expected.RandomInit();
      SmartWatch actual = new SmartWatch(expected.BrandName, expected.YearOfIssue, expected.DisplayType, expected.OperatingSystem, expected.HeartRateSensor);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RandomInitCopyTest()
    {
      SmartWatch expected = new SmartWatch();
      expected.RandomInit();
      SmartWatch actual = (SmartWatch)expected.Clone();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RandomInitShallowCopyTest()
    {
      SmartWatch expected = new SmartWatch();
      expected.RandomInit();
      SmartWatch actual = (SmartWatch)expected.ShallowCopy();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RandomInitToStringTest()
    {
      SmartWatch expected = new SmartWatch();
      expected.RandomInit();
      SmartWatch actual = (SmartWatch)expected.Clone();
      Assert.AreEqual(expected.ToString(), actual.ToString());
    }

    [TestMethod]
    public void RandomInitCompareToTest()
    {
      SmartWatch expected = new SmartWatch();
      expected.RandomInit();
      SmartWatch actual = (SmartWatch)expected.Clone();
      Assert.AreEqual(expected.CompareTo(actual), 0);
    }

    [TestMethod]
    public void RandomInitCompareToRectangleTest()
    {
      SmartWatch expected = new SmartWatch();
      expected.RandomInit();
      Rectangle actual = new();
      Assert.AreEqual(expected.CompareTo(actual), 1);
    }

    [TestMethod]
    public void RandomInitCompareToOtherWatchesTest()
    {
      SmartWatch expected = new SmartWatch();
      expected.RandomInit();
      AnalogWatch actual = new AnalogWatch();
      actual.RandomInit();
      actual.YearOfIssue = expected.YearOfIssue;
      Assert.AreEqual(expected.CompareTo(actual), 0);
    }

    [TestMethod]
    public void RandomInitCompareToNullTest()
    {
      SmartWatch expected = new SmartWatch();
      Assert.ThrowsException<ArgumentNullException>(() => expected.CompareTo(null));
    }
  }
}