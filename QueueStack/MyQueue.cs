namespace QueueStack;
public class MyQueue<T>
{
    private const int DEFAULT_SIZE = 50;
    private T[] elements;
    private int head = 0;
    private int tail = -1;
    private int count = 0;


    // head => 1, 2, 3, 5, 6,<= tail 0, 0, 0, 0, 0
    public MyQueue(int initialSize = DEFAULT_SIZE)
    {
        elements = new T[initialSize];
    }

    public void Enqueue(T item)
    {
        if (count == elements.Length - 1)
        {
            Extend();
        }
        tail++;
        elements[tail] = item;
        count++;
    }

    public T Dequeue()
    {
        ThrowIsEmpty();
        T item = elements[head];
        elements[head] = default;
        head++;
        count--;

        if (count > 0 && count == elements.Length / 4)
        {
            Shrink();
        }

        return item;
    }

    private void ThrowIsEmpty()
    {
        if (IsEmpty()) throw new ArgumentNullException("Queue is empty");
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    private void Extend()
    {
        Array.Resize(ref elements, elements.Length * 2);
        head = 0;
        tail = count - 1;
    }

    private void Shrink()
    {
        int capacity = elements.Length / 2;
        var newArray = new T[capacity];
        Array.Copy(elements,head, newArray, 0, count);
        elements = newArray;
        head = 0;
        tail = count - 1;
    }

    public override string ToString()
    {
        var res= string.Empty;
        foreach (var item in elements)
        {
            res += item;
        }
        return res;
    }
}
