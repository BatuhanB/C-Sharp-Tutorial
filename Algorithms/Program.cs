using System;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var binarySearch = new BinarySearch();

            var result = binarySearch.Search(new[] { -1, 2, 3, 5, 12, 24 }, 12);
            Console.WriteLine($"Target Index: {result}");
            Console.WriteLine("******************************");
            var result2 = binarySearch.SearchInsert(new[] { 1, 3, 5, 6 }, 6);
            var result3 = binarySearch.SearchInsert(new[] { 1, 3, 5, 6 }, 8);
            Console.WriteLine($"Target Index: {result2}");//3
            Console.WriteLine($"Target Index: {result3}");//4
        }
    }
}
