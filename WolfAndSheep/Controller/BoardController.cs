using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WolfAndSheep.Model;
using WolfAndSheep.View;

namespace WolfAndSheep.Controller
{
    public class BoardController
    {
        private readonly Board board;
        private readonly IView view;

        public BoardController(Board board, IView view)
        {
            this.board = board;
            this.view = view;

        }
        public void Run()
        {
            view.DisplayWelcomeSign();
            view.DisplayRules();
            view.DisplayInstructions();

            string choice = view.AskForMenuChoice();
            switch (choice)
            {
                case "1":
                    view.DisplayMessage("Start Game");
                    view.DisplayBoard();
                    break;
                case "2":
                    view.DisplayMessage("Exit the game.");
                    // Exit the game
                    break; 
                default:
                    view.DisplayMessage("Invalid choice. Please try again.");
                    return; // Exit if invalid choice
            }


            while (true)
            {
                // Main game loop
                view.DisplayBoard();

                // Check for game over conditions
                if (board.IsGameOver())
                {
                    view.DisplayMessage("Game Over!");
                    break;
                }

                // Handle player moves
                var move = board.ResetBoard();
                view.AskForPlayerMove();
                if (move != null)
                {
                    move.ResetBoard();
                }
                else
                {
                    view.DisplayMessage("Invalid move. Try again.");
                }
            }
        }
    }
}