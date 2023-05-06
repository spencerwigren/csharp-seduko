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
            will come back to find a solutions 
            * streamreader
            */
   
            // reads txt file
            if (File.Exists("SolutionsFile.txt"))
                // Will need to update path
            {
                Console.WriteLine("File exist\n");
                ShowOptions();
            }
            else
            {
                Console.WriteLine("File Does not exist!\n");
                ShowOptions();
            }
        }

        static Tuple<string, string, string> GetCellEdit()
        {
            /* This method will get the user input
             * As a string for the cell user is editing
             * And a string value for the new value of the cell
             * Which will be returned as a tuple
             * 
             * Will need to write logic to check for expections
             * 
             */

            /* if col <= 9 Board[Col, Row] == NewCelValue
             *         contiune
             * else 
             * get new col and new row
             */

            Console.Write("Which Cololum would you like to edit\n");
            string Col = UserInput();

            Console.Write("Which Row would you like to edit\n");
            string Row = UserInput();

            Console.Write("Editing Cell: " +
                Row + " " + Col +  "\n");

            Console.Write("New Value > ");
            string NewCellValue = Console.ReadLine();

            Console.WriteLine("Cell Editing: " + Row + " " + Col +
                "\nNew Value: " + Convert.ToInt32(NewCellValue) + "\n");

            var CellValues = Tuple.Create(Col, Row, NewCellValue);

            return CellValues;


        }
        
        static int[,] EditBoard(int[,] Board)
        {
            /* This method will edit the board with a user input From GetCellEdit
             * Once methds geets values will edit the Board
             * Then will dispaly the board onced it is edited
             */
            Tuple<string, string, string> CellValues = GetCellEdit();
            //Console.WriteLine(CellValues);
            int Row = Convert.ToInt32(CellValues.Item1) - 1;
            int Col = Convert.ToInt32(CellValues.Item2) - 1;
            int NewCellValue = Convert.ToInt32(CellValues.Item3);


            Board[Row, Col] = NewCellValue;

            //DisplayBoard(Board);

            return Board;

        }

        static void DisplayBoard(int[,] Board)
        {
            /*
             Will display the board, when player calls for it
             */

            int count = 1;
            int SideNumber = 2;
            string BoardSectionDivisor = "  -+-+-+-+-+-+-+-+-";

            Console.Write("  1 2 3 4 5 6 7 8 9\n1 ");

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
            Console.Write("> ");
            string UserOption = Console.ReadLine();

            return UserOption;
        }

        static void ShowOptions()
        {
            Console.WriteLine("Options: \nShow Options again - S");
            Console.WriteLine("Display Baord - D");
            Console.WriteLine("Edit the Board - E");
            Console.WriteLine("Load File - F");
            Console.WriteLine("End Game - G\n");
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
                    case "E":
                        Console.WriteLine("Editing a cell:");
                        int[,] NewBoard = EditBoard(Board);
                        DisplayBoard(NewBoard);
                        ShowOptions();
                        break;
                    case "F":
                        Console.WriteLine("Loading File");
                        ReadFile();
                        break;
                    case "G":
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
            DisplayBoard(Board);
            ShowRunner(RunGame, Board);

        }
    }
}
