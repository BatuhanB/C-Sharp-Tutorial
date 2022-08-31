using System;
using System.Collections.Generic;
using C_Sharp_Tutorial.Fundamentals;

namespace C_Sharp_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables Test 

            #region Create Variables
            Variables variables = new ()
            {
                BooleanType = false,
                CharType = 'B',
                DecimalType = 2500M,
                FloatType = 12.2f,
                IntType = 12,
                StringType = "Variables",
            };
            Variables variables2 = new ()
            {
                BooleanType = true,
                CharType = 'A',
                DecimalType = 22500M,
                FloatType = 22.2f,
                IntType = 42,
                StringType = "Variables 2",
            };
            #endregion
            // Created List To Hold Object Created Above 
            var variablesList = new List<Variables>
            {
                variables,
                variables2
            };
            //Write Object Variables and Variable Types Using Foreach
            foreach (var item in variablesList)
            {
                Console.WriteLine("Type: {0} -- Value: " + item.BooleanType, item.BooleanType.GetTypeCode());
                Console.WriteLine("Type: {0} -- Value: " + item.CharType, item.CharType.GetTypeCode());
                Console.WriteLine("Type: {0} -- Value: " + item.DecimalType, item.DecimalType.GetTypeCode());
                Console.WriteLine("Type: {0} -- Value: " + item.FloatType, item.FloatType.GetTypeCode());
                Console.WriteLine("Type: {0} -- Value: " + item.IntType, item.IntType.GetTypeCode());
                Console.WriteLine("Type: {0} -- Value: " + item.StringType, item.StringType.GetTypeCode());
                Console.WriteLine("*****************************");
            }
            #endregion
            
        }
    }
}
