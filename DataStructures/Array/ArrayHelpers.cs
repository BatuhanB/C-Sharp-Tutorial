namespace DataStructers.Array;
internal static class ArrayHelpers<T>
{
    internal static void CheckIfSizeOfArrayValid(int size)
    {
        if (size < 0)
            throw new ArgumentOutOfRangeException(nameof(size), "Size must be non-negative!");
    }

    internal static void CheckIfSourceArrayNull(Object[] sourceArray)
    {
        if (sourceArray == null)
            throw new ArgumentNullException(nameof(sourceArray), "Source array cannot be null.");
    }
    internal static void CheckIfSourceArrayNullT(T[] sourceArray)
    {
        if (sourceArray == null)
            throw new ArgumentNullException(nameof(sourceArray), "Source array cannot be null.");
    }

    internal static void CheckIfIndexValid(int index,int innerArrayLength)
    {
        if (!(index >= 0 && index < innerArrayLength))
            throw new ArgumentOutOfRangeException(nameof(index), "Index out of range!");
    }

    internal static void CheckIfValueNull(object value)
    {
        if (value == null)
            throw new ArgumentNullException(nameof(value), "Value can not be null!");
    }
}