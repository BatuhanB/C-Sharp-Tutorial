﻿namespace ValueAndReferenceTypes;

public class ReferenceType
{
    public int X { get; set; }
    public int Y { get; set; }

    public ReferenceType(int x, int y)
    {
        X = x;
        Y = y;
    }

    public ReferenceType()
    {
        
    }
    
    public void Swap(ref int x, ref int y)
    {
        var temp = x;
        x = y;
        y = temp;
    }

    public void SwapOut(out int x)
    {
        x = 100;
        return;
    }
    public override int GetHashCode()
    {
        return (X + Y).GetHashCode();
    }

}
