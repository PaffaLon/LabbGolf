using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using Golf.Engine;
using Golf.UI.Menus.Content;

namespace Golf.UI.Menus
{
    public class MenuManager
    {
        public List<string> AccessAcctions { get; set; }
        public static List<string> MenuActions { get; set; }
        private enum AppMenus
        { 
            StartMenu,
            InGameMenu,
            LevelSelectorMenu
        }
        #region        
        private int ActiveAppMenu { get; set; }
        private int FeatureRequest { get; set; }
#endregion
        StartMenu startMenu = new StartMenu();
        LevelBrowser levelSelector = new LevelBrowser();
        
        public MenuManager()
        {
            MenuActions = new List<string>();
            AccessAcctions = new List<string>();
        }
        
        public string GetUserActions()
        {
            MenuActions.Add(startMenu.ID);
            MenuActions.Add(levelSelector.ID);

            foreach (var item in MenuActions)
                return item.ToString();
            


            return MenuActions.ToString();            
        }

        /// <summary>
        /// Requests the needed menu infomation from the respective menu componnent.
        /// </summary>
        public Tuple<int,bool> GetMenu(bool running)
        {
            ClearMenuElements();
            if(ActiveAppMenu == (int)AppMenus.StartMenu)
            {
                startMenu.Content(startMenu.ActiveButton);
                
                /*
                startMenu.Content(startMenu.Button);
                foreach (var item in startMenu.GetMenuItems)
                    startMenu.Elements.Add(item);
                */
            }
            if(ActiveAppMenu == (int)AppMenus.InGameMenu)
            {

            }
            PrintMenuContent();
            MenuNavigation(ref running);

            var momo = Tuple.Create(item1: FeatureRequest, item2: running);
            Debug.Print("GetMenu running: " + running.ToString());
            Debug.Print("-.-.-.-.-.-");
            return momo;
        }

        private void PrintMenuContent()
        {
            Console.Clear();
            if(ActiveAppMenu == (int)AppMenus.StartMenu)
                CenterText();

            if (ActiveAppMenu == (int)AppMenus.LevelSelectorMenu);
            if (ActiveAppMenu == (int)AppMenus.InGameMenu);
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

            if(ActiveAppMenu == (int)AppMenus.StartMenu)
            {
                if(cki.Key.GetHashCode() == 38)
                {
                    startMenu.ActiveButton -= 1;
                    if (startMenu.ActiveButton < 0)
                        startMenu.ActiveButton = 0;
                }
                else if(cki.Key.GetHashCode() == 40)
                {
                    startMenu.ActiveButton += 1;
                    if (startMenu.ActiveButton > 3)
                        startMenu.ActiveButton = 3;
                }
                else if(cki.Key.GetHashCode() == 13 && startMenu.ActiveButton == (int)StartMenu.Buttons.Play)
                {
                    FeatureRequest = (int)AppEngine.Sequence.RunCharacterCreator;
                }
                else if(cki.Key.GetHashCode() == 13 && startMenu.ActiveButton == (int)StartMenu.Buttons.Load)
                {
                    Console.Clear();
                    Console.WriteLine("The Scoreboard has not jet been implemented.");
                    Thread.Sleep(1000);
                }
                else if(cki.Key.GetHashCode() == 13 && startMenu.ActiveButton == (int)StartMenu.Buttons.Scoreboard)
                {
                    Console.Clear();
                    Console.WriteLine("The Scoreboard has not jet been implemented.");
                    Thread.Sleep(1000);
                    //FeatureSend = (int)AppEngine.Sequence.
                }
                else if(cki.Key.GetHashCode() == 13 && startMenu.ActiveButton == (int)StartMenu.Buttons.Exit)
                { 
                    running = false;
                    Debug.Print("Expected false: " + running.ToString());
                }
            }
            if(ActiveAppMenu == (int)AppMenus.InGameMenu)
            {

            }

            //-END: of IF statments-\\
            Debug.Print("return running from NAV: " + running.ToString());
            var tuple = Tuple.Create(item1: running, item2: FeatureRequest);
            return tuple;
        }
        private void CenterText()
        {
            int col = Console.WindowHeight / Console.WindowHeight + 1;
            switch (ActiveAppMenu)
            {

                default:
                    foreach (var item in startMenu.Elements)
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

            if (startMenu.Elements != null)
                startMenu.Elements.Clear();
        }
    }
}
