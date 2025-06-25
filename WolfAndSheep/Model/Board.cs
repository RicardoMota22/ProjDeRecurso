using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WolfAndSheep.Model
{
    public class Board
    {
        /// <summary>
        /// Represents the game board for the Wolf and Sheep game.
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>

        /*char[,] board = {
            { ' ', ' ', 'W', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { 'S', ' ', 'S', ' ', 'S', ' ', 'S', ' ' }
        };*/
        /*public static List<BoardPosition> FindPositions(char[,] board)
        {
            List<BoardPosition> positions = new List<BoardPosition>();           
            // Finds all positions of a specific character on the board.
            
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {

                    if (board[row, column] == ' ')
                    {
                        // If the cell is empty, add its position to the list.
                        positions.Add(new BoardPosition(row, column));
                        
                    }
                }

            }
        }*/
        /// <summary>
        /// Represents the game board for the Wolf and Sheep game.
        /// Uses Programming a Chess Game in C# | Part 3 by OttoBotCode on YouTube as a reference.
        private readonly PlayerPiece[,] pieces = new PlayerPiece[8, 8];

        public PlayerPiece GetPiece(int row, int column)
        {
            return pieces[row, column];
        }

        public void SetPiece(int row, int column, PlayerPiece value)
        {
            pieces[row, column] = value;
        }
        public PlayerPiece GetPosition(BoardPosition position)
        {
            if (position.Row < 0 || position.Row >= 8 || position.Column < 0 || position.Column >= 8)
            {
                throw new ArgumentOutOfRangeException("Position is out of bounds of the board.");
            }
            //add case where other piece is in position
            if (pieces[position.Row, position.Column] != null)
            {
                throw new InvalidOperationException($"Piece at the specified position{position.Row},{position.Column}.");
            }

            return pieces[position.Row, position.Column];
        }

        public void SetPosition(BoardPosition position, PlayerPiece value)
        {
            if (position.Row < 0 || position.Row >= 8 || position.Column < 0 || position.Column >= 8)
            {
                throw new ArgumentOutOfRangeException("Position is out of bounds of the board.");
            }
            //add case where other piece is in position
            if (pieces[position.Row, position.Column] != null)
            {
                throw new InvalidOperationException("Piece at the specified position.");
            }
            pieces[position.Row, position.Column] = value;
        }

        public static Board InitialBoard()
        {
            Board board = new Board();
            // Initialize pieces
            board.AddStartPieces();
            return board;
        }
        private void AddStartPieces()
        {
            // Add sheep pieces to the board
            SetPosition(new BoardPosition(7, 0), new Sheep(PlayerType.Sheep));
            SetPosition(new BoardPosition(7, 2), new Sheep(PlayerType.Sheep));
            SetPosition(new BoardPosition(7, 4), new Sheep(PlayerType.Sheep));
            SetPosition(new BoardPosition(7, 6), new Sheep(PlayerType.Sheep));


            // Add wolf piece to the board
            SetPosition(new BoardPosition(0, 1), new Wolf(PlayerType.Wolf));
        }

    }
}