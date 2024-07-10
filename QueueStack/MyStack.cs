namespace QueueStack;
public class MyStack<T>
{
    private const int DEFAULT_SIZE = 50;
    private T[] elements;
    private int top = -1;

    // | 1, 2, 3, 4, 5
    public MyStack(int initialSize = DEFAULT_SIZE)
    {
        elements = new T[initialSize];
    }

    public void Push(T element)
    {
        if (top == elements.Length - 1)
        {
            Extend();
        }
        top++;
        elements[top] = element;
    }

    public T Pop()
    {
        T element = elements[top];
        elements[top] = default;
        top--;

        if (top > 0)
        {
            Shrink();
        }
        return element;
    }

    private void Extend()
    {
        var newArray = new T[elements.Length * 2];
        Array.Copy(elements, newArray, elements.Length);
    }

    private void Shrink()
    {
        var newArray = new T[elements.Length / 2];
        Array.Copy(elements, 0, newArray, 0, top + 1);
        elements = newArray;
    }
}
