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
}
