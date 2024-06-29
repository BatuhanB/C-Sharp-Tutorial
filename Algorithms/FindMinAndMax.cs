using System.Collections.Generic;
using System;

namespace Algorithms;
public static class FindMinAndMax
{
    public static void FindMinAndMaxM()
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


        int min = arr[0];
        int max = arr[0];

        for (int i = 1; i < arr.Count; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }

            if (max < arr[i])
            {
                max = arr[i];
            }
        }

        Console.WriteLine($"Min => {min} \t Max => {max}");
    }
}