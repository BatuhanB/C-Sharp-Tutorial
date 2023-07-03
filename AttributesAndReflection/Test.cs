namespace AttributesAndReflection
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class Test : Attribute
    {
        public string Name {get;}

        public Test()
        {
            Name = "Batuhan";
            Console.WriteLine(Name);
        }

        [Test]
        public void TestAttributeMethod(){ }
    }
}
