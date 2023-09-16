using System.Collections;

namespace InterviewQuestionsAndAnswers.Question1
{
    /// <summary>
    /// What are the differences between IEnumerable, ICollection and IList interfaces ?
    /// </summary>
    public class Question1 :IEnumerable<object>
    {
        public string Name { get; set; }

        // we implemented IEnumerable interface to our class 
        // that means we can iterate(in loop) our Question1 object
        public IEnumerator<object> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
