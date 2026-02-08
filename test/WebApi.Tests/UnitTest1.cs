namespace WebApi.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }

    [Fact]
    public void Touch_WebApi()
    {
        var programType = typeof(Program);
        Assert.NotNull(programType);
    }
}
