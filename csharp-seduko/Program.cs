using System;

namespace csharp_seduko
{
    class Program
    {
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
