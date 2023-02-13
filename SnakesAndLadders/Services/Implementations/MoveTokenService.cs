using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakesAndLadders.Entities;
using SnakesAndLadders.Services.Interfaces;

namespace SnakesAndLadders.Services.Implementations
{
    public class MoveTokenService : IMoveTokenService
    {
        public void MoveToken(Token token, int spaces)
        {
            _ = token ?? throw new ArgumentNullException(nameof(token));

            token.Square += spaces;

            CheckWinGame(token, spaces);
        }

        private void CheckWinGame(Token token, int spaces)
        {
            if (token.Square == 100)
            {
                token.Win = true;
            }
            else if (token.Square > 100)
            {
                token.Square -= spaces;
            }
        }
    }
}
