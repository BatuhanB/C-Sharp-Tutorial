namespace DataStructers.Array;

public class ArrayList : Array
{
    private int position;
    public int Count => position;

    public ArrayList(int defaultSize = 2) : base(defaultSize)
    {
        position = 0;
    }

    public void Add(Object value)
    {
        if (position == Length)
        {
            DoubleArray();
        }
        if (position < Length)
        {
            InnerArray[position] = value;
            position++;
            return;
        }
        throw new Exception();
    }

    private void DoubleArray()
    {
        try
        {
            var temp = new Object[InnerArray.Length * 2];
            System.Array.Copy(InnerArray, temp, InnerArray.Length);
            InnerArray = temp;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}