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

        char[,] board = {
            { ' ', ' ', 'W', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { 'S', ' ', 'S', ' ', 'S', ' ', 'S', ' ' }
        };
        public static List<int[]> FindPositions(char[,] board)
        {
            List<int[]> positions = new List<int[]>();
            /// <summary>            
            /// /// Finds all positions of a specific character on the board.
            /// </summary>
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (board[row, column] != ' ')
                    {
                        positions.Add(new int[] { row, column });
                    }
                }
            }
        }
    }
}