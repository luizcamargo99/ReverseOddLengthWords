namespace ReverseOddLengthWords.Tests;

public class StringExtensionTest
{
    [Theory]
    [InlineData("One two three four", "enO owt eerht four")]
    [InlineData("Make sure uoy only esrever sdrow of ddo length", "Make sure you only reverse words of odd length")]
    [InlineData("", "")]
    [InlineData("Bananas", "sananaB")]
    [InlineData("Even even even even even even even even even", "Even even even even even even even even even")]
    [InlineData("Odd odd odd odd odd odd odd odd odd odd odd", "ddO ddo ddo ddo ddo ddo ddo ddo ddo ddo ddo")]
    public void TestReverseOddSuccess(string str, string resultExpected)
    {
        var result = str.ReverseOdd();
        Assert.Equal(resultExpected, result);
    }
}