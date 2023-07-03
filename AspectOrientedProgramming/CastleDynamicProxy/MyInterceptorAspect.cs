using Castle.DynamicProxy;

namespace AspectOrientedProgramming.CastleDynamicProxy
{
    public class MyInterceptorAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Before {0}" ,invocation.Method.Name);
            invocation.Proceed();
            Console.WriteLine("After {0}" ,invocation.Method.Name);
        }
    }
}
