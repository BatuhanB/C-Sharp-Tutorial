using Fundamentals;
using System;

namespace Fundamentals
{
    public class DataTypes
    {
        //We Do Not start with numbers because they are simple types to nothing worth to explain   

        #region Strings

        public string Ch = "A";
        public string Word = "String";
        public string Text = "Explanation of strings.";

        //Special Characters in Strings
        public string StringInString = "This is a \"string\" in C#.";//We use backslash as a escape char.
        public string Str = "xyzdef\\rabcc";
        public string Path = "\\\\mypx\\shared\\project";

        //Verbatim Strings
        public string Str2 = @"xyzdef\rabc";//Escape Sequence
        public string Path2 = @"\\mypx\\shared\\project";
        public string Email = @"test@test.com";

        //Multi-line String
        public string string1 = "this is a \n" 
                                + "multi line \n" 
                                + "string";
        public string string2 = @"this is a  
                                 multi line  
                                 string";
        //String Concatenation
        public static string FirstName = "Batuhan";
        public static string LastName = "Balı";
        public static string Code = "012AC21";

        public string Concatenation = "Information: " + FirstName + " " + LastName + " " + Code;

        //String Interpolation
        public string Interpolation = $"Information {FirstName} {LastName},Code {Code}";

        #endregion

        #region DateTime
        //Create DateTime Object
        public DateTime date = new ();

        //Set Date & Time
        public static DateTime date1 = new (1999, 12, 20);
        public DateTime date2 = new (1999, 12, 20,14,12,15);
        public DateTime date3 = new (1999, 12, 20,14,12,12,DateTimeKind.Local);

        //Adding days to existing dateTime
        public static TimeSpan ts = new (12,12,12,12);
        public DateTime newDate = date1.Add(ts);

    }

        #endregion

        #region Structure
        //Declaring a Structure named Coordinates 


        struct Coordinates
        {
            public int x;
            public int y;
        }
        

        #endregion

        #region Enum
        //Declaring a Enum
        //Automatic assign values to enum members 
        public enum WeekDays
        {
            Monday,   //0
            Tuesday,  //1
            Wednesday,//2
            Thursday, //3
            Friday,   //4
            Saturday, //5
            Sunday    //6
        }
        //We could to assign specific values to each enum members
        public enum Categories
        {
            Cargo = 1,
            Electronic = 4,
            Fashion = 12,
            Art = 21,
            Food,
            BeautyCare
        }
        // We could specify the type after enums name for example on categories
        public enum Categories2:byte
        {
            Cargo = 1,
            Electronic = 4,
            Fashion = 12,
            Art = 21,
            Food,
            BeautyCare
        }
        //Enum to int conversion 
        //int day = (int)WeekDays.Friday;

        //Int to enum conversion
        //var weekDay = (WeekDays)5;
        #endregion
}