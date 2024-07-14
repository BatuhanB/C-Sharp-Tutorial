using InsertionSort;

int[] nums = [12, 3, 5, 2, 6, 85, 23, 13];
var insertionSort = new MyInsertionSort();

insertionSort.Sort(nums);

foreach (int i in nums)
{
    Console.Write($"{i}  ");
}