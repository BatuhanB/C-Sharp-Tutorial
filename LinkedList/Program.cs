
using LinkedList;

CustomLinkedList<int> list = new();

list.AddLast(1);
list.AddFirst(5);
list.AddLast(3);
list.AddLast(2);

void Print()
{
	foreach (var item in list)
	{
		Console.WriteLine(item);
	}
}

Print();