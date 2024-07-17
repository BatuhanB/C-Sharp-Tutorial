namespace SelectionSort;
public class MySelectionSort
{
    /// <summary>
    /// Iterate through array until fund the smallest number in the array
    /// After found the smallest number's index we swap the i. element and smallest number's index
    /// To select the smallest element in the array first pick the first element in the array and compare it with the others
    /// </summary>
    /// <param name="arr"></param>
    public void Sort(params int[] arr)
    {
        //          Array            FirstVal(index) |CurrentVal(index) |MinVal(index)
        // [3,(5),2,8,6,85,1,7,23,12]    i=3(0);      j=5(1);            minIndex=3(2)
        // [3,5,(2),8,6,85,1,7,23,12]    i=3(0);      j=2(2);            minIndex=2(2)*
        // [3,5,2,(8),6,85,1,7,23,12]    i=3(0);      j=8(3);            minIndex=2(2)
        // [3,5,2,8,(6),85,1,7,23,12]    i=3(0);      j=6(4);            minIndex=2(2)
        // [3,5,2,8,6,(85),1,7,23,12]    i=3(0);      j=85(5);           minIndex=2(2)
        // [3,5,2,8,6,85,(1),7,23,12]    i=3(0);      j=1(6);            minIndex=1(6)*
        // [3,5,2,8,6,85,1,(7),23,12]    i=3(0);      j=7(7);            minIndex=1(6)
        // [3,5,2,8,6,85,1,7,(23),12]    i=3(0);      j=23(8);           minIndex=1(6)
        // [3,5,2,8,6,85,1,7,23,(12)]    i=3(0);      j=12(9);           minIndex=1(6)

        // After first iteration we found the smallest number at 6. index which is 1
        // Swapped the values with i.(0) and 6. index values to put smallest number in first place
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
