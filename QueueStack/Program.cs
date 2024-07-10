using QueueStack;

//Queue();
Stack();

static void Queue()
{
    var queue = new MyQueue<int>(10);


    //Console.WriteLine(queue);

    queue.Enqueue(1);
    queue.Enqueue(2);
    queue.Enqueue(3);
    queue.Enqueue(4);
    queue.Enqueue(5);
    queue.Enqueue(6);

    var firstElement = queue.Dequeue();

    Console.WriteLine(firstElement);

    Console.ReadKey();
}

static void Stack()
{
    var stack = new Stack<int>();
    stack.Push(1);
    stack.Push(2);
    stack.Push(3);
    stack.Push(4);
    stack.Push(5);

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(stack.Pop());
    }

    Console.ReadKey();
}