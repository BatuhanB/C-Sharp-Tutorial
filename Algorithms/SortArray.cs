using System.Collections.Generic;
using System;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Linq;

namespace Algorithms;
public static class SortArray
{
    // 3,6,1,9,12,7,24,21,45,32
    private readonly static List<int> arr =
    [
        63,
        3,
        6,
        1,
        9,
        12,
        7,
        24,
        21,
        45,
        32,
        63
    ];
    public static void SortArrayM()
    {
        var sortedArr = new List<int>();

        while (arr.Count > 0)
        {
            var target = arr[0];
            foreach (int i in arr)
            {
                if (target > i)
                {
                    target = i;
                }
            }
            sortedArr.Add(target);
            arr.Remove(target);
        }

        foreach (int i in sortedArr)
        {
            Console.WriteLine($"{i}\t");
        }
    }

    public static void SortArray_Hash_Table()
    {
        var hashArray = new Hashtable();

        foreach (int num in arr)
        {
            if (hashArray.ContainsKey(num))
            {
                hashArray[num] = (int)hashArray[num] + 1;
            }
            else
            {
                hashArray[num] = 1;
            }
        }

        // Sort the keys of the Hashtable
        var sortedKeys = new List<int>(hashArray.Keys.Cast<int>());
        sortedKeys.Sort();

        // Build the sorted array
        var sortedArr = new List<int>();
        foreach (int key in sortedKeys)
        {
            for (int i = 0; i < (int)hashArray[key]; i++)
            {
                sortedArr.Add(key);
            }
        }

        // Print the sorted array
        foreach (int i in sortedArr)
        {
            Console.WriteLine($"{i}\t");
        }


    }
}
