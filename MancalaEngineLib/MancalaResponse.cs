/// <summary>
/// Author: Andrianto Dwi Laksono
/// Date: July 9 2019
/// </summary>
namespace MancalaEngineLib
{
    public enum GameStatus
    {
        GameOn,
        Player1Win,
        Player2Win,
        Draw
    }

    public struct MancalaResponse
    {
        public int[] Board;
        public GameStatus GameStatus;
        public int PlayerTurn;
    }
}
