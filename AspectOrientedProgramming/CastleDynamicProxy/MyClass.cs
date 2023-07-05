namespace AspectOrientedProgramming.CastleDynamicProxy
{
    public class MyClass
    {       
        [MyInterceptorAspect]
        public virtual void MyMethod()
        {
            Console.WriteLine("Worked My Method");
        }
    }
}
