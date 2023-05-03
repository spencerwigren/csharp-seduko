using System;
using System.IO;

namespace csharp_seduko
{
    class Program
    {
        static void ReadFile()
        {
            // reads txt file
            
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
