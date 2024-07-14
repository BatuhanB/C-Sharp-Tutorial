namespace SelectionSort;
public class MySelectionSort
{
    // [1,3,5,2,6,85,23,12]
    public void Sort(params int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            var minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if(arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            (arr[minIndex], arr[i]) = (arr[i], arr[minIndex]);
        }
    }
}
