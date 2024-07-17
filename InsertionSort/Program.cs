using InsertionSort;

int[] nums = [3, 5, 2, 8, 6, 85, 1, 7, 23, 12];
var insertionSort = new MyInsertionSort();

insertionSort.Sort(nums);

foreach (int i in nums)
{
    Console.Write($"{i}  ");
}