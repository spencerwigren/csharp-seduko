using System;
using System.IO;

namespace csharp_seduko
{
    class Program
    {

        static void ReadFile()
        {
            /* method to read a file
            could not get "SolutionsFile.txt" to load in current directory
            will come back to find a solutions */
   
            // reads txt file
            if (File.Exists("SolutionsFile.txt"))
                // Will need to update path
            {
                Console.WriteLine("File exist");
                ShowOptions();
            }
            else
            {
                Console.WriteLine("File Does not exist!");
                ShowOptions();
            }
        }

        static void DisplayBoard(int[,] Board)
        {
            /*
             Will display the board, when player calls for it
             */
            
            int count = 1;
            int SideNumber = 2;
            string BoardSectionDivisor = "  -+-+-+-+-+-+-+-+-";

            Console.Write("  A B C D E F G H I\n1 ");

            for (int i = 0; i < Board.GetLength(0); i++)
            {

                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    // Display number from int multi array
                    if (Board[i, j] == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(Board[i, j]);
                    }

                    // Drawing the look of the board
                    if (count % 9 == 0)
                    {
                        Console.WriteLine();
                        if (SideNumber < 10)
                        {
                            Console.WriteLine(BoardSectionDivisor);
                            Console.Write(SideNumber++ + " ");
                        }
                        count++;
                        
                    }
                    else
                    {
                        Console.Write("|");
                        count++;
                    }

                }
                
            }
            Console.WriteLine();
        }

        static string UserInput()
        {
            // get user input
            string UserOption = Console.ReadLine();

            return UserOption;
        }

        static void ShowOptions()
        {
            Console.WriteLine("Options: \nShow Options again - S");
            Console.WriteLine("Display Baord - D");
            Console.WriteLine("Load File - F");
            Console.WriteLine("End Game - E\n");
        }

        static void ShowRunner(bool RunGame, int[,] Board)
        {
            /* This Method will control options for playing the game s*/
            while (RunGame == true)
            {
                switch (UserInput().ToUpper())
                {
                    case "S":
                        Console.WriteLine("Show Instrutsion again");
                        ShowOptions();
                        break;
                    case "D":
                        Console.WriteLine("Displing Board");
                        DisplayBoard(Board);
                        ShowOptions();
                        break;
                    case "F":
                        Console.WriteLine("Loading File");
                        ReadFile();
                        break;
                    case "E":
                        Console.WriteLine("End Game");
                        RunGame = false;
                        break;
                }
            }
        }

        static void Main()
        {

            int[,] Board = {
                {5,3,0,0,7,0,0,0,0},
                {6,0,0,1,9,5,0,0,0},
                {0,9,8,0,0,0,0,6,0},
                {8,0,0,0,6,0,0,0,3},
                {4,0,0,8,0,3,0,0,1},
                {7,0,0,0,2,0,0,0,6},
                {0,6,0,0,0,0,2,8,0},
                {0,0,0,4,1,9,0,0,5},
                {0,0,0,0,8,0,0,7,9}
                };
            bool RunGame = true;

            ShowOptions();
            ShowRunner(RunGame, Board);

        }
    }
}
