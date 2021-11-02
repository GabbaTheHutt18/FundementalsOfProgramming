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
                    {" ", " ", " "},
                    {" ", " ", " "},
                    {" ", " ", " "}
                };

            int gridLength = grid.Length;
        }

        static void checkGrid(int gridSize)
        {
            for (int i = 0; i < (gridSize - 1); i++)
            {
                if (true) //Check to see if the grid has space
                {

                }
            }
        }
    }
}
