﻿namespace DataStructers.Array;

public class ArrayList : Array
{
    private int position;
    public int Count => position;

    public ArrayList(int defaultSize = 2) : base(defaultSize)
    {
        position = 0;
    }

    //public ArrayList(params Object[] objects) : base(objects) { }

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

    public Object Remove()
    {
        if (position >= 0)
        {
            var temp = InnerArray[position - 1];
            position--;
            if (position == (InnerArray.Length / 4))
            {
                DivideArray();
            }
            return temp;
        }
        throw new Exception();

    }
    private void DivideArray()
    {
        try
        {
            var temp = new Object[InnerArray.Length / 2];
            System.Array.Copy(InnerArray, temp, InnerArray.Length / 2);
            InnerArray = temp;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
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