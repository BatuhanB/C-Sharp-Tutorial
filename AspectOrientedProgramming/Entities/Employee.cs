namespace AspectOrientedProgramming.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual void Add(int id,string name)
        {
            Console.WriteLine("Added.");
        }

        public virtual void Add()
        {
            Console.WriteLine("No Parameter | Added.");
        }
    }
}
