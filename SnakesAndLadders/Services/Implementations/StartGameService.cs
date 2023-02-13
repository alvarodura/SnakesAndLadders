using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakesAndLadders.Entities;
using SnakesAndLadders.Services.Interfaces;

namespace SnakesAndLadders.Services.Implementations
{
    public class StartGameService : IStartGameService
    {
        public void StartGame(Board board, Token token)
        {
            _ = board ?? throw new ArgumentNullException(nameof(board));
            _ = token ?? throw new ArgumentNullException(nameof(token));

            token.Square = 1;
            board.Tokens.Add(token);
        }
    }
}
