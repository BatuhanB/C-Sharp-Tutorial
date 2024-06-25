namespace DataStructers.Array;
internal static class ArrayHelpers
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
}