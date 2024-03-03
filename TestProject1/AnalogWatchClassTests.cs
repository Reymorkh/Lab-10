using Lab_10;
namespace TestProject1
{
  [TestClass]
  public class AnalogWatchClassTests
  {
    [TestMethod]
    public void RandomInitConstructorTest()
    {
      AnalogWatch expected = new AnalogWatch();
      expected.RandomInit();
      AnalogWatch actual = new AnalogWatch(expected.BrandName, expected.YearOfIssue, expected.Style);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RandomInitCopyTest()
    {
      AnalogWatch expected = new AnalogWatch();
      expected.RandomInit();
      AnalogWatch actual = (AnalogWatch)expected.Clone();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RandomInitShallowCopyTest()
    {
      AnalogWatch expected = new AnalogWatch();
      expected.RandomInit();
      AnalogWatch actual = (AnalogWatch)expected.ShallowCopy();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RandomInitToStringTest()
    {
      AnalogWatch expected = new AnalogWatch();
      expected.RandomInit();
      AnalogWatch actual = (AnalogWatch)expected.Clone();
      Assert.AreEqual(expected.ToString(), actual.ToString());
    }

    [TestMethod]
    public void RandomInitCompareToTest()
    {
      AnalogWatch expected = new AnalogWatch();
      expected.RandomInit();
      AnalogWatch actual = (AnalogWatch)expected.Clone();
      Assert.AreEqual(expected.CompareTo(actual), 0);
    }

    [TestMethod]
    public void RandomInitCompareToRectangleTest()
    {
      AnalogWatch expected = new AnalogWatch();
      expected.RandomInit();
      Rectangle actual = new();
      Assert.AreEqual(expected.CompareTo(actual), 1);
    }

    [TestMethod]
    public void RandomInitCompareToOtherWatchesTest()
    {
      AnalogWatch expected = new AnalogWatch();
      expected.RandomInit();
      SmartWatch actual = new SmartWatch();
      actual.RandomInit();
      actual.YearOfIssue = expected.YearOfIssue;
      Assert.AreEqual(expected.CompareTo(actual), 0);
    }

    [TestMethod]
    public void RandomInitCompareToNullTest()
    {
      AnalogWatch expected = new AnalogWatch();
      Assert.ThrowsException<ArgumentNullException>(() => expected.CompareTo(null));
    }
  }
}