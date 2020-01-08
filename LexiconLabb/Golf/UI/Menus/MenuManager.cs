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
        private enum AppMenus
        {
            StartMenu,
            InGameMenu,
            LevelSelectorMenu
        }

        static public List<object> ObjGetAppMenues { get; set; }
        public List<object> AccessToObjects { get; set; }
        
        static public List<string> GetAppMenus { get; set; } 
        public List<int> Access { get; set; }
        #region        
        public object obj { get; set; }
        private int ActiveAppMenu { get; set; }
        private int FeatureRequest { get; set; }
#endregion
        StartMenu startMenu = new StartMenu();
        
        public MenuManager()
        {
            obj = startMenu;
            if (obj == startMenu)
                Debug.Print("StartMenu");

            ActiveAppMenu = (int)AppMenus.StartMenu;
            startMenu.Button = (int)StartMenu.Buttons.Play;
        }
        
        public List<object> GetMenuObjects(List<object> list)
        {
            Debug.Print("Hello");
            ObjGetAppMenues = new List<object>();
            if (ObjGetAppMenues.Count == 0)
                ObjGetAppMenues.Add(startMenu);

            else if (ObjGetAppMenues.Count > 0)
            {
                AccessToObjects = list;
            }

            ObjGetAppMenues.ForEach(el => Debug.Print("Objects in list: " + el.ToString()));
            return ObjGetAppMenues;
        }
        public List<string> GetEnumItemNames(List<string> menusRequest)
        {
            if (GetAppMenus == null)
            {
                GetAppMenus = new List<string>();
                foreach (var item in Enum.GetNames(typeof(AppMenus)))
                {
                    GetAppMenus.Add(Convert.ToString(item));
                    //GetAppMenus.Add(Convert.ToInt32(item));
                }
            }
            menusRequest = GetAppMenus;
            return menusRequest;
        }

        /// <summary>
        /// Requests the needed menu infomation from the respective menu componnent.
        /// </summary>
        public Tuple<int,bool> GetMenu(bool running)
        {
            ClearMenuElements();
            if(ActiveAppMenu == (int)AppMenus.StartMenu)
            {
                startMenu.Content(startMenu.Button);
                foreach (var item in startMenu.GetMenuItems)
                    startMenu.Elements.Add(item);
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
                    startMenu.Button -= 1;
                    if (startMenu.Button < 0)
                        startMenu.Button = 0;
                }
                else if(cki.Key.GetHashCode() == 40)
                {
                    startMenu.Button += 1;
                    if (startMenu.Button > 3)
                        startMenu.Button = 3;
                }
                else if(cki.Key.GetHashCode() == 13 && startMenu.Button == (int)StartMenu.Buttons.Play)
                {
                    FeatureRequest = (int)AppEngine.Sequence.RunCharacterCreator;
                }
                else if(cki.Key.GetHashCode() == 13 && startMenu.Button == (int)StartMenu.Buttons.Load)
                {
                    Console.Clear();
                    Console.WriteLine("The Scoreboard has not jet been implemented.");
                    Thread.Sleep(1000);
                }
                else if(cki.Key.GetHashCode() == 13 && startMenu.Button == (int)StartMenu.Buttons.Scoreboard)
                {
                    Console.Clear();
                    Console.WriteLine("The Scoreboard has not jet been implemented.");
                    Thread.Sleep(1000);
                    //FeatureSend = (int)AppEngine.Sequence.
                }
                else if(cki.Key.GetHashCode() == 13 && startMenu.Button == (int)StartMenu.Buttons.Exit)
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
