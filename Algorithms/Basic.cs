using System.Text;

namespace Algorithms
{
	public class Basic
	{
		#region AddLastChar

		//Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more.
		/*
		 * Examples 
			"red" => "dredd"
			"green" => "ngreenn"
			"23" => "3233"
		*/

		//Code

		//public string AddLastChar(string text)
		//{
		//	StringBuilder stringBuilder = new();
		//	int lastIndex = text.Length - 1;

		//	for (int i = 0; i < lastIndex + 1; i++)
		//	{
		//		var last = text[lastIndex];
		//		if (i == 0) { stringBuilder.Append(last); }
		//		stringBuilder.Append(text[i]);
		//		if (i == lastIndex) { stringBuilder.Append(last); }
		//	}

		//	return stringBuilder.ToString();
		//}

		public string AddLastChar(string text)
		{
			if (text.Length < 2) { return text + text + text; }

			string lastChar = text.Substring(text.Length - 1);
			return lastChar + text + lastChar; 
		}

		#endregion

		#region CheckDividers

		//Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7
		/*
		  * Examples
		  3 => True, 14 => True, 21 => True, 37 => False
		 */
		public bool CheckDividers(int number)
		{
			if (number % 3 == 0) return true;
			if (number % 7 == 0) return true;

			return false;
		}

		#endregion

		#region AddThreeChar

		//Write a C# Sharp program to create a new string taking the first 3 characters of a given string and return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there. 

		/*
		 * Example:
			"Code" => "CodCodeCod", "JS" => "JSJSJS", ".Net" => ".Ne.Net.Ne"
		 */

		public string AddThreeChar(string text)
		{
			if (text.Length < 3) { return text + text + text; }
			string text2 = text.Substring(0, 3);
			return text2 + text + text2;
		}
		#endregion

		#region CheckIfStartsWithC#

		//Write a C# Sharp program to check if a given string starts with 'C#' or not.

		/*
		 * Example
			"C# Corner" => True, "Hello" => False
		 */

		public bool CheckIfStartsWithCsharp(string text)
		{
			var firstChars = text.Substring(0,2);
			if(firstChars == "C#") return true;
			return false;
		}


		#endregion


		#region CheckTemperatures 

		//Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100.
		/*
		 * Example:
			120,-1 => true, -12,129 => true, 12,56 => false
		 */

		public bool CheckTemperatures(int temp1, int temp2)
		{
			if(temp1 < 0 && temp2 > 100 || temp2 < 0 && temp1 > 100) return true;
			return false;
		}


		#endregion
	}
}
