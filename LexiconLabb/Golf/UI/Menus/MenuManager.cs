using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Golf.UI.Menus.Content;

namespace Golf.UI.Menus
{
    class MenuManager
    {
        MainMenu mainMenu = new MainMenu();

        private enum ApplicationMenus{
            SplashMenu,
            LoadGame,
            ScoreBoardMenu,
        }
        private int ActiveApplicationMenu { get; set; }
        public MenuManager()
        {
            ActiveApplicationMenu = (int)ApplicationMenus.SplashMenu;
            mainMenu.Button = (int)MainMenu.Buttons.Play;
        }
        public void GetMenu()
        {
            ClearMenuElements();
            if(ActiveApplicationMenu == (int)ApplicationMenus.SplashMenu)
            {
                mainMenu.Content(mainMenu.Button);
                foreach (var item in mainMenu.GetMenuItems)
                    mainMenu.Elements.Add(item);
            }
            PrintMenuContent();
            MenuNavigation();
        }
        private void PrintMenuContent()
        {
            Console.Clear();
            if(ActiveApplicationMenu == (int)ApplicationMenus.SplashMenu)
            {
                CenterText();
            }
            else if(ActiveApplicationMenu == (int)ApplicationMenus.LoadGame)
            {
                //To do
            }
            else if(ActiveApplicationMenu == (int)ApplicationMenus.ScoreBoardMenu)
            {
                //To do
            }
        }
        private void MenuNavigation()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();

            if(ActiveApplicationMenu == (int)ApplicationMenus.SplashMenu)
            {
                if(cki.Key.GetHashCode() == 38)
                {
                    mainMenu.Button -= 1;
                    if (mainMenu.Button < 0)
                        mainMenu.Button = 0;
                }
                else if(cki.Key.GetHashCode() == 40)
                {
                    mainMenu.Button += 1;
                    if (mainMenu.Button > 3)
                        mainMenu.Button = 3;
                }
                else if(cki.Key.GetHashCode() == 13 && mainMenu.Button == (int)MainMenu.Buttons.Play)
                {
                    Console.Clear();
                    Console.WriteLine("The Scoreboard has not jet been implemented.");
                    Thread.Sleep(1000);
                }
                else if(cki.Key.GetHashCode() == 13 && mainMenu.Button == (int)MainMenu.Buttons.Load)
                {
                    Console.Clear();
                    Console.WriteLine("The Scoreboard has not jet been implemented.");
                    Thread.Sleep(1000);
                }
                else if(cki.Key.GetHashCode() == 13 && mainMenu.Button == (int)MainMenu.Buttons.Scoreboard)
                {
                    Console.Clear();
                    Console.WriteLine("The Scoreboard has not jet been implemented.");
                    Thread.Sleep(1000);
                }
                else if(cki.Key.GetHashCode() == 13 && mainMenu.Button == (int)MainMenu.Buttons.Exit)
                {
                    Environment.Exit(0);
                }
            }
            GetMenu();
        }
        private void CenterText()
        {
            int col = Console.WindowHeight / Console.WindowHeight + 1;
            switch (ActiveApplicationMenu)
            {
                default:
                    foreach (var item in mainMenu.Elements)
                    {
                        Console.SetCursorPosition((Console.WindowWidth - item.Length) / 2, Console.WindowHeight / 2 - 6 + col++);
                        Console.Write(item + Environment.NewLine);
                    }
                    break;
            }
        }
        private void ClearMenuElements()
        {
            if (Console.CursorVisible == true)
                Console.CursorVisible = false;

            if (mainMenu.Elements != null)
                mainMenu.Elements.Clear();
        }
    }
}
