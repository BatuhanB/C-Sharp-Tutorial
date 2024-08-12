namespace ValueAndReferenceTypes;
public static class ChangeReference
{
    public static Product ChangeByReference(ref Product itemRef)
    {
        return itemRef = new Product("Changed Ref", 12345);
    }
    public static Product ChangeByReferenceWithOutRef(Product itemRef)
    {
        return itemRef = new Product("Changed Ref", 12345);
    }
    public static Product ChangeByReferenceUsingOut(out Product itemRef)
    {
        return itemRef = new Product("Changed Ref", 12345);
    }
}

public class Product
{
    public Product(string name, int newID)
    {
        ItemName = name;
        ItemID = newID;
    }

    public string ItemName { get; set; }
    public int ItemID { get; set; }
}
