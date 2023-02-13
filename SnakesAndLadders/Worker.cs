using SnakesAndLadders.Entities;
using SnakesAndLadders.Services.Interfaces;

namespace SnakesAndLadders
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IHost _host;
        private readonly IStartGameService _startGameService;
        private readonly IMoveTokenService _moveTokenService;
        private readonly IRollDiceService _rollDiceService;

        public Worker(ILogger<Worker> logger, IHost host, IStartGameService startGameService, IMoveTokenService moveTokenService, IRollDiceService rollDiceService)
        {
            _logger = logger;
            _host = host;
            _startGameService = startGameService;
            _moveTokenService = moveTokenService;
            _rollDiceService = rollDiceService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine("Hello! Press any key to start the game! Press ESC to finish the game.");
            ConsoleKey firstKey = Console.ReadKey().Key;

            if (firstKey != ConsoleKey.Escape)
            {
                Board board = new Board();
                Token token = new Token();

                _startGameService.StartGame(board, token);

                Console.WriteLine("Your token is at square {0}", token.Square);

                Console.WriteLine("Press any key to do a new movement.");

                while (Console.ReadKey().Key != ConsoleKey.Escape)
                {
                    
                    int spaces = _rollDiceService.RollDice();
                    Console.WriteLine("You roll {0}", spaces);
                    _moveTokenService.MoveToken(token, spaces);

                    Console.WriteLine("Your token is at square {0}", token.Square);

                    if (token.Win)
                    {
                        Console.WriteLine("You win the game!");
                        break;
                    }

                    Console.WriteLine("Press any key to do a new movement.");
                }
            }
            
            await _host.StopAsync(stoppingToken);
        }
    }
}