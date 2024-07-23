
using LinkedList;

CustomLinkedList<int> list = new();

list.AddLast(1);
list.AddLast(3);
list.AddLast(5);
list.AddLast(2);
list.AddFirst(11);

void Print()
{
	foreach (var item in list)
	{
		Console.WriteLine(item);
	}
}

Print();

list.FindElement(2);

Console.WriteLine("--------------");

list.FindElement(11);

Console.ReadKey();