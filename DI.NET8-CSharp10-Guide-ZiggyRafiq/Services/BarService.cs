using DI.NET8_CSharp10_Guide_ZiggyRafiq.Services.Interfaces;

namespace DI.NET8_CSharp10_Guide_ZiggyRafiq.Services;
public class BarService : IBarService
{
    public void DoSomethingElse()
    {
        Console.WriteLine("Doing something else in BarService.");
    }
}
