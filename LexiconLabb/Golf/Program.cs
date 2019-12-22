using Golf.Engine;
using System;

namespace Golf
{
    class Program
    {
        static void Main()
        {
            /***    The Engine is still in an experimental mode.    ****/
            TrackKeyPress();
            AppEngine appRuntime = new AppEngine();
            appRuntime.RunTime();
        }

        static void TrackKeyPress()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();

            Console.WriteLine(cki.Key.GetHashCode().ToString());
            Console.ReadKey();
        }
    }
}