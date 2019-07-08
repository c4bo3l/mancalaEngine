using MancalaEngineLib;
using Xunit;

namespace MancalaEngine.Tests
{
    public class MancalaEngineTests
    {
        private MancalaRunner _engine;
        public MancalaEngineTests()
        {
            _engine = new MancalaEngineLib.MancalaRunner();
        }

#pragma warning disable xUnit1013 // Public method should be marked as test
        public void Dispose()
#pragma warning restore xUnit1013 // Public method should be marked as test
        {
            _engine = null;
        }

        [Fact]
        public void Player1Move0()
        {
            int[] board = new int[] {
                // Player 1
                4, // 0
                4, // 1
                4, // 2
                4, // 3
                4, // 4
                4, // 5 
                0, // Player 1 pot

                // Player 2
                4, // 0
                4, // 1
                4, // 2
                4, // 3
                4, // 4
                4, // 5 
                0 // Player 2 pot
            };
            MancalaResponse response = _engine.Move(board, 1, 0);
            Assert.Equal(GameStatus.GameOn, response.GameStatus);
            Assert.Equal(2, response.PlayerTurn);

            Assert.Equal(0, response.Board[0]);
            Assert.Equal(5, response.Board[1]);
            Assert.Equal(5, response.Board[2]);
            Assert.Equal(5, response.Board[3]);
            Assert.Equal(5, response.Board[4]);
            Assert.Equal(4, response.Board[5]);

            Assert.Equal(0, response.Board[6]);

            Assert.Equal(4, response.Board[7]);
            Assert.Equal(4, response.Board[8]);
            Assert.Equal(4, response.Board[9]);
            Assert.Equal(4, response.Board[10]);
            Assert.Equal(4, response.Board[11]);
            Assert.Equal(4, response.Board[12]);

            Assert.Equal(0, response.Board[13]);
        }

        [Fact]
        public void Player1Move2()
        {
            int[] board = new int[] {
                // Player 1
                4, // 0
                4, // 1
                4, // 2
                4, // 3
                4, // 4
                4, // 5 
                0, // Player 1 pot

                // Player 2
                4, // 0
                4, // 1
                4, // 2
                4, // 3
                4, // 4
                4, // 5 
                0 // Player 2 pot
            };
            MancalaResponse response = _engine.Move(board, 1, 2);
            Assert.Equal(GameStatus.GameOn, response.GameStatus);
            Assert.Equal(1, response.PlayerTurn);

            Assert.Equal(4, response.Board[0]);
            Assert.Equal(4, response.Board[1]);
            Assert.Equal(0, response.Board[2]);
            Assert.Equal(5, response.Board[3]);
            Assert.Equal(5, response.Board[4]);
            Assert.Equal(5, response.Board[5]);

            Assert.Equal(1, response.Board[6]);

            Assert.Equal(4, response.Board[7]);
            Assert.Equal(4, response.Board[8]);
            Assert.Equal(4, response.Board[9]);
            Assert.Equal(4, response.Board[10]);
            Assert.Equal(4, response.Board[11]);
            Assert.Equal(4, response.Board[12]);

            Assert.Equal(0, response.Board[13]);
        }

        [Fact]
        public void Player1Move5()
        {
            int[] board = new int[] {
                // Player 1
                4, // 0
                4, // 1
                4, // 2
                4, // 3
                4, // 4
                4, // 5 
                0, // Player 1 pot

                // Player 2
                4, // 0
                4, // 1
                4, // 2
                4, // 3
                4, // 4
                4, // 5 
                0 // Player 2 pot
            };
            MancalaResponse response = _engine.Move(board, 1, 5);
            Assert.Equal(GameStatus.GameOn, response.GameStatus);
            Assert.Equal(2, response.PlayerTurn);

            Assert.Equal(4, response.Board[0]);
            Assert.Equal(4, response.Board[1]);
            Assert.Equal(4, response.Board[2]);
            Assert.Equal(4, response.Board[3]);
            Assert.Equal(4, response.Board[4]);
            Assert.Equal(0, response.Board[5]);

            Assert.Equal(1, response.Board[6]);

            Assert.Equal(5, response.Board[7]);
            Assert.Equal(5, response.Board[8]);
            Assert.Equal(5, response.Board[9]);
            Assert.Equal(4, response.Board[10]);
            Assert.Equal(4, response.Board[11]);
            Assert.Equal(4, response.Board[12]);

            Assert.Equal(0, response.Board[13]);
        }

        [Fact]
        public void Player2Move0()
        {
            int[] board = new int[] {
                // Player 1
                4, // 0
                4, // 1
                4, // 2
                4, // 3
                4, // 4
                4, // 5 
                0, // Player 1 pot

                // Player 2
                4, // 0
                4, // 1
                4, // 2
                4, // 3
                4, // 4
                4, // 5 
                0 // Player 2 pot
            };
            MancalaResponse response = _engine.Move(board, 2, 0);
            Assert.Equal(GameStatus.GameOn, response.GameStatus);
            Assert.Equal(1, response.PlayerTurn);

            Assert.Equal(4, response.Board[0]);
            Assert.Equal(4, response.Board[1]);
            Assert.Equal(4, response.Board[2]);
            Assert.Equal(4, response.Board[3]);
            Assert.Equal(4, response.Board[4]);
            Assert.Equal(4, response.Board[5]);

            Assert.Equal(0, response.Board[6]);

            Assert.Equal(0, response.Board[7]);
            Assert.Equal(5, response.Board[8]);
            Assert.Equal(5, response.Board[9]);
            Assert.Equal(5, response.Board[10]);
            Assert.Equal(5, response.Board[11]);
            Assert.Equal(4, response.Board[12]);

            Assert.Equal(0, response.Board[13]);
        }

        [Fact]
        public void Player2Move2()
        {
            int[] board = new int[] {
                // Player 1
                4, // 0
                4, // 1
                4, // 2
                4, // 3
                4, // 4
                4, // 5 
                0, // Player 1 pot

                // Player 2
                4, // 0
                4, // 1
                4, // 2
                4, // 3
                4, // 4
                4, // 5 
                0 // Player 2 pot
            };
            MancalaResponse response = _engine.Move(board, 2, 2);
            Assert.Equal(GameStatus.GameOn, response.GameStatus);
            Assert.Equal(2, response.PlayerTurn);

            Assert.Equal(4, response.Board[0]);
            Assert.Equal(4, response.Board[1]);
            Assert.Equal(4, response.Board[2]);
            Assert.Equal(4, response.Board[3]);
            Assert.Equal(4, response.Board[4]);
            Assert.Equal(4, response.Board[5]);

            Assert.Equal(0, response.Board[6]);

            Assert.Equal(4, response.Board[7]);
            Assert.Equal(4, response.Board[8]);
            Assert.Equal(0, response.Board[9]);
            Assert.Equal(5, response.Board[10]);
            Assert.Equal(5, response.Board[11]);
            Assert.Equal(5, response.Board[12]);

            Assert.Equal(1, response.Board[13]);
        }

        [Fact]
        public void Player2Move5()
        {
            int[] board = new int[] {
                // Player 1
                4, // 0
                4, // 1
                4, // 2
                4, // 3
                4, // 4
                4, // 5 
                0, // Player 1 pot

                // Player 2
                4, // 0
                4, // 1
                4, // 2
                4, // 3
                4, // 4
                4, // 5 
                0 // Player 2 pot
            };
            MancalaResponse response = _engine.Move(board, 2, 5);
            Assert.Equal(GameStatus.GameOn, response.GameStatus);
            Assert.Equal(1, response.PlayerTurn);

            Assert.Equal(5, response.Board[0]);
            Assert.Equal(5, response.Board[1]);
            Assert.Equal(5, response.Board[2]);
            Assert.Equal(4, response.Board[3]);
            Assert.Equal(4, response.Board[4]);
            Assert.Equal(4, response.Board[5]);

            Assert.Equal(0, response.Board[6]);

            Assert.Equal(4, response.Board[7]);
            Assert.Equal(4, response.Board[8]);
            Assert.Equal(4, response.Board[9]);
            Assert.Equal(4, response.Board[10]);
            Assert.Equal(4, response.Board[11]);
            Assert.Equal(0, response.Board[12]);

            Assert.Equal(1, response.Board[13]);
        }
    }
}
