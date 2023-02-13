using Moq;
using SnakesAndLadders.Entities;
using SnakesAndLadders.Services.Implementations;
using SnakesAndLadders.Services.Interfaces;

namespace SnakesAndLadders.Test
{
    public class MoveTokenServiceTest
    {
        public Mock<IRollDiceService> _rollDiceServiceMock;

        [SetUp]
        public void SetUp() 
        {
            _rollDiceServiceMock = new Mock<IRollDiceService>();

            _rollDiceServiceMock.Setup(x => x.RollDice())
                .Returns(4);
        }

        [Test]
        public void MoveToken_GivenTokenSquare1_Moved3Spaces_SetOnSquare4()
        {
            // Arrange
            IMoveTokenService service = new MoveTokenService();

            Token token = new Token()
            {
                Square = 1
            };

            // Action
            service.MoveToken(token, 3);

            // Assert
            Assert.That(token.Square, Is.EqualTo(4));

        }

        [Test]
        public void MoveToken_GivenTokenSquare1_Moved3SpacesAnd4Spaces_SetOnSquare8()
        {
            // Arrange
            IMoveTokenService service = new MoveTokenService();

            Token token = new Token()
            {
                Square = 1
            };

            // Action
            service.MoveToken(token, 3);
            service.MoveToken(token, 4);

            // Assert
            Assert.That(token.Square, Is.EqualTo(8));

        }

        [Test]
        public void MoveToken_GivenTokenSquare97_Moved3Spaces_SetOnSquare100AndWinGame()
        {
            // Arrange
            IMoveTokenService service = new MoveTokenService();

            Token token = new Token()
            {
                Square = 97,
                Win = false
            };

            // Action
            service.MoveToken(token, 3);

            // Assert
            Assert.That(token.Square, Is.EqualTo(100));
            Assert.That(token.Win, Is.EqualTo(true));

        }

        [Test]
        public void MoveToken_GivenTokenSquare97_Moved4Spaces_SetOnSquare97AndDontWinGame()
        {
            // Arrange
            IMoveTokenService service = new MoveTokenService();

            Token token = new Token()
            {
                Square = 97,
                Win = false
            };

            // Action
            service.MoveToken(token, 4);

            // Assert
            Assert.That(token.Square, Is.EqualTo(97));
            Assert.That(token.Win, Is.EqualTo(false));

        }

        [Test]
        public void MoveToken_GivenPlayerRolls4_MovedToken4Spaces()
        {
            // Arrange
            IMoveTokenService service = new MoveTokenService();

            Token token = new Token()
            {
                Square = 0,
                Win = false
            };

            int spaces = _rollDiceServiceMock.Object.RollDice();

            // Action
            service.MoveToken(token, spaces);

            // Assert
            Assert.That(token.Square, Is.EqualTo(4));

        }
    }
}
