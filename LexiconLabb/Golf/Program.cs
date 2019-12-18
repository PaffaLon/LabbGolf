using System;
using Golf.UI.Menus;
using Golf.Engine;

namespace Golf
{
    class Program
    {
        static void Main()
        {
            /*
            MenuManager menuManager = new MenuManager();
            menuManager.GetMenu();
            */
            AppRuntime appRuntime = new AppRuntime();
            appRuntime.RunTime();
        }
    }
}
