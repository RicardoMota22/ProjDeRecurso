using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WolfAndSheep.View
{
    public interface IView
    {
        public void DisplayWelcomeSign();
        public void DisplayMessage(string message);
        public void DisplayRules();
        public void DisplayInstructions();
        public void DisplayBoard();
    }
}