namespace Library.Tests;
using TestDateFormat;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DateFormatterTests()
    {
        string ExpectedDate = "2003-11-15";
        string Result = DateFormatter.ChangeFormat("15/11/2003");
        Assert.AreEqual(ExpectedDate,Result);
        
        
    }
    
    [Test]
    public void DateFormatterTests2()
    {
        string ExpectedDate = "2003/11/15";
        string Result = DateFormatter.ChangeFormat("2003/11/15");
        Assert.AreNotEqual(ExpectedDate,Result);
    }
    
    [Test]
    public void DateFormatterTests3()
    {
        string Result = DateFormatter.ChangeFormat("2003/11/15");
        Assert.IsEmpty(Result);
        Assert.IsNull(Result);
    }
}