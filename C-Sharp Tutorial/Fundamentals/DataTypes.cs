using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial.Fundamentals
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
        #endregion
    }
}
