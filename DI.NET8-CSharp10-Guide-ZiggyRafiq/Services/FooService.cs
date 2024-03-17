using DI.NET8_CSharp10_Guide_ZiggyRafiq.Services.Interfaces;

namespace DI.NET8_CSharp10_Guide_ZiggyRafiq.Services;

public class FooService : IFooService
{
    public void DoSomething()
    {
        Console.WriteLine("Doing something in FooService.");
    }
}
