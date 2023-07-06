using AspectOrientedProgramming.Core.Interceptors;
using Castle.DynamicProxy;

namespace AspectOrientedProgramming.CastleDynamicProxy
{
    public class MyInterceptorAspect : MethodInterception
    {
        public override void OnBefore(IInvocation invocation)
        {
            Console.WriteLine("Before {0}", invocation.Method.Name);
        }

        public override void OnAfter(IInvocation invocation)
        {
            Console.WriteLine("After {0}", invocation.Method.Name);
        }

        public override void OnSuccess(IInvocation invocation)
        {
            Console.WriteLine($"{invocation.Method.Name} is Succeed");
        }
    }
}
