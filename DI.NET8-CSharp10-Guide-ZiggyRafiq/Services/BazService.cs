using DI.NET8_CSharp10_Guide_ZiggyRafiq.Services.Interfaces;

namespace DI.NET8_CSharp10_Guide_ZiggyRafiq.Services;
public class BazService : IBazService
{
    public void DoAnotherThing()
    {
        Console.WriteLine("Doing another thing in BazService.");
    }
}
