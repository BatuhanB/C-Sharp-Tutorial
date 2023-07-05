namespace AspectOrientedProgramming.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual void Add(int id, string name)
        {
            Console.WriteLine("Added.");
        }

        public virtual void Add()
        {
            Console.WriteLine("No Parameter | Added.");
        }

        public virtual void Update(int id, string name)
        {

            //if (id is 0 || name is null)
            //{
            //    throw new ArgumentNullException($"Id: {nameof(id)} or name: {nameof(name)} is null!");
            //}

            Console.WriteLine("Updated.");
        }
    }
}
