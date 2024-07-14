namespace InsertionSort;
public class MyInsertionSort
{
    // [12,3,5,2,6,85,23,13]
    public void Sort(params int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int current = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > current)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = current;
        }
    }
}
