using System.Reflection;

namespace AttributesAndReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodInfo methodInfo = typeof(Test).GetMethod("TestAttributeMethod");
            var attribute = Attribute.GetCustomAttribute(methodInfo, typeof(Test));    
            Console.WriteLine(attribute);
        }
    }
}
