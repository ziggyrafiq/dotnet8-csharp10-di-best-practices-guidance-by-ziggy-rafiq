using DI.NET8_CSharp10_Guide_ZiggyRafiq.Services.Interfaces;

namespace DI.NET8_CSharp10_Guide_ZiggyRafiq.ConstructorInjection;
public class ZiggyRafiqService
{
    private readonly IFooService _fooService;

    public ZiggyRafiqService(IFooService fooService)
    {
        _fooService = fooService;
    }

    public void DoSomething()
    {
        // Use the IFooService instance
        _fooService.DoSomething();
    }
}
