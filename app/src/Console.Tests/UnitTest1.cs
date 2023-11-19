namespace Console.Tests;

public class SomeTests
{
    [Fact]
    public void Will_Pass()
    {
        Assert.True(true);
    }

    [Fact]
    public void Will_Fail()
    {
        Assert.True(false);
    }
}