using Lab_10;
namespace TestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void PrivateModifierTest()
    {
      SmartWatch expected = new SmartWatch();
      SmartWatch actual = new SmartWatch();
      Assert.AreEqual(expected, actual);
    }
  }
}