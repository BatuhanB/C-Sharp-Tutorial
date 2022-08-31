using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial.Fundamentals
{
    public class Method
    {

        #region SampleMethods
        public int Sum(int number1,int number2)//Sum method is has a 2 parameters and method return sum of these parameters
        {
            return number1 + number2;
        }
        public int Subtract(int number1, int number2)//Sum method is has a 2 parameters and method return subtract of these parameters
        {
            return number1 - number2 ;
        }

        public int Multiply(int number1,int number2)//Sum method is has a 2 parameters and method return multiply of these parameters
        {
            return number1 * number2;
        }

        public int Divide(int number1, int number2)//Sum method is has a 2 parameters and method return divide of these parameters
        {
            return number1 / number2;
        }

        #endregion
        #region CreateFields
        public int FirstName { get; set; }//Define the firstname field
        public int LastName { get; set; }//Define the lastname field

        public string GetFullName()//This method return firstname plus lastname which it means fullName
        {
            //the method does not take parameters because in class already has this fields
            return FirstName + " " + LastName;
        }
        #endregion

        #region Constructor
        public Method()//Constructor means when the object calling from somewhere it needs to get parameters in here
        {
            //but if there is no parameters object does not need the take parameter
        }
        public Method(int firstName, int lastName)//This constructor needs to take 2 parameter and has to take these parameter, can't pass empty
        {
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion

        #region AccessMember
        StudentObject student = new ();//In here object was created by using new modifier but constructor does not take parameters
        StudentObject student2 = new ()//In here object was created by using new modifier and constructor takes parameters
        {
            FirstName = "Batuhan",
            LastName = "B",
            Age = 22,
            ExamResult = 75
        };

        StudentObject student3 = new("Samet","Ozturk",12,54);

        #endregion

    }
}
