using DataStructers.Array;

namespace TestDataStructers;
public class ArrayListTests
{
    private ArrayList _arrayList;

    public ArrayListTests()
    {
        _arrayList = new ArrayList();
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(16)]
    [InlineData(32)]
    [InlineData(64)]
    public void Array_List_Constructor_Test(int defaultSize)
    {
        //Arrange | Act
        var arrayList = new ArrayList(defaultSize);

        //Assert
        Assert.Equal(arrayList.Length, defaultSize);
    }

    [Fact]
    public void Array_List_Add_Test()
    {
        //Act
        for (int i = 0; i < 20; i++)
        {
            _arrayList.Add(i);
        }

        Assert.Equal(32, _arrayList.Length);
    }

    [Theory]
    [InlineData(32)]
    [InlineData(64)]
    [InlineData(128)]
    [InlineData(256)]
    public void Array_List_Remove_Test(int length)
    {
        //Arrange
        for (int i = 0; i < length; i++)
        {
            _arrayList.Add(i);
        }

        Assert.Equal(_arrayList.Length, length);

        // Act

        for (int i = _arrayList.Length - 1; i > 8; i--)
        {
            _arrayList.Remove();
        }

        //Assert
        Assert.Equal(32, _arrayList.Length);
    }

    [Fact]
    public void Foreach_Test()
    {
        //Arrange
        _arrayList.Add("A");
        _arrayList.Add("B");
        _arrayList.Add("C");
        _arrayList.Add("D");

        _arrayList.Remove();

        //Act
        string s = string.Empty;
        foreach (var item in _arrayList)
        {
            s += item;
        }

        //Assert
        Assert.Equal("ABC", s);
    }
}