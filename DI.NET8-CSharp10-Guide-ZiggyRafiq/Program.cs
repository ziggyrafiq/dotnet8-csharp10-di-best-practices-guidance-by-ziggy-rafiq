using DI.NET8_CSharp10_Guide_ZiggyRafiq.Services.Interfaces;
using DI.NET8_CSharp10_Guide_ZiggyRafiq.Services;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, I am Ziggy Rafiq and I work for Capgemini!");

// Setup dependency injection container
var serviceProvider = new ServiceCollection()
    .AddTransient<IFooService, FooService>()
    .AddScoped<IBarService, BarService>()
    .AddSingleton<IBazService, BazService>()
    .BuildServiceProvider();

// Resolve services and use them
var fooService = serviceProvider.GetService<IFooService>();
var barService = serviceProvider.GetService<IBarService>();
var bazService = serviceProvider.GetService<IBazService>();

// Use the services Example One
fooService?.DoSomething();
barService?.DoSomethingElse();
bazService?.DoAnotherThing();

// Use the services Example Two
serviceProvider.GetService<IFooService>()?.DoSomething();
serviceProvider.GetService<IBarService>()?.DoSomethingElse();
serviceProvider.GetService<IBazService>()?.DoAnotherThing();
