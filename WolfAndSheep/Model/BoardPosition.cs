using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WolfAndSheep.Model
{
    public class BoardPosition
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public BoardPosition(int row, int column)
        {
            Row = row;
            Column = column;
        }
        public bool ValidSquare()
        {
            //Valid positions for players (Just dark sqaures)
            return (Row + Column) % 2 != 0;

        }
        //So they can be used as keys in dictionaries or hash sets
        public override bool Equals(object obj)
        {
            return obj is BoardPosition position &&
                   Row == position.Row &&
                   Column == position.Column;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }
        //Check if two positions are equal
        /*public static bool operator ==(BoardPosition left, BoardPosition right)
        {
            return EqualityComparer<BoardPosition>.Default.Equals(left, right);
        }
        public static bool operator !=(BoardPosition left, BoardPosition right)
        {
            return !(left == right);
        }*/
        //too similar to certain shogi code VS showed, so we will not use it

        /// <summary>
        /// Adds a PlayerDirection to a BoardPosition.
        /// custom + operator
        /// </summary>
        /// <param name="position"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public static BoardPosition operator +(BoardPosition position, PlayerDirection direction)
        {
            return new BoardPosition(position.Row + direction.ChangeRow, position.Column + direction.ChangeColumn);
        }
        public bool IsValid()
        {
            // Check if the position is within the bounds of the board
            return Row >= 0 && Row < 8 && Column >= 0 && Column < 8 && ValidSquare();
        }

        public override string ToString()
        {
            return $"({Row}, {Column})";
        }
         
    }
}