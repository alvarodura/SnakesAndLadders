using SnakesAndLadders.Entities;
using SnakesAndLadders.Services.Implementations;
using SnakesAndLadders.Services.Interfaces;

namespace SnakesAndLadders.Test
{
    public class StartGameServiceTest
    {

        [Test]
        public void StartGame_SetTokenOnBoard_SetTokenOnSquare1()
        {
            // Arrange
            IStartGameService service = new StartGameService();

            Board board = new Board();
            Token token = new Token();

            // Action
            service.StartGame(board, token);

            // Assert
            Assert.That(board.Tokens.FirstOrDefault(t => t.Id == token.Id), Is.Not.Null);
            Assert.That(token.Square, Is.EqualTo(1));

        }
    }
}