using System;
using Golf.UI.Menus;
using Golf.Engine;

namespace Golf
{
    class Program
    {
        static void Main()
        {
            /*  --The comented code is left for testing.
            MenuManager menuManager = new MenuManager();
            menuManager.GetMenu();
            */

            /***    The Engine is still in an experimental mode.    ****/
            AppRuntime appRuntime = new AppRuntime();
            appRuntime.RunTime();
        }
    }
}
