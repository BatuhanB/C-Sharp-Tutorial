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
            Console.WriteLine("******************************");

            var result4 = binarySearch.SortedSquaredArray(new[] { -8, -4, -2, 0, 1, 3, 5, 6, 9 });
            Console.WriteLine($"Original Array: [-8, -4, -2, 0, 1, 3, 5, 6, 9 ]");
            Console.Write($"Squared Array Elements: ");
            Console.Write(" [");
            foreach (var item in result4)
            {
                Console.Write($"{item} , ");
            }
            
            Console.WriteLine("]");
            Console.WriteLine("******************************");

            var result5 = binarySearch.MoveZeroes(new[] { 0, 1, 0, 3, 12 });
            Console.Write($"Sorted Array Elements: ");
            Console.Write(" [");
            foreach (var item in result5)
            {
                Console.Write($"{item} , ");
            }
            
            Console.WriteLine("]");
            Console.WriteLine("******************************");
        }
    }
}
