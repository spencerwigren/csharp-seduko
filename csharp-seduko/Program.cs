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
        static void Main()
        {
            string UserInput = ShowOptions();


           switch (UserInput)
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
    }
}
