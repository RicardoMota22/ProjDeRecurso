using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WolfAndSheep.View
{
    /// <summary>
    /// Interface for the view in the Wolf and Sheep game.
    /// This interface defines methods for displaying various game-related 
    /// information to the user.
    /// </summary>
    public interface IView
    {
        public void DisplayWelcomeSign();
        public void DisplayMessage(string message);
        public void DisplayRules();
        public void DisplayInstructions();
        public void DisplayBoard();
        public string AskForMenuChoice();
    }
}