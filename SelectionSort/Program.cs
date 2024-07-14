using SelectionSort;

int[] arr = [1,3,5,2,6,85,23,12];
var selectionSort = new MySelectionSort();

selectionSort.Sort(arr);

foreach (int i in arr)
{
    Console.Write($"{i}  ");
}
Console.ReadKey();