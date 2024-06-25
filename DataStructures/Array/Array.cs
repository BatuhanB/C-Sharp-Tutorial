
namespace DataStructers.Array;

public class Array
{
    public int Length => InnerArray.Length;
    private Object[] InnerArray { get; set; }

    public Array(int size = 16)
    {
        InnerArray = new Object[size];
    }

}
