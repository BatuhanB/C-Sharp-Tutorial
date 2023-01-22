using System;

namespace Algorithms
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region BinarySearch

			//var binarySearch = new BinarySearch();

			//var result = binarySearch.Search(new[] { -1, 2, 3, 5, 12, 24 }, 12);
			//Console.WriteLine($"Target Index: {result}");
			//Console.WriteLine("******************************");

			//var result2 = binarySearch.SearchInsert(new[] { 1, 3, 5, 6 }, 6);
			//var result3 = binarySearch.SearchInsert(new[] { 1, 3, 5, 6 }, 8);
			//Console.WriteLine($"Target Index: {result2}");//3
			//Console.WriteLine($"Target Index: {result3}");//4
			//Console.WriteLine("******************************");

			//var result4 = binarySearch.SortedSquaredArray(new[] { -8, -4, -2, 0, 1, 3, 5, 6, 9 });
			//Console.WriteLine($"Original Array: [-8, -4, -2, 0, 1, 3, 5, 6, 9 ]");
			//Console.Write($"Squared Array Elements: ");
			//Console.Write(" [");
			//foreach (var item in result4)
			//{
			//	Console.Write($"{item} , ");
			//}

			//Console.WriteLine("]");
			//Console.WriteLine("******************************");

			//var result5 = binarySearch.MoveZeroes(new[] { 0, 1, 0, 3, 12 });
			//Console.Write($"Sorted Array Elements: ");
			//Console.Write(" [");
			//foreach (var item in result5)
			//{
			//	Console.Write($"{item} , ");
			//}

			//Console.WriteLine("]");
			//Console.WriteLine("******************************");



			#endregion

			#region LeetCode

			//var leetCode = new LeetCode();
			////var result6 = leetCode.PlusOne(new[] { 2, 3, 4, 5 });
			//var result6 = leetCode.PlusOne(new[] { 1, 9, 9, 9 });

			//Console.Write("[");
			//foreach (var item in result6)
			//{
			//	Console.Write($"{item},");
			//}
			//Console.Write("]");

			//Console.WriteLine("***************************************************");
			//Console.WriteLine(leetCode.Sum("12","23"));
			#endregion

			#region Basic Algorithms AddLastChar

			Basic basicAlgorithms = new();

			//Console.WriteLine($"Enter the input: ");
			//var text = Console.ReadLine();
			//text = text.ToString();
			//var result = basicAlgorithms.AddLastChar(text);

			//Console.WriteLine($"The result of AddLastChar : {result}");
			//Console.ReadLine();

			#endregion

			#region Basic Algorithms2 CheckDividers

			//var input = Console.ReadLine();
			//int number = int.Parse(input);

			//var result = basicAlgorithms.CheckDividers(number);


			//Console.WriteLine($"The result is : {result}");

			#endregion

			#region BasicAlgorithm3 AddThreeChar


			//Console.WriteLine($"Enter the input: ");
			//var text = Console.ReadLine();
			//text = text.ToString();
			//var result = basicAlgorithms.AddThreeChar(text);

			//Console.WriteLine($"The result of AddThreeChar : {result}");
			//Console.ReadLine();

			#endregion

			#region BasicAlgorithm4 CheckIfStartsWithCsharp

			//Console.WriteLine($"Enter the input: ");
			//var text = Console.ReadLine();
			//text = text.ToString();
			//var result = basicAlgorithms.CheckIfStartsWithCsharp(text);

			//Console.WriteLine($"The result of CheckIfStartsWithCsharp : {result}");
			//Console.ReadLine();

			#endregion

			#region BasicAlgorithm4 CheckTemperatures

			//Console.WriteLine($"Enter the temperatures: ");
			//var text1 = Console.ReadLine();
			//var text2 = Console.ReadLine();
			//int temp1 = int.Parse(text1);
			//int temp2 = int.Parse(text2);
			//var result = basicAlgorithms.CheckTemperatures(temp1,temp2);

			//Console.WriteLine($"The result of CheckTemperatures : {result}");
			//Console.ReadLine();

			#endregion
			
			#region BasicAlgorithm4 CheckTemperatures

			Console.WriteLine($"Enter the temperatures: ");
			var text1 = Console.ReadLine();
			var text2 = Console.ReadLine();
			int temp1 = int.Parse(text1);
			int temp2 = int.Parse(text2);
			var result = basicAlgorithms.CheckTemperatures(temp1,temp2);

			Console.WriteLine($"The result of CheckTemperatures : {result}");
			Console.ReadLine();

			#endregion
		}
	}
}
