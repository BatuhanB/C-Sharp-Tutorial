using Castle.DynamicProxy;
using System.Xml.Linq;

namespace AspectOrientedProgramming.InterceptionAspect
{
    public class MyInterceptionAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Before {0}", invocation.Method.Name);
            invocation.Proceed();
            Console.WriteLine("After {0}", invocation.Method.Name);

            if (invocation.Arguments.Length > 0)
            {
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

    public class DefensiveProgramming : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var parameters = invocation.Arguments;

            foreach (var parameter in parameters)
            {
                if (parameter.Equals(null))
                {
                    throw new ArgumentNullException($"Id or name is null!");
                }
            }
            Console.WriteLine($"{invocation.Method.Name} has not null parameter!");
        }
    }
}
