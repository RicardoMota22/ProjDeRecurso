
namespace WolfAndSheep.Model
{
    public enum PlayerType
    {
        // Represent players, in case of draw use None
        None,
        Wolf,
        Sheep
    }

    public static class PlayerExtensions
    {
        public static PlayerType Switch(this PlayerType player)
        {
            return player switch
            {
                PlayerType.Wolf => PlayerType.Sheep,
                PlayerType.Sheep => PlayerType.Wolf,
                _ => PlayerType.None,
            };
        }
    }
}