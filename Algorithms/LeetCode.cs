using System;
using System.Text;

namespace Algorithms
{
	public class LeetCode
	{
		#region Palindrome Number
		////Given an integer x, return true if x is palindrome integer.
		////An integer is a palindrome when it reads the same backward as forward.
		////For example, 121 is a palindrome while 123 is not.
		// bool IsPalindrome(int x)
		// {
		//     if (x == 0)
		//     {
		//         return true;
		//     }
		//     if (x < 0 || x % 10 == 0)
		//     {
		//         return false;
		//     }

		//     var sum = 0;
		//     var reverseNumber = x;

		//     while (reverseNumber != 0)
		//     {
		//         var remainder = reverseNumber % 10;
		//         reverseNumber /= 10;
		//         sum = (sum * 10) + remainder;
		//     }
		//     return sum == x;
		// }
		// Console.WriteLine(IsPalindrome(121));
		#endregion
		#region TwoSum
		////Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
		////Input: nums = [2,7,11,15], target = 9
		//// Output: [0,1]
		//// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

		//int[] TwoSum(int[] nums, int target)
		//{
		//    var dict = new Dictionary<int, int>();
		//    var i = 0;
		//    for (; i < nums.Length; i++)
		//    {
		//        var compliment = target - nums[i];
		//        if (dict.TryGetValue(compliment, out var index))
		//        {
		//            return new[] { index, i };
		//        }

		//        dict[nums[i]] = i;
		//    }

		//    return new [] { 0, 1 };
		//}

		//var result = TwoSum(new[] { 1, 12, 42, 3, 8 }, 20);
		//foreach (var item in result)
		//{
		//    Console.Write($"Index: {item} ");
		//}
		#endregion
		#region ContainsDuplicate
		////Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
		////Input: nums = [1,2,3,1]
		////Output: true
		//bool ContainsDuplicate(int[] nums)
		//{
		//    var hashSet = new HashSet<int>();
		//    foreach (var itemNum in nums)
		//    {
		//        if (hashSet.Contains(itemNum))
		//        {
		//            return true;
		//        }   
		//        hashSet.Add(itemNum);
		//    }
		//    return false;
		//}

		//Console.WriteLine(ContainsDuplicate(new []{1,2,2,12,44,23,56,43}));
		#endregion
		#region Baseball Game

		//An integer x - Record a new score of x.
		//"+" - Record a new score that is the sum of the previous two scores. It is guaranteed there will always be two previous scores.
		//"D" - Record a new score that is double the previous score. It is guaranteed there will always be a previous score.
		//"C" - Invalidate the previous score, removing it from the record. It is guaranteed there will always be a previous score.
		////Input: ops = ["5","2","C","D","+"]
		////Output: 30

		//int CalPoints(string[] ops)
		//{
		//    var stack = new Stack<int>();
		//    foreach (var str in ops)
		//    {
		//        if (str == "+")
		//        {
		//            var prev = stack.Pop();
		//            var sum = prev + stack.Peek();
		//            stack.Push(prev);
		//            stack.Push(sum);
		//        }else if (str == "D")
		//        {
		//            stack.Push(stack.Peek() * 2);
		//        }else if (str == "C")
		//        {
		//            stack.Pop();
		//        }
		//        else
		//        {
		//            stack.Push(int.Parse(str));
		//        }
		//    }

		//    int result = 0;
		//    while (stack.Count > 0) 
		//    {
		//        result += stack.Pop();
		//    }
		//    return result;
		//}
		////Console.WriteLine(CalPoints(new[] {"45", "C", "12", "D", "+"}));//output:36
		////[45] - [] - [12] - [12,24] - [12,24,36] - [72]
		//Console.WriteLine(CalPoints(new[] {"5","2","C","D","+"}));//output:36

		#endregion


		#region PlusOne
		//Question Down Below

		/* Input: digits = [1,2,3]
           Output: [1,2,4]

           Explanation: The array represents the integer 123.
           Incrementing by one gives 123 + 1 = 124.
           Thus, the result should be [1,2,4].

		   Input: digits = [9]
		   Output: [1,0]
		 */
		public int[] PlusOne(int[] digits)
		{
			int i = digits.Length - 1;
			for (; i >= 0; i--)
			{
				if (digits[i] < 9)
				{
					digits[i]++;
					return digits;
				}
				digits[i] = 0;
			}
			digits = new int[digits.Length + 1];
			digits[0] = 1;
			return digits;
		}
		#endregion


		#region Add Binary
		// Question Down Below

		/*
		   Input: a = "11", b = "1"
		   Output: "100"

		   Input: a = "1010", b = "1011"
		   Output: "10101"
		*/

		public string AddBinary(string a, string b)
		{
			var stringBuilder = new StringBuilder();
			int sum1 = 0;

			foreach (var item in a)
			{
				sum1 += int.Parse(item.ToString()) ;
			}

			return "a";
		}



		#endregion

		#region Test

		public string Sum(string val1, string val2)
		{
			return (Convert.ToInt32(val1) + Convert.ToInt32(val2)).ToString();
		
		}
		
		#endregion
	}
}