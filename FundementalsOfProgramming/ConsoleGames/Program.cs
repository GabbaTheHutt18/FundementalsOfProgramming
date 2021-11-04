using System;

namespace ConsoleGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to noughts and crosses!");
            string[,] grid = new string[3, 3]
                {
                    {"-", "-", "-"},
                    {"-", "-", "-"},
                    {"-", "-", "-"}
                };

            OutputGrid(grid);
            do
            {

                grid = PlayerChoice(grid);
                OutputGrid(grid);
                CheckGridSpace(grid);
            } while (CheckGridSpace(grid) == true);



        }

        static bool CheckGridSpace(string[,] grid)
        {
            bool space = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j] == "-") //Check to see if the grid has space
                    {
                        space = true;

                    }
                }

            }
            return space;
        }

        static string[,] PlayerChoice(string[,] grid)
        {
            string[] playerSymbols = new string[] { "X", "O" };
            Console.WriteLine("Player 1 is O and Player 2 is X");
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine($"Player {i + 1}'s Turn");
                int row = GetRow();
                int column = GetColumn();
                bool validChoice = TurnCheck(grid, row, column);
                while (validChoice == true)
                {
                    row = GetRow();
                    column = GetColumn();
                    validChoice = TurnCheck(grid, row, column);

                }
                grid[row, column] = playerSymbols[i];

            }
            return grid;

        }

        static int GetRow()
        {
            Console.WriteLine("Please enter the row you'd like to play in (1 - 3)");
            int row = (Int32.Parse(Console.ReadLine()) - 1);
            return row;
        }

        static int GetColumn()
        {
            Console.WriteLine("Please enter the column you'd like to play in (1 - 3)");
            int column = (Int32.Parse(Console.ReadLine()) - 1);
            return column;
        }


        static bool TurnCheck(string[,] grid, int row, int column)
        {

            if (grid[row, column] != "-")
            {
                Console.WriteLine("Invalid Choice Please try again :)");
                return true;
            }
            return false;
        }

        static void OutputGrid(string[,] grid)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }
        }

        static bool CheckWin(string [,] grid)
        {
            bool win = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                
                }

                return win;
        }
        
    }
}
