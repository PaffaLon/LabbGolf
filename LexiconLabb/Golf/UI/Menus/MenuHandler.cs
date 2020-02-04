using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using Golf.UI.Menus.Content;

namespace Golf.UI.Menus
{
    public enum MenuID
    {
        StartMenu,
        InGameMenu
    }
    public class MenuHandler
    {
        //Public Initialization
        public static List<string> AppFeatureAccess { get; set; }
        public static List<string> MenuFeatuers     { get; set; }

        // Private Initialization
#region Private
        private string _appFeatureRequest;
        private bool _defaultValuesSet;
        private int _runAppMenu;
#endregion
        // object Initialization
        StartMenu startMenu = new StartMenu();
        public MenuHandler()
        {
            if(MenuFeatuers == null && AppFeatureAccess == null)
            {
                AppFeatureAccess = new List<string>();
                MenuFeatuers = new List<string>();
            }
            
            if (_defaultValuesSet == false)
            {
                CreateMenuFeatureSignatuers();
                SetDefaultValues();
            }
        }
        //Constructor Helper Methods
 #region CHH
        private void CreateMenuFeatureSignatuers()
        {
            foreach (var item in Enum.GetNames(typeof(MenuID)))
                MenuFeatuers.Add(item);
        }
        private void SetDefaultValues()
        {
            _runAppMenu = (int)MenuID.StartMenu;
            _defaultValuesSet = true;
        }
#endregion
        //ClassMethods
        public void LoadMenu(string appFeature)
        {
            if(appFeature == MenuFeatuers[0])
                _runAppMenu = (int)MenuID.StartMenu;
            //=================================\\
            else if (appFeature == MenuFeatuers[1])
                _runAppMenu = (int)MenuID.InGameMenu;
            //=================================\\
            else
            {
                Debug.Print("||====================||"          + Environment.NewLine
                            + "Error Code: unknown_app_feature" + Environment.NewLine
                            + $"appFeature: {appFeature}"       + Environment.NewLine 
                            + "Program location: MenuHandler.LoadForm");
            }
            _appFeatureRequest = appFeature;
        }
        public void LoadMenu(MenuID appMenus)
        {
            switch (appMenus)
            {
                case MenuID.StartMenu:
                    _runAppMenu = (int)MenuID.StartMenu;
                    break;
                case MenuID.InGameMenu:
                    _runAppMenu = (int)MenuID.StartMenu;
                    break;
                default:
                    break;
            }
        }
        public Tuple<bool, string> GetMenu(ref bool running)
        {
            ClearMenuElements();
            if(_runAppMenu == (int)MenuID.StartMenu)
            {
                startMenu.LoadMenu(startMenu.PressedButton);
                foreach (var item in startMenu.MenuElements)
                {
                    Debug.Print($"MenuHandler || startMenu.MenuElements: {item}");
                } 

                PrintMenu();
                MenuNavigation(ref running);
            }
            else if (_runAppMenu == (int)MenuID.InGameMenu)
            {

            }

            var tuple = Tuple.Create(item1: running, item2: _appFeatureRequest);
            return tuple;
        }                                                                              
        private void PrintMenu()
        {
            if (_runAppMenu == (int)MenuID.StartMenu)
            {
                int col = 1;
                foreach (var item in startMenu.MenuElements)
                {
                    Console.SetCursorPosition(((Console.WindowWidth - item.Length) / 2), Console.WindowHeight / 2 + col++);
                    Console.Write(item + Environment.NewLine);
                }
            }
        }
        private bool MenuNavigation(ref bool running)
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();
            if(_runAppMenu == (int)MenuID.StartMenu)
            {
                //navigate UP or DOWN.
                if (cki.Key.GetHashCode() == 38 || cki.Key.GetHashCode() == 33)//ArrowUp, PgUp
                {
                    startMenu.PressedButton -= 1;
                    if (startMenu.PressedButton < 1)
                        startMenu.PressedButton = 1;
                }
                else if (cki.Key.GetHashCode() == 40 || cki.Key.GetHashCode() == 34)//ArrowDown, PgDn
                {
                    startMenu.PressedButton += 1;
                    if (startMenu.PressedButton > 4)
                        startMenu.PressedButton = 4;
                }
                else if (cki.Key.GetHashCode() == 9)// TAB
                {
                    startMenu.PressedButton -= 1;
                    if (startMenu.PressedButton < 1 || startMenu.PressedButton > 3)                        startMenu.PressedButton = 1;
                }
                //Pressed Buttons
                else if (cki.Key.GetHashCode() == 13 && startMenu.PressedButton == (int)StartMenu.Buttons.NewGame)
                {
                    _appFeatureRequest = AppFeatureAccess[0];
                    Debug.Print(Environment.NewLine);
                    Debug.Print($"_appFeatureRequest {_appFeatureRequest}");
                    //Console.Clear();
                    //Console.WriteLine("The New Game feature have not been implemented.");
                    //Thread.Sleep(1000);
                }
                else if (cki.Key.GetHashCode() == 13 && startMenu.PressedButton == (int)StartMenu.Buttons.LoadGame)
                {
                    Console.Clear();
                    Console.WriteLine("The Load Game feature have not been implemented.");
                    Thread.Sleep(1000);
                }
                else if (cki.Key.GetHashCode() == 13 && startMenu.PressedButton == (int)StartMenu.Buttons.ScoreBoard)
                {
                    Console.Clear();
                    Console.WriteLine("The ScoreBoard feature have not been implemented.");
                    Thread.Sleep(1000);
                }
                else if (cki.Key.GetHashCode() == 13 && startMenu.PressedButton == (int)StartMenu.Buttons.Exit)
                {
                    running = false;
                }
            }
            return running;
        }
        private void ClearMenuElements()
        {
            Console.Clear();
            if (Console.CursorVisible == true)
                Console.CursorVisible = false;

            if (startMenu.MenuElements != null)
                startMenu.MenuElements.Clear();
        }
    }
}
