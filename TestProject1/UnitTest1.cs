using ConsoleApp2;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            cal c = new cal();
            int res = c.Add(10, 20);
            Assert.AreEqual(30, res);
        }
    }
}