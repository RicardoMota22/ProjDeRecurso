using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WolfAndSheep.Model
{
    /// <summary>
    /// Represents a piece on the board, which can be either a sheep or a wolf.
    /// Uses Programming a Chess Game in C# | Part 3 by OttoBotCode on YouTube as a reference.
    /// </summary>
    public abstract class PlayerPiece
    {
        public abstract PlayerType Type { get; }
        public abstract PlayerType Colour { get; }
        public bool HasMoved { get; set; } = false;
    }
}