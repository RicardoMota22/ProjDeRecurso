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
            view.AskForMenuChoice();
            view.DisplayBoard();

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
                var move = board.GetPlayerMove();
                if (move != null)
                {
                    move.Move(board);
                }
                else
                {
                    view.DisplayMessage("Invalid move. Try again.");
                }
            }
        }
    }
}