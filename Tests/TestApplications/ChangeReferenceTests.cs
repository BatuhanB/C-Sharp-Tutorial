using ValueAndReferenceTypes;

namespace TestApplications;
public class ChangeReferenceTests
{
    [Fact]
    public void Check_If_Change_Reference_Without_Ref()
    {
        //arrange
        Product product = new("Stapler", 12);
        var refChangedProduct = ChangeReference.ChangeByReferenceWithOutRef(product);

        //act
        var isChange = ReferenceEquals(product, refChangedProduct);

        //assert
        Assert.False(isChange);
    }

    [Fact]
    public void Check_If_Change_Reference_Ref_Keyword()
    {
        //arrange
        Product product = new("Stapler", 12);
        var refChangedProduct = ChangeReference.ChangeByReference(ref product);

        //act
        var isChange = ReferenceEquals(product, refChangedProduct);

        //assert
        Assert.True(isChange);
    }

    [Fact]
    public void Check_If_Change_Reference_Out_Keyword()
    {
        //arrange
        Product product = new("Stapler", 12);
        var refChangedProduct = ChangeReference.ChangeByReferenceUsingOut(out product);

        //act
        var isChange = ReferenceEquals(product, refChangedProduct);

        //assert
        Assert.True(isChange);
    }
}
