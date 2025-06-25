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
            return (Row + Column) % 2 == 0;

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
        //too similar to certain shogi code, so we will not use it

        
        public override string ToString()
        {
            return $"({Row}, {Column})";
        }
    }
}