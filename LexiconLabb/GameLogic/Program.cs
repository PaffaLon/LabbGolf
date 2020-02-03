using System;

namespace GameLogic
{
    class Program
    {
        private static bool _running;
        static void Main()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();

            Console.WriteLine(cki.Key.GetHashCode());

            //Up: 38
            //Down: 40
            //Space: 32

            while (_running == true)
            {
                if (cki.Key.GetHashCode() == 38)//Key UP
                {

                }
                else if (cki.Key.GetHashCode() == 40)//Key DOWN
                {

                }
                else if (cki.Key.GetHashCode() == 32)
                {

                }
                else
                {

                }
            }

        }
    }
}
