using DI.NET8_CSharp10_Guide_ZiggyRafiq.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DI.NET8_CSharp10_Guide_ZiggyRafiq.Controller;
public class ZiggyRafiqController: ControllerBase
{
    private readonly IFooService _fooService;

    public ZiggyRafiqController(IFooService fooService)
    {
        _fooService = fooService;
    }

    // Action method to handle GET requests
    [HttpGet]
    public IActionResult Get()
    {
        // Perform some action using IFooService
        _fooService.DoSomething();

        // Return an IActionResult
        return Ok("GET request handled");
    }

}
