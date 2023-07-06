namespace AspectOrientedProgramming.CastleDynamicProxy
{
    public class MyClass : IMyClass
    {
        [MyInterceptorAspect(Priority = 1)]
        public virtual void MyMethod()
        {
            Console.WriteLine("Worked My Method");
        }
    }
}
