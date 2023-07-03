using System.Collections;

namespace LinkedList
{
	public class CustomLinkedList<T> : IEnumerable<T>
	{
		public Node<T> Head { get; private set; }

		public Node<T> Tail { get; private set; }

		public void AddFirst(T data)
		{
			Node<T> node = new(data);

			if (Head is null)
			{
				Head = node;
				Tail = node;
			}
			else
			{
				node.Next = Head;
				Head = node;
			}
		}

		public void AddLast(T data)
		{
			Node<T> node = new(data);

			if (Head is null)
			{
				Head = node;
				Tail = node;
			}
			else
			{
				Tail.Next = node;
				Tail = node;
			}
		}

		public void AddLast(IEnumerable<T> data)
		{
			foreach (var item in data)
			{
				AddLast(item);
			}
		}

		public void RemoveFirst()
		{
			if (Head is not null)
			{
				Head = Head.Next;
			}
		}

		public void RemoveLast()
		{
			if (Head is null)
			{
				return;
			}

			if (Head == Tail)
			{
				Head = Tail = null;
				return;
			}

			var previous = Head;
			while (previous.Next != Tail)
			{
				previous = previous.Next;
			}

			Tail = previous;
			Tail.Next = null;
		}

		public void RemoveWithValue(T data)
		{
			if (Head is null)
			{ return; }
			Node<T> current = Head;
			Node<T> previous = null;

			while (current is not null)
			{
				if (current.Data.Equals(data))
				{
					if (current == Head)
					{
						Head = current.Next;
					}
					else
					{
						previous.Next = current.Next;
					}
					if (current == Tail)
					{
						Tail = previous;
					}
					return;
				}

				previous = current;
				current = current.Next;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)GetEnumerator();
		}

		public IEnumerator<T> GetEnumerator()
		{
			Node<T> current = Head;
			while (current is not null)
			{
				yield return current.Data;
				current = current.Next;
			}
		}

	}

	public class Node<T>
	{
		public T Data { get; set; }

		public Node<T> Next { get; set; }

		public Node(T data)
		{
			Data = data;
		}

		public override string ToString() => $"Data: {Data}";
	}

}

