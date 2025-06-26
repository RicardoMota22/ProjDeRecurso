
namespace WolfAndSheep.Model
{
    public enum PlayerType
    {
        // Represent players, in case of draw use None
        
        Wolf,
        Sheep
    }
    /// <summary>
    /// /// Uses Programming a Chess Game in C# | Part 2 by OttoBotCode on YouTube as a reference.
    /// Switches the player type.
    public static class PlayerExtensions
    {
        public static PlayerType Switch(this PlayerType player)
        {
            return player switch
            {
                PlayerType.Wolf => PlayerType.Sheep,
                PlayerType.Sheep => PlayerType.Wolf,
                _ => throw new System.NotImplementedException(),
            };
        }
    }
}