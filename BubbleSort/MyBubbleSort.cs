namespace BubbleSort;
public class MyBubbleSort
{
    // [1,3,5,2,6,85,23,12]
    public void Sort(params int[] data)
    {
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
