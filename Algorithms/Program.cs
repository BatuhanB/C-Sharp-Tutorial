using Course.Web.Handler;
using System;
using static Algorithms.BinaryTree;
using static Algorithms.Graphs;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FizzBuzz

            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 4, 8, 9, 10, 11, 12, 13, 14, 15 };
            //foreach (int i in arr)
            //{
            //	if (i % 3 == 0)
            //	{
            //		Console.WriteLine($" The fizz is => {i}");
            //	}
            //	if (i % 5 == 0)
            //	{
            //		Console.WriteLine($" The buzz is => {i}");
            //	}
            //	if (i % 15 == 0)
            //	{
            //		Console.WriteLine($" The fizz buzz is => {i}");
            //	}

            //}
            #endregion

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

            //Console.WriteLine($"Enter the temperatures: ");
            //var text1 = Console.ReadLine();
            //var text2 = Console.ReadLine();
            //int temp1 = int.Parse(text1);
            //int temp2 = int.Parse(text2);
            //var result = basicAlgorithms.CheckTemperatures(temp1,temp2);

            //Console.WriteLine($"The result of CheckTemperatures : {result}");
            //Console.ReadLine();

            #endregion

            #region LongestCommonPrefix

            //LongestCommonPrefix longestCommonPrefix = new();
            //string[] strs = new string[] { "flower", "flow", "flight" };

            //var result = longestCommonPrefix.FindLongestCommonPrefix(strs);
            //Console.Write($"The Longest Common Prefix of : ");
            //foreach (string str in strs)
            //{
            //    Console.Write($"{str} - ");
            //}
            //Console.WriteLine($"| {result} |");
            #endregion

            #region Graphs

            TreeNode root = new('a');
            TreeNode node2 = new('b');
            TreeNode node3 = new('c');
            TreeNode node4 = new('d');
            TreeNode node5 = new('e');
            TreeNode node6 = new('f');

            root.AddChild(node3);
            root.AddChild(node2);
            node2.AddChild(node4);
            node3.AddChild(node5);
            node4.AddChild(node6);

            // a: ['c','b']
            // b: ['d']
            // c: ['e']
            // d: ['f']
            // e: []
            // f: []

            //#region DepthFirstTraversal

            //Console.WriteLine("Depth-first traversal:");
            //Graphs.DepthFirstTraversal(root);// a,c,e,b,d,f
            //Console.WriteLine();


            //#endregion

            //#region BreadthFirstTraversal

            //Console.WriteLine("Breadth-first traversal:");
            //Graphs.BreadthFirstTraversal(root);//a,c,b,e,d,f
            //Console.WriteLine();

            //#endregion

            #endregion

            #region FindDuplicate

            //FindDuplicate findDuplicate = new();

            //var result = findDuplicate.Find([1, 3, 2, 3, 4, 6, 6, 7]);
            //var result2 = findDuplicate.FindAndRemove([1, 3, 2, 3, 4, 6, 6, 7]);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}

            //foreach (var item in result2)
            //{
            //    Console.Write(item + " ");

            //}


            #endregion

            #region TestStatic

            //TestStatic test = new ();
            //test.MyMethod1();
            //TestStatic.MyMethod2();

            #endregion

            #region Recursive

            var rec = new Recursive();

            //rec.WriteElements_Recursive(0);

            //Console.WriteLine(rec.FindNumber_Recursive(0, 526));

            #endregion

            #region SortArray

            //SortArray.SortArray_Hash_Table();

            #endregion

            #region BinaryTree

            //              8
            //            /   \             
            //           /     \
            //          6      10
            //         / \     / \
            //        3   7   11  12
            //         \           \
            //          4          14

            var rootNode = new Node(8);

            AddNode(rootNode,10);
            AddNode(rootNode,6);
            AddNode(rootNode,3);
            AddNode(rootNode,12);
            AddNode(rootNode,4);
            AddNode(rootNode,14);
            AddNode(rootNode,7);
            AddNode(rootNode,11);

            Traverse(rootNode);

            Console.WriteLine("---------------------");

            FindNode(rootNode,14);

            Console.ReadKey();
            #endregion
        }
    }
}
