using System;
using System.Collections.Generic;
using Spectre.Console;

namespace WolfAndSheep
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
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
                
                for (int col = 0; col < 8; col++)
                {
                    if ((row + col) % 2 == 0) //Checks if sum is even
                    {
                        //Dark square
                        Console.Write("D");

                    }
                    else
                    {
                        //Light square
                        Console.Write("L");

                    }
                }
            }

            //Hides the headers of the table
            table.HideHeaders();
            //Renders the board
            AnsiConsole.Write(table);
        
            


        }
    }
}
