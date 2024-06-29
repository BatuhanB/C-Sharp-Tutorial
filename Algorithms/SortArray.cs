using System.Collections.Generic;
using System;

namespace Algorithms;
public static class SortArray
{
    public static void SortArrayM()
    {
        // 3,6,1,9,12,7,24,21,45,32
        var arr = new List<int>
        {
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
            32
        };

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
}
