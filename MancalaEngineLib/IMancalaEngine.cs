/// <summary>
/// Author: Andrianto Dwi Laksono
/// Date: July 9 2019
/// </summary>
namespace MancalaEngineLib
{
    /// <summary>
    /// Interface for mancala engine.
    /// </summary>
    public interface IMancalaEngine
    {
        MancalaResponse Move(int[] board, int playerNo, int pitNo);
    }
}
