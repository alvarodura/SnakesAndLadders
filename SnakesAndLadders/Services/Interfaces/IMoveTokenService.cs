using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakesAndLadders.Entities;

namespace SnakesAndLadders.Services.Interfaces
{
    public interface IMoveTokenService
    {
        public void MoveToken(Token token, int spaces);
    }
}
