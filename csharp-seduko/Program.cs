using System;

namespace csharp_seduko
{
    class Program
    {
        double NewNumber = 1.345;

        static void AddNumbers(double Number1)
        {
            int Number2 = 2;

            double Number3 = Number1 + Number2;

            Console.WriteLine(Number3);
        }

        static void NewMethod(string fname)
        {
            Console.WriteLine(fname);
        }
        static void Main()
        {
            NewMethod("Test Name");

            

            Console.WriteLine("Hello World!\nthis is a test");
        }
    }
}
