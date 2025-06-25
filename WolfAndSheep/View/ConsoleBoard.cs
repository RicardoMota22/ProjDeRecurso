using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace WolfAndSheep.View
{
    public class ConsoleBoard : IView
    {
        //Create Chess like board (8x8) using Console.Spectre

        //Display Title of the game
        public void DisplayWelcomeSign()
        {
            AnsiConsole.Write(
                new FigletText("Wolf and Sheep")
                    .Centered()
                    .Color(Color.Red));
        }
        public void DisplayMessage(string message)
        {
            AnsiConsole.MarkupLine($"[bold yellow]{message}[/]");
        }
        /// <summary>
        /// Displays the rules of the game in a formatted manner.
        /// </summary>
        public void DisplayRules()
        {
            AnsiConsole.Write("[bold green]Rules of the Game:[/]");
            AnsiConsole.Write("1. The game is played on an 8x8 board only on the dark squares.");
            AnsiConsole.Write("2. The four white pieces, the sheep, are placed on the dark squares on the south side of the board.");
            AnsiConsole.Write("3. The black piece, the wolf, is placed on any of the dark squares on the opposite side.");
            AnsiConsole.Write("4. The wolf's goal is to reach one of the sheep's original squares.");
            AnsiConsole.Write("5. The sheep's goal is to block the wolf from reaching one of its original squares.");
            AnsiConsole.Write("6. Sheep move diagonally and forward, one square per turn.");
            AnsiConsole.Write("7. The wolf moves diagonally, one square per turn, either forward or backwards.");
            AnsiConsole.Write("8. The wolf always moves first.");
            AnsiConsole.Write("9. On the sheep's turn, only one sheep can be moved.");
            AnsiConsole.Write("10. Pieces can only move to empty dark squares.");
            AnsiConsole.Write("11. The wolf wins if it reaches one of the sheep's original squares.");
            AnsiConsole.Write("12. The sheep win if they block the wolf so that it cannot move.");
        }
        public void DisplayInstructions()
        {
            AnsiConsole.MarkupLine($"[bold yellow]Write the positions of where you want to place Piece[/]");
            AnsiConsole.MarkupLine($"[bold yellow]Example: A1, B2, C3, D4[/]");
        }

        //Display the board
        /// <summary>
        /// Displays the chess-like board using Spectre.Console.
        /// </summary>
        public void DisplayBoard()
        {
            //Create table 
            var table = new Table();

            //Add columns to the table
            //table.AddColumn(new TableColumn("A").Centered());
            //table.AddColumn(new TableColumn("B").Centered());
            //table.AddColumn(new TableColumn("C").Centered());
            //table.AddColumn(new TableColumn("D").Centered());
            //table.AddColumn(new TableColumn("E").Centered());
            //table.AddColumn(new TableColumn("F").Centered());
            //table.AddColumn(new TableColumn("G").Centered());
            //table.AddColumn(new TableColumn("H").Centered());
            for (char col = 'A'; col <= 'H'; col++)
            {
                table.AddColumn(new TableColumn(col.ToString()).Centered());
            }

            //Add rows to the table
            for (int row = 0; row < 8; row++)
            {
                table.AddRow("", "", "", "", "", "", "", "");

                //Check with squares are dark or light
                var squares = new List<IRenderable>();
                for (int col = 0; col < 8; col++)
                {
                    if ((row + col) % 2 != 0) //Checks if sum is odd
                    {
                        //Dark square
                        bool isDarkSquare = true;
                        var squareColour = isDarkSquare ? "grey" : "white";
                        squares.Add(new Markup($"[grey on {squareColour}]    [/]").Centered());
                    }
                    else
                    {
                        //Light square
                        squares.Add(new Markup("[white on white]    [/]").Centered());
                    }
                }
                table.AddRow(squares);

            }
            //Hides the headers of the table
            table.HideHeaders();
            //Renders the board
            AnsiConsole.Write(table);
        }

        public string AskForMenuChoice()
        {
            List<string> options = new List<string>
                {
                    "Play Wolf and Sheep",
                    "Exit"
                };

            return AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[bold]Select an option[/]")
                    .AddChoices(options)
            );
        }
    }
}