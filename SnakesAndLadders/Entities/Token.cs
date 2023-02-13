using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.Entities
{
    public class Token
    {
        private readonly Guid _id;
        private int _square;
        private bool _win;

        public Token()
        {
            _id = Guid.NewGuid();
        }

        public Guid Id => _id;

        public int Square
        {
            get => _square;
            set => _square = value;
        }

        public bool Win { get => _win; set => _win = value; }
    }
}
