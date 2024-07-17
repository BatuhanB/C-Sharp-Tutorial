namespace InsertionSort;
public class MyInsertionSort
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="arr"></param>
    public void Sort(params int[] arr)
    {
        //          Array           |CurrentVal(index)  |CompareVal(index)
        // [|3|,(5),2,8,6,85,1,7,23,12] i=5(1)              j=3(0) 
        // [3,|5|,(2),8,6,85,1,7,23,12] i=2(2)              j=5(1)          [3,|5|,(5),8,6,85,1,7,23,12]
        // [|3|,5,(5),8,6,85,1,7,23,12] i=2(2)              j=3(0)          [|3|,2,(5),8,6,85,1,7,23,12]
        for (int i = 1; i < arr.Length; i++)
        {
            int current = arr[i];
            int j = i - 1;
            int jVal = arr[j];

            while (j >= 0 && arr[j] > current)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = current;
        }
    }
}
