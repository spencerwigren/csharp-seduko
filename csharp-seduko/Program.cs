﻿using System;
using System.IO;

namespace csharp_seduko
{
    class Program
    {
        static void ReadFile()
        {
            // method to read a file
            // could not get "SolutionsFile.txt" to load in current directory
            // will come back to find a solutions
   
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

        static string UserInput()
        {
            // get user input
            string UserOption = Console.ReadLine();

            return UserOption;
        }

        static void ShowOptions()
        {
            Console.WriteLine("Options: \nShow Options again - S");
            Console.WriteLine("Load File - F");
            Console.WriteLine("End Game - E\n");
        }

        static void ShowRunner(bool RunGame)
        {
            // this is control options for playing the game
            while (RunGame == true)
            {
                switch (UserInput().ToUpper())
                {
                    case "S":
                        Console.WriteLine("Show Instrutsion again");
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
            bool RunGame = true;

            ShowOptions();
            ShowRunner(RunGame);

        }
    }
}
