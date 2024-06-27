using ValueAndReferenceTypes;

namespace TestApplications;

public class ValAndRefTypeTests
{
    [Fact]
    public void RefTypeTest()
    {
        //Arrange
        var p1 = new ReferenceType();
        p1.X = 10;
        p1.Y = 20;
        var p2 = p1;

        //Act
        p2.X = 30;

        //Assert
        Assert.Equal(p1.X, p2.X);
    }

    [Fact]
    public void ValTypeTest()
    {
        //Arrange
        var p1 = new ValueAndReferenceTypes.ValueType();
        p1.X = 10;
        p1.Y = 20;
        var p2 = p1;

        //Act
        p2.X = 30;

        //Assert
        Assert.NotEqual(p1.X, p2.X);
    }

    [Fact]
    public void RecordTypeTest()
    {
        // Record => Immutable - Can compare as value type - LINQ
        //Arrange
        var p1 = new RecordType() { X = 10, Y = 20 };

        //Act

        var p2 = new RecordType() { X = 1, Y = 2 };

        //Assert
        Assert.NotEqual(p1, p2);
    }


    [Fact]
    public void SwapByValueTest()
    {
        //Arrange
        int a = 20, b = 30;
        var p1 = new ValueAndReferenceTypes.ValueType();

        //Act
        p1.Swap(a, b);

        //Assert
        Assert.Equal(20, a);
        Assert.Equal(30, b);
    }

    [Fact]
    public void SwapByReferenceTest()
    {
        //Arrange
        int a = 20, b = 30;
        var p1 = new ReferenceType();

        //Act
        p1.Swap(ref a, ref b);

        //Assert
        Assert.Equal(30, a);
        Assert.Equal(20, b);
    }

    [Fact]
    public void SwapOutReferenceTest()
    {
        //Arrange
        int a = 20;
        var p1 = new ReferenceType();

        //Act
        p1.SwapOut(out a);

        //Assert
        Assert.Equal(100, a);
    }
}