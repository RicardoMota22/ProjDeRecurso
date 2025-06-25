using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WolfAndSheep.Model
{
    public readonly struct PlayerDirection
    {
        public int ChangeRow { get; }
        public int ChangeColumn { get; }
        /// <summary>
        /// Represents the direction a player can move on the board.
        /// </summary>
        //Sheep only directions
        public static readonly PlayerDirection NorthEast = new PlayerDirection(-1, 1);
        public static readonly PlayerDirection NorthWest = new PlayerDirection(-1, -1);
        //Wolf only directions + can use sheep directions
        public static readonly PlayerDirection SouthEast = new PlayerDirection(1, 1);
        public static readonly PlayerDirection SouthWest = new PlayerDirection(1, -1);

        public PlayerDirection(int changeRow, int changeColumn)
        {
            ChangeRow = changeRow;
            ChangeColumn = changeColumn;
        }
    }
}