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

    [Fact]
    public void Check_Array_Constructor_with_Params()
    {
        //Arrange | Act
        var array = new DataStructers.Array.Array(1,2,3);

        //Assert
        Assert.Equal(3, array.Length);
    }

    [Fact]
    public void Get_and_Set_Values_in_Array()
    {
        //Arrange
        var array = new DataStructers.Array.Array();

        //Act
        array.SetValue(10, 0);
        array.SetValue(20, 1);

        //Assert
        Assert.Equal(10, array.GetValue(0));
        Assert.Equal(20, array.GetValue(1));
        Assert.Null(array.GetValue(2));
    }
}