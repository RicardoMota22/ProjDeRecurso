using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace WolfAndSheep.Model
{
    /// <summary>
    /// Represents the movement of a sheep on the board.
    /// Implements the IMovement interface.
    /// Uses Programming a Chess Game in C# | Part 5 by OttoBotCode 
    /// on YouTube as a reference.
    /// </summary>
    public class SheepMovement : IMovement
    {

        public BoardPosition FromPos { get; }
        public BoardPosition ToPos { get; }

        public SheepMovement(BoardPosition from, BoardPosition to)
        {
            FromPos = from;
            ToPos = to;
        }
        //Used ai assistance to complete the only moves sheep can make.
        public void Move(Board board)
        {
            PlayerPiece piece = board.GetPiece(FromPos.Row, FromPos.Column);

            //Check if destination is valid
            if (board.GetPiece(ToPos.Row, ToPos.Column) != null)
            {
                throw new InvalidOperationException($"Target position {ToPos} is already occupied.");
            }

            board.SetPiece(ToPos.Row, ToPos.Column, piece);
            board.SetPiece(FromPos.Row, FromPos.Column, piece);
            piece.HasMoved = true;
            
            
        }
    }
}