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
            #region Variables Test 

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
            #endregion
            #region List

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
            #endregion
            #region DataTypes

            //DataTypes date = new();
            //Console.WriteLine(date.date);
            ////Console.WriteLine(date.date1);
            //Console.WriteLine(date.date2);
            //Console.WriteLine(date.date3);
            //Console.WriteLine("new Date " + date.newDate);

            #endregion
            #region Anonymous Type

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
            #endregion
        }
    }
}
