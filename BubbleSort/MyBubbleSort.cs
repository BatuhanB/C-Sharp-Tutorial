namespace BubbleSort;
public class MyBubbleSort
{
    /// <summary>
    /// Check i. element with the (i+1). if it is bigger.
    /// If it's bigger change pozitions and next.
    /// But do not check the last element in each loop, because we put the biggest element to the end.
    /// It keep iterates through array until it finally sorted
    /// </summary>
    /// <param name="data"></param>
    
    public void Sort(params int[] data)
    {
        // First iteration until find the biggest number in the array and put it in the end
        // [(1),3,5,2,8,6,85,7,23,12] j=> 0
        // [1,(3),5,2,8,6,85,7,23,12] j=> 1
        // [1,3,(5),2,8,6,85,7,23,12] j=> 2
        // [1,3,2,(5),8,6,85,7,23,12] j=> 3
        // [1,3,2,5,(8),6,85,7,23,12] j=> 4
        // [1,3,2,5,6,(8),85,7,23,12] j=> 5
        // [1,3,2,5,6,8,(85),7,23,12] j=> 6
        // [1,3,2,5,6,8,7,(85),23,12] j=> 7
        // [1,3,2,5,6,8,7,23,(85),12] j=> 8
        // [1,3,2,5,6,8,7,23,12,(85)] j=> 9

        for (int i = 0; i < data.Length - 1; i++)
        {
            for (int j = 0; j < data.Length - i - 1; j++)
            {
                if (data[j] > data[j + 1])
                {
                    (data[j + 1], data[j]) = (data[j], data[j + 1]);
                }
            }
        }
    }
}
