using SnakesAndLadders.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.Services.Implementations
{
    public class RollDiceService : IRollDiceService
    {
        public int RollDice()
        {
            Random random = new();
            return random.Next(1, 6);
        }
    }
}
