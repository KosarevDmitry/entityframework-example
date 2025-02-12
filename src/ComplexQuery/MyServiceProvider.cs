using System;

namespace EFQuerying.ComplexQuery;

public class MyServiceProvider : IServiceProvider
{
    public object GetService(Type serviceType)
    {
        Console.WriteLine("MyServiceProvider");
        return new MyObj();
    }
}