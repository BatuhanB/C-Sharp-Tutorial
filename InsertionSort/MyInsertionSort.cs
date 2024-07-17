namespace InsertionSort;
public class MyInsertionSort
{
    /// <summary>
    /// Assign 1. index which is i at the array and j = i - 1 
    /// Check numbers to the left whether the numbers on the left(j) are bigger than the current(i) number
    /// If the numbers on the left are bigger than current number assign it's value to current number but keep the current number's value
    /// After iteratation completed to the left assign current number to (j+1). element
    /// </summary>
    /// <param name="arr"></param>
    public void Sort(params int[] arr)
    {
        //          Array           |CurrentVal(index)  |CompareVal(index)
        // [|3|,(5),2,8,6,85,1,7,23,12] i=5(1)              j=3(0) 
        // [3,|5|,(2),8,6,85,1,7,23,12] i=2(2)              j=5(1)          [3,|5|,(5),8,6,85,1,7,23,12]
        // [|3|,5,(5),8,6,85,1,7,23,12] i=2(2)              j=3(0)          [|3|,3,(5),8,6,85,1,7,23,12]
        // [2,3,|5|,(8),6,85,1,7,23,12] i=8(3)              j=5(2)          
        // [2,|3|,5,(8),6,85,1,7,23,12] i=8(3)              j=5(2)          
        // [|2|,3,5,(8),6,85,1,7,23,12] i=8(3)              j=5(2)          
        // [2,3,5,|8|,(6),85,1,7,23,12] i=6(4)              j=8(3)          [2,3,5,|8|,(8),85,1,7,23,12]
        // [2,3,|5|,8,(6),85,1,7,23,12] i=6(4)              j=8(3)          
        // [2,|3|,5,8,(6),85,1,7,23,12] i=6(4)              j=8(3)          
        // [|2|,3,5,8,(6),85,1,7,23,12] i=6(4)              j=8(3)          
        // [2,3,5,6,|8|,(85),1,7,23,12] i=85(5)             j=8(4)          
        // [2,3,5,|6|,8,(85),1,7,23,12] i=85(5)             j=8(4)          
        // [2,3,|5|,6,8,(85),1,7,23,12] i=85(5)             j=8(4)          
        // [2,|3|,5,6,8,(85),1,7,23,12] i=85(5)             j=8(4)          
        // [|2|,3,5,6,8,(85),1,7,23,12] i=85(5)             j=8(4)          
        //            ...

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
