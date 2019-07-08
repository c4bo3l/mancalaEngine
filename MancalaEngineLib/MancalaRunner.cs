using System;
using System.Linq;

/// <summary>
/// Author: Andrianto Dwi Laksono
/// Date: July 9 2019
/// </summary>
namespace MancalaEngineLib
{
    public class MancalaRunner : IMancalaEngine
    {
        public const int _PitCount = 14;
        public const int _StorePit1No = 6;
        public const int _StorePit2No = 13;

        /// <summary>
        /// Mancala runner.
        /// </summary>
        /// <param name="board">
        /// Current board state.
        /// </param>
        /// <param name="playerNo">
        /// Only 1 and 2
        /// </param>
        /// <param name="pitNo">
        /// Available number would be from 0 to 5 for both player
        /// </param>
        /// <returns></returns>
        private int RunMancala(int[] board, int playerNo, int pitNo)
        {
            pitNo += ((playerNo - 1) * 7);
            int mancalaCount = board[pitNo];
            int currentPitNo = pitNo + 1;
            int lastPitNo = 0;
            board[pitNo] = 0;
            while (mancalaCount > 0)
            {
                int tempPitNo = currentPitNo % _PitCount;
                lastPitNo = tempPitNo;
                if (tempPitNo == _StorePit1No && playerNo == 1)
                {
                    ++board[_StorePit1No];
                    mancalaCount--;
                }
                else if (tempPitNo == _StorePit2No && playerNo == 2)
                {
                    ++board[_StorePit2No];
                    mancalaCount--;
                }

                if (tempPitNo == _StorePit1No || tempPitNo == _StorePit2No)
                {
                    currentPitNo++;
                    continue;
                }
                ++board[tempPitNo];
                mancalaCount--;
                currentPitNo++;
            }

            return lastPitNo;
        }

        /// <summary>
        /// Move mancala from a pit that own by playerNo
        /// </summary>
        /// <param name="board">
        /// Current board state.
        /// </param>
        /// <param name="playerNo">
        /// Player number 1 or 2
        /// </param>
        /// <param name="pitNo">
        /// Only 0-5 for both players.
        /// </param>
        /// <returns></returns>
        public MancalaResponse Move(int[] board, int playerNo, int pitNo)
        {
            if (pitNo < 0 || pitNo >= _PitCount)
            {
                throw new IndexOutOfRangeException();
            }

            int lastPitNo = RunMancala(board, playerNo, pitNo);
            MancalaResponse response;
            if (lastPitNo == _StorePit1No)
            {
                response.Board = board;
                response.GameStatus = IsDone(board);
                response.PlayerTurn = 1;
                return response;
            }
            else if (lastPitNo == _StorePit2No)
            {
                response.Board = board;
                response.GameStatus = IsDone(board);
                response.PlayerTurn = 2;
                return response;
            }
            else if (playerNo == 1 && lastPitNo > _StorePit1No && lastPitNo < _StorePit2No)
            {
                response.Board = board;
                response.GameStatus = IsDone(board);
                response.PlayerTurn = 2;
                return response;
            }
            else if (playerNo == 2 && lastPitNo >= 0 && lastPitNo < _StorePit1No)
            {
                response.Board = board;
                response.GameStatus = IsDone(board);
                response.PlayerTurn = 1;
                return response;
            }
            else if (board[lastPitNo] == 1)
            {
                int acrossPitNo = Math.Abs(11 - lastPitNo);
                board[lastPitNo] = 0;
                int mancalaInAcrossPit = board[acrossPitNo];
                board[acrossPitNo] = 0;
                if (playerNo == 1)
                {
                    board[_StorePit1No] += mancalaInAcrossPit + 1;
                }
                else
                {
                    board[_StorePit2No] += mancalaInAcrossPit + 1;
                }
            }

            response.Board = board;
            response.GameStatus = IsDone(board);
            response.PlayerTurn = playerNo == 1 ? 2 : 1;
            return response;
        }

        /// <summary>
        /// Game status checker
        /// </summary>
        /// <param name="board">
        /// Current board status.
        /// </param>
        /// <returns>
        /// GameOn or Player1Win or Player2Win or Draw status.
        /// </returns>
        private GameStatus IsDone(int[] board)
        {
            bool isDone = false;
            if (!board.Take(6).Any(x => x > 0))
            {
                board[_StorePit2No] += board.Skip(7).Take(6).Sum();
                isDone = true;
            }
            else if (!board.Skip(7).Take(6).Any(x => x > 0))
            {
                board[_StorePit1No] += board.Take(6).Sum();
                isDone = true;
            }

            if (!isDone)
            {
                // Game on
                return GameStatus.GameOn;
            }

            if (board[_StorePit1No] > board[_StorePit2No])
            {
                // Player 1 win
                return GameStatus.Player1Win;
            }
            else if (board[_StorePit1No] < board[_StorePit2No])
            {
                // Player 2 win
                return GameStatus.Player2Win;
            }
            else
            {
                // Draw
                return GameStatus.Draw;
            }
        }
    }
}
