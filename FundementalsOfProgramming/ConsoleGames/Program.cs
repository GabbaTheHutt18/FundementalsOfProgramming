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

            do
            {
                Console.WriteLine("it works?");
                CheckGridSpace(grid);
            } while (CheckGridSpace(grid) == true);
            


        }

        static bool CheckGridSpace(string[,] grid)
        {
            bool space = false;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (grid[i,j] == " ") //Check to see if the grid has space
                    {
                        space = true;
                
                    }
                }
                
            }
            return space;
        }

        static void PlayerTurn(string[,] grid)
        {
            Console.WriteLine("Player 1 is O and Player 2 is X");
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine($"Player {i}'s Turn");
                Console.WriteLine("Please enter the row you'd like to play in (1 - 3)");
                int Row = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the column you'd like to play in (1 - 3)");
                int Column = Int32.Parse(Console.ReadLine());
                
            }
            
        }

        static void TurnCheck()
        {

        }

       
    }
}
