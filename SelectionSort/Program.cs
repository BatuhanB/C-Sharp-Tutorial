using SelectionSort;

int[] arr = [3, 5, 2, 8, 6, 85, 1, 7, 23, 12];
var selectionSort = new MySelectionSort();

selectionSort.Sort(arr);

foreach (int i in arr)
{
    Console.Write($"{i}  ");
}
Console.ReadKey();