namespace TestDataStructers;

public class ArrayTests
{
    [Theory]
    [InlineData(16)]
    [InlineData(32)]
    [InlineData(64)]
    [InlineData(128)]
    [InlineData(256)]
    public void Check_Array_Constructor(int defaultSize)
    {
        //Arrange | Act
        var array = new DataStructers.Array.Array(defaultSize);

        //Assert
        Assert.Equal(defaultSize, array.Length);
    }
}