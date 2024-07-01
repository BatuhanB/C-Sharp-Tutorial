using System.Collections;

namespace DataStructers.Array;

public class Array : ICloneable, IEnumerable
{
    public int Length => InnerArray.Length;
    protected Object[] InnerArray { get; set; }
    // Default constructor with a size of 16
    public Array(int size = 16)
    {
        ArrayHelpers.CheckIfSizeOfArrayValid(size);
        InnerArray = new Object[size];
    }
    // Constructor that takes an array and initializes the internal array with its elements
    public Array(params Object[] sourceArray) : this(sourceArray?.Length ?? 0)
    {
        ArrayHelpers.CheckIfSourceArrayNull(sourceArray);
        System.Array.Copy(sourceArray, InnerArray, sourceArray.Length);
    }
    public Object GetValue(int index)
    {
        ArrayHelpers.CheckIfIndexValid(index, InnerArray.Length);
        return InnerArray[index];
    }
    public void SetValue(Object value, int index)
    {
        ArrayHelpers.CheckIfIndexValid(index, InnerArray.Length);
        ArrayHelpers.CheckIfValueNull(value);
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
    public virtual IEnumerator GetEnumerator()
    {
        //return InnerArray.GetEnumerator();
        return new CustomArrayEnumerator(InnerArray);
    }
    public class CustomArrayEnumerator(object[] array) : IEnumerator
    {
        private Object[] _array = array;
        private int _index = -1;

        public object Current => _array[_index];

        public bool MoveNext()
        {
            if (_index < _array.Length - 1)
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

    public int IndexOf(Object value)
    {
        for (int i = 0; i < InnerArray.Length; i++)
        {
            if (InnerArray[i].Equals(value))
                return i;
        }
        return -1;
    }
}
