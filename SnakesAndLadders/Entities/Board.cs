using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.Entities
{
    public class Board
    {
        private readonly IList<Token> _tokens;

        public Board()
        {
            _tokens = new List<Token>();
        }

        public IList<Token> Tokens => _tokens;
    }
}
