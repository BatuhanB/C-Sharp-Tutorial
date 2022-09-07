using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Variables Test 

            //#region Create Variables
            //Variables variables = new()
            //{
            //    BooleanType = false,
            //    CharType = 'B',
            //    DecimalType = 2500M,
            //    FloatType = 12.2f,
            //    IntType = 12,
            //    StringType = "Variables",
            //};
            //Variables variables2 = new()
            //{
            //    BooleanType = true,
            //    CharType = 'A',
            //    DecimalType = 22500M,
            //    FloatType = 22.2f,
            //    IntType = 42,
            //    StringType = "Variables 2",
            //};
            //#endregion
            //// Created List To Hold Object Created Above 
            //var variablesList = new List<Variables>
            //{
            //    variables,
            //    variables2
            //};
            ////Write Object Variables and Variable Types Using Foreach
            //foreach (var item in variablesList)
            //{
            //    Console.WriteLine("Type: {0} -- Value: " + item.BooleanType, item.BooleanType.GetTypeCode());
            //    Console.WriteLine("Type: {0} -- Value: " + item.CharType, item.CharType.GetTypeCode());
            //    Console.WriteLine("Type: {0} -- Value: " + item.DecimalType, item.DecimalType.GetTypeCode());
            //    Console.WriteLine("Type: {0} -- Value: " + item.FloatType, item.FloatType.GetTypeCode());
            //    Console.WriteLine("Type: {0} -- Value: " + item.IntType, item.IntType.GetTypeCode());
            //    Console.WriteLine("Type: {0} -- Value: " + item.StringType, item.StringType.GetTypeCode());
            //    Console.WriteLine("*****************************");
            //}
            //#endregion

            //#region DataTypes

            //DataTypes date = new();
            //Console.WriteLine(date.date);
            ////Console.WriteLine(date.date1);
            //Console.WriteLine(date.date2);
            //Console.WriteLine(date.date3);
            //Console.WriteLine("new Date " + date.newDate);

            //#endregion
            //#region Anonymous Type

            ////We use anonymous type instead of creating a object class for example
            //var result = new
            //{
            //    Id = 2,
            //    Name = "Batuhan",
            //    Code = "12a4fxa12"
            //};
            ////Anonymous type object in anonymous type object
            //var student = new
            //{
            //    Id = 1,
            //    Name = "Batuhan",
            //    SurName = "Bali",
            //    Age = 22,
            //    Adress = new { Id = 2, City = "London", Country = "UK" }
            //};
            ////Anonymous array type 
            //var cars = new[]
            //{
            //    new {Id=1,Brand = "BMW",Model="3.20i"},
            //    new {Id=2,Brand = "Audi",Model="A6"},
            //    new {Id=3,Brand = "Mercedes",Model="E250"},
            //};
            //Console.WriteLine(result + " \n************* ");

            //Console.WriteLine(student + " \n************* ");

            //foreach (var itemCar in cars)
            //{
            //    Console.WriteLine(itemCar);   
            //}

            ////Return anonymous type using LINQ query from List
            //Console.WriteLine("\n ****************************");
            //IList<StudentObject> students = new List<StudentObject>()
            //{
            //    new() {Age = 22, FirstName = "Batuhan",LastName = "Bali",ExamResult = 87},
            //    new() {Age = 32, FirstName = "Murat",LastName = "Sonuc",ExamResult = 76},
            //    new() {Age = 18, FirstName = "Sema",LastName = "Kermez",ExamResult = 92},
            //};
            //var students1 = from x in students
            //    select new
            //    {
            //        Age=x.Age,
            //        FirstName=x.FirstName,
            //        LastName=x.LastName
            //    };
            //foreach (var stu in students)
            //{
            //    Console.WriteLine(stu.FirstName + " " + stu.LastName+ " " + stu.Age+ " " + stu.ExamResult);
            //}
            //Console.WriteLine("\n ****************************");
            //Console.WriteLine("First Name " + " - " + "Last Name " + " - " + "Age");
            //Console.WriteLine("==================================");
            //foreach (var stu1 in students1)
            //{
            //    Console.WriteLine(stu1.FirstName + " - " + stu1.LastName + " - " + stu1.Age);
            //}
            //#endregion


            //#region Palindrome Number
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
            // #endregion

            //#region TwoSum
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
            //#endregion

            //#region ContainsDuplicate
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
            //#endregion

            //#region Baseball Game

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
            
            //#endregion
        }
    }
}
