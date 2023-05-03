using System;

namespace csharp_seduko
{
    class Program
    {
        static string ShowOptions()
        {
            Console.WriteLine("Options: \nShow Options again - S");
            Console.WriteLine("End Game - E");
            string UserInput = Console.ReadLine();
            return UserInput;
        }

        static void ShowRunner(string UserInput)
        {
            // this is control options for playing the game

            switch (UserInput.ToUpper())
            {
                case "S":
                    Console.WriteLine("Show Instrutsion again");
                    ShowOptions();
                    break;
                case "E":
                    Console.WriteLine("End Game");
                    break;
            }
        }

        static void Main()
        {
            ShowRunner(ShowOptions());

        }
    }
}
