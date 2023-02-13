using SnakesAndLadders.Entities;
using SnakesAndLadders.Services.Implementations;
using SnakesAndLadders.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.Test
{
    internal class RollDiceServiceTest
    {
        [Test]
        public void RollDice_ResultShouldBetween1And6()
        {
            // Arrange
            IRollDiceService service = new RollDiceService();

            // Action
            var result = service.RollDice();

            // Assert
            Assert.That(result, Is.InRange(1,6));

        }
    }
}
