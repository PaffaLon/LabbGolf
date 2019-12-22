using System;
using System.Threading;
using System.Diagnostics;
using Golf.Engine;
using Golf.UI.Menus.Content;

namespace Golf.UI.Menus
{
    public class MenuManager
    {
        MainMenu mainMenu = new MainMenu();
        private enum ApplicationMenus{
            StartMenu,
            InGameMenu
        }

        private int ActiveAppMenu { get; set; }
        public MenuManager()
        {
            ActiveAppMenu = (int)ApplicationMenus.StartMenu;
            mainMenu.Button = (int)MainMenu.Buttons.Play;
        }

        /// <summary>
        /// Requests the needed menu infomation from the respective menu componnent.
        /// </summary>
        public Tuple<int,bool> GetMenu(bool running)
        {
            ClearMenuElements();
            if(ActiveAppMenu == (int)ApplicationMenus.StartMenu)
            {
                mainMenu.Content(mainMenu.Button);
                foreach (var item in mainMenu.GetMenuItems)
                    mainMenu.Elements.Add(item);
            }
            if(ActiveAppMenu == (int)ApplicationMenus.InGameMenu)
            {

            }
            PrintMenuContent();
            MenuNavigation(ref running);

            var momo = Tuple.Create(item1: ActiveAppMenu, item2: running);
            Debug.Print("GetMenu running: " + running.ToString());
            Debug.Print("-.-.-.-.-.-");
            return momo;
        }

        private void PrintMenuContent()
        {
            Console.Clear();
            if(ActiveAppMenu == (int)ApplicationMenus.StartMenu)
                CenterText();
        }
        
        /// <summary>
        /// Make it possible for the user to interact and navigate with the applications menues.
        /// Pressing a arrow key results in one behavior.
        /// Pressing the enter key results in one behavior.
        /// This allows the user to reach a deeper level in the application in a logical manner.
        /// </summary>
        private Tuple<bool, int> MenuNavigation(ref bool running)
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();

            if(ActiveAppMenu == (int)ApplicationMenus.StartMenu)
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
                    ActiveAppMenu = (int)AppEngine.Sequence.RunCharacterCreator;
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
                    /*
                    AppRuntime appRuntime = new AppRuntime();
                    appRuntime.Running = false;
                    */
                    running = false;
                    Debug.Print("Expected false: " + running.ToString());
                }
            }

            //-END: of IF statments-\\
            Debug.Print("return running from NAV: " + running.ToString());
            var tuple = Tuple.Create(item1: running, item2: ActiveAppMenu);
            return tuple;
        }
        private void CenterText()
        {
            int col = Console.WindowHeight / Console.WindowHeight + 1;
            switch (ActiveAppMenu)
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

        /// <summary>
        /// Empties the stored content of the list
        /// to prevent data overflow, data conflict, data coruption & memory loss.
        /// </summary>
        private void ClearMenuElements()
        {
            if (Console.CursorVisible == true)
                Console.CursorVisible = false;

            if (mainMenu.Elements != null)
                mainMenu.Elements.Clear();
        }
    }
}
