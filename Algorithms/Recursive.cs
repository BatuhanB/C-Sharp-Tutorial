using System;

namespace Algorithms;
public class Recursive
{
    private int[] arr = { 2, 3, 12, 56, 76, 97, 45, 65, 11, 45 };
    public int WriteElements_Recursive(int index)
    {
        if (index < arr.Length)
        {
            Console.WriteLine(arr[index]);
            index++;
            return WriteElements_Recursive(index);
        }
        return -1;
    }

    public int FindNumber_Recursive(int index, int value)
    {
        if(index >= arr.Length)
            return -1;

        if (index < arr.Length)
        {
            if (value == arr[index])
            {
                return index;
            }
            else
            {
                index++;
            }
        }
        return FindNumber_Recursive(index, value);
    }
}
