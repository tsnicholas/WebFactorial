namespace logic.tests;

public class FactorialTest
{
    [Fact]
    public void TestFactorial_BaseCase()
    {
        Assert.Equal(1, Factorial.getFactorial(1));
    }

    [Fact]
    public void TestFactorial_SampleCase() 
    {
        Assert.Equal(120, Factorial.getFactorial(5));
    }

    [Fact]
    public void TestFactorial_NoNegativeInputException() 
    {
        Assert.Throws<Exception>(() => {
            Factorial.getFactorial(-1);
        });
    }
}
