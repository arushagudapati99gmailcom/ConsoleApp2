using ConsoleApp2;
namespace TestProject1;

[TestClass]

public class cal
{
    [TestMethod]
    public void TestAdd()
    {
        cal c = new cal();
        int res = ConsoleApp2.cal.Add(10, 20);
        Assert.AreEqual(30, res);
    }
}