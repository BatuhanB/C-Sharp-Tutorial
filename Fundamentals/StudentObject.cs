namespace Fundamentals
{
    public class StudentObject
    {
        #region Fields // Below this line are fields for student object
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal ExamResult { get; set; }
        #endregion

        #region Constructor // Our constructor's for pass parameters when call the method
        public StudentObject()
        {

        }
        public StudentObject(string firstName, string lastName, int age, decimal examResult)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ExamResult = examResult;
        }
        #endregion
    }
}
