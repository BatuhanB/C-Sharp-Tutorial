using System;

namespace Course.Web.Handler;

public class TestStatic
{
    public void MyMethod1()
    {
        Console.WriteLine("Non-static");
    }

    public static void MyMethod2()
    {
        Console.WriteLine("Static");
    }
}
