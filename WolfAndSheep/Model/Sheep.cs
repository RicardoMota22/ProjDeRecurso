using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WolfAndSheep.Model
{
    public class Sheep : PlayerPiece
    {
        /// <summary>
        /// Represents a sheep player piece in the game.
        /// Sheep can only move in two directions: NorthEast and NorthWest.
        /// </summary>
        public override PlayerType Type => PlayerType.Sheep;
        public override PlayerType Colour { get; }
        private static readonly PlayerDirection [] dir = new PlayerDirection[]
        {
            PlayerDirection.NorthEast,
            PlayerDirection.NorthWest,
        };

        public Sheep(PlayerType colour)
        {
            Colour = colour;
        }

        public void HasMove()
        {
            HasMoved = true;
        }
        
    }
}