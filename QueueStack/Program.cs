using QueueStack;

var queue = new MyQueue<int>(1);


//Console.WriteLine(queue);

queue.Enqueue(1);
queue.Enqueue(2);

var firstElement = queue.Dequeue();

Console.WriteLine(firstElement);

Console.ReadKey();