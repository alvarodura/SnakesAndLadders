using SnakesAndLadders;
using SnakesAndLadders.Services.Implementations;
using SnakesAndLadders.Services.Interfaces;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddSingleton<IStartGameService, StartGameService>();
        services.AddSingleton<IRollDiceService, RollDiceService>();
        services.AddSingleton<IMoveTokenService, MoveTokenService>();
    })
    .Build();

await host.RunAsync();
