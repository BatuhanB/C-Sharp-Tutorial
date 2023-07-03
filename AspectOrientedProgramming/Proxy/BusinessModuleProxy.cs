namespace AspectOrientedProgramming.Proxy
{
    public class BusinessModuleProxy : IBusinessModule
    {
        private BusinessModule _businessModule;

        public BusinessModuleProxy(BusinessModule businessModule)
        {
            _businessModule = businessModule;
        }

        public void DoSomething()
        {
            Console.WriteLine("Before Method");
            _businessModule.DoSomething();
            Console.WriteLine("After Method");
        }
    }
}
