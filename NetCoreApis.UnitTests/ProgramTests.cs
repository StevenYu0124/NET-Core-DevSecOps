namespace NetCoreApis.UnitTests;

public class ProgramTests
{
    [Test]
    public void Main()
    {
        string[] args = [];
        Program.CreateApp(args);
        Assert.Pass();
    }
}