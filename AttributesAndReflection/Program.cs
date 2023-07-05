using AttributesAndReflection;
using System.Reflection;

MethodInfo methodInfo = typeof(Test).GetMethod("TestAttributeMethod");
var attribute = Attribute.GetCustomAttribute(methodInfo, typeof(Test));
Console.WriteLine(attribute);
