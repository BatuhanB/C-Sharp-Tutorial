using System;

namespace Algorithms;
public class FindDuplicate
{
    public int[] Find(int[] arr)
    {
        var result = new int[arr.Length];
        int temp = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            temp = arr[i];
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (temp == arr[j])
                {
                    result[i] = arr[j];
                }
            }
        }
        return result;
    }
    public int[] FindAndRemove(int[] arr)
    {
        int count = arr.Length;
        for (int i = 0; i < count; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (arr[i] == arr[j])
                {
                    // Shift elements to the left to overwrite the duplicate
                    for (int k = j; k < count - 1; k++)
                    {
                        arr[k] = arr[k + 1];
                    }
                    count--; // Reduce the size of the array
                    j--; // Adjust the index to recheck the current position
                }
            }
        }

        // Create a new array with distinct elements
        int[] distinctNumbers = new int[count];
        Array.Copy(arr, distinctNumbers, count);
        return arr;
    }
}