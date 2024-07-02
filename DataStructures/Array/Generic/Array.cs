using DataStructers.Array;
using System.Collections;

namespace Array.Generic;
public class Array<T> : IEnumerable<T>, ICloneable
{
    private int position;
    public int Count => position;
    public int Length => InnerArray.Length;

    public Array(int defaultSize = 2)
    {
        position = 0;
        InnerArray = new T[defaultSize];
    }
    public Array(IEnumerable<T> collection) : this()
    {
        foreach (var item in collection)
        {
            Add(item);
        }
    }
    protected T[] InnerArray { get; set; }
    public Array(params T[] sourceArray) : this(sourceArray?.Length ?? 0)
    {
        ArrayHelpers<T>.CheckIfSourceArrayNullT(sourceArray);
        System.Array.Copy(sourceArray, InnerArray, sourceArray.Length);
    }
    public T GetValue(int index)
    {
        ArrayHelpers<T>.CheckIfIndexValid(index, InnerArray.Length);
        return InnerArray[index];
    }
    public void SetValue(T value, int index)
    {
        ArrayHelpers<T>.CheckIfIndexValid(index, InnerArray.Length);
        ArrayHelpers<T>.CheckIfValueNull(value);
        InnerArray[index] = value;
    }
    public override string ToString()
    {
        var result = string.Empty;
        if (InnerArray != null)
        {
            foreach (var item in InnerArray)
            {
                result += $"{item} ";
            }
        }
        else
        {
            result = "No argument has found!";
        }
        return result;
    }
    public object Clone()
    {
        return MemberwiseClone();
    }
    public int IndexOf(T value)
    {
        for (int i = 0; i < InnerArray.Length; i++)
        {
            if (InnerArray[i].Equals(value))
                return i;
        }
        return -1;
    }
    public void Add(T value)
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
    public T Remove()
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
            var temp = new T[InnerArray.Length / 2];
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
            var temp = new T[InnerArray.Length * 2];
            System.Array.Copy(InnerArray, temp, InnerArray.Length);
            InnerArray = temp;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public IEnumerator<T> GetEnumerator()
    {
        return new ArrayEnumerator<T>(InnerArray);
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private class ArrayEnumerator<T> : IEnumerator<T>
    {
        private T[] _array;
        private int _index;

        public ArrayEnumerator(T[] array)
        {
            array = _array;
            _index = -1;
        }

        public T Current => _array[_index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _array = null;
        }

        public bool MoveNext()
        {
            if(_index < _array.Length - 1)
            {
                _index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}