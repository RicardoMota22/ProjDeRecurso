using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WolfAndSheep.Model
{
    public class WolfMovement : Wolf, IMovement
    {
        /// <summary>
        /// Represents the movement of the wolf on the board.
        /// Implements the IMovement interface.
        /// Uses Programming a Chess Game in C# | Part 5 by OttoBotCode on 
        /// YouTube as a reference.
        /// </summary>

        public BoardPosition FromPos { get; }
        public BoardPosition ToPos { get; }

        public WolfMovement(BoardPosition from, BoardPosition to, PlayerType Colour) : base(Colour)
        {
            FromPos = from;
            ToPos = to;
        }
        //Used same ai assisted code to complete the only moves wolf can make.
        public void Move(Board board)
        {
            
            

            PlayerPiece piece = board.GetPiece(FromPos.Row, FromPos.Column);


            // Check if destination is valid
            if (board.GetPiece(ToPos.Row, ToPos.Column) != null)
            {
                throw new InvalidOperationException($"Target position {ToPos} is already occupied.");
                
            }
            //If wolf cant move from its position to another, game is over.
            if (ToPos.Equals(FromPos))
            {
                throw new InvalidOperationException($"Game ends.");

            }

            board.SetPiece(ToPos.Row, ToPos.Column, piece);
            board.SetPiece(FromPos.Row, FromPos.Column, null);
            piece.HasMoved = true;
        }
    }
}
