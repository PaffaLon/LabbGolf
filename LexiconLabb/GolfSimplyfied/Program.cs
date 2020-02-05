using System;
using GolfSimplyfied.UI.Menus;

namespace GolfSimplyfied
{
    static class Program
    {
        static void Main()
        {
            MenuHandler menuHandler = new MenuHandler();
                        menuHandler.LoadMenu(MenuHandler.MenuID.StartMenu);
                        menuHandler.GetMenu();
        }
    }
}
<