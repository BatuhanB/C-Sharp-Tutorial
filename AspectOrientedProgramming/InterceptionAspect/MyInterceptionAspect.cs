using Castle.DynamicProxy;

namespace AspectOrientedProgramming.InterceptionAspect
{
    public class MyInterceptionAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Before {0}",invocation.Method.Name);
            invocation.Proceed();
            Console.WriteLine("After {0}",invocation.Method.Name);
            if(invocation.Arguments.Length > 0)
            {
                Console.WriteLine("The Method has parameters!");

                foreach (var item in invocation.Arguments)
                {
                    Console.WriteLine($"Method Arguments: {item.GetType()} | {item}");
                }
            }
            else
            {
                Console.WriteLine("The Method has no parameter!");

            }
        }
    }
}
