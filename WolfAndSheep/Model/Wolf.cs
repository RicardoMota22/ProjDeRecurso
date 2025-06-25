using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WolfAndSheep.Model
{
    public class Wolf : PlayerPiece
    {
        public override PlayerType Type => PlayerType.Wolf;
        public override PlayerType Colour { get; }
        private static readonly PlayerDirection [] dir = new PlayerDirection[]
        {
            PlayerDirection.NorthEast,
            PlayerDirection.NorthWest,
            PlayerDirection.SouthEast,
            PlayerDirection.SouthWest,
        };

        public Wolf(PlayerType colour)
        {
            Colour = colour;
        }

        public void HasMove()
        {
            HasMoved = true;
        }
    }
    
}