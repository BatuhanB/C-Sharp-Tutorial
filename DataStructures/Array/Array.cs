namespace DataStructers.Array;

public class Array
{
    public int Length => InnerArray.Length;
    private Object[] InnerArray { get; set; }

    // Default constructor with a size of 16
    public Array(int size = 16)
    {
        ArrayHelpers.CheckIfSizeOfArrayValid(size);
        InnerArray = new Object[size];
    }

    // Constructor that takes an array and initializes the internal array with its elements
    public Array(params Object[] sourceArray) : this(sourceArray?.Length ?? 0)
    {
        ArrayHelpers.CheckIfSourceArrayNull(sourceArray);
        System.Array.Copy(sourceArray,InnerArray,sourceArray.Length);
    }
}