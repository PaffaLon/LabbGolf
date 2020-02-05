using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using GolfSimplyfied.UI.Menus.Content;

namespace GolfSimplyfied.UI.Menus
{
    public class MenuHandler
    {
        //Public Initialization
#region
        /// <summary>
        /// MenuID and refference key.
        /// </summary>
        public enum MenuID
        {
            StartMenu
        }
        public static List<Enum> FeatureIDAccess { get; set; }
        #endregion
        //Private Initialization
        #region
        private static Enum _requstedFeature;
        private bool _defaultValuesSet;
        private int _runAppMenu;
#endregion
        //Object Initialization
        StartMenu startMenu = new StartMenu();
        public MenuHandler()
        {
            if (FeatureIDAccess == null)
                FeatureIDAccess = new List<Enum>();

            if (_defaultValuesSet == false)
                SetDefaultValues();
        }
        //Constructor Helper Methods
#region CMM
        private void SetDefaultValues()
        {
            startMenu.PressedButton = (int)StartMenu.Buttons.NewGame;
            _runAppMenu = (int)MenuID.StartMenu;
            _defaultValuesSet = true;
        }
#endregion
        //Class Methods
        public void LoadMenu(Enum menuID)
        {
            switch (menuID)
            {
                case MenuID.StartMenu:
                    _runAppMenu = (int)MenuID.StartMenu;
                    break;
                default:
                    break;
            }
        }
        public Tuple<bool, Enum> GetMenu(ref bool running)
        {
            ClearMenuMemory();
            if(_runAppMenu == (int)MenuID.StartMenu)
            {
                startMenu.LoadMenu(startMenu.PressedButton);
            }   
            PrintMenu();
            Menunavigation(ref running);

            //Returns Engine Instructions
            var tuple = Tuple.Create(item1: running, item2: _requstedFeature);
            return tuple;
        }
        private void PrintMenu()
        {
            switch (_runAppMenu)
            {
                case (int)MenuID.StartMenu:
                    int col = 1;
                    foreach (var item in startMenu.MenuElements)
                    {
                        Console.SetCursorPosition(((Console.WindowWidth - item.Length) / 2), Console.WindowHeight / 2 + col++);
                        Console.Write(item + Environment.NewLine);
                    }
                    break;
                default:
                    break;
            }
        }
        private bool Menunavigation(ref bool running)
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();
            //Navigate UP or DOWN
            if (cki.Key.GetHashCode() == 38 || cki.Key.GetHashCode() == 33)//ArrowUp, PgUp
            {
                _requstedFeature = MenuID.StartMenu;
                //======||======||=======||======\\
                startMenu.PressedButton -= 1;
                if (startMenu.PressedButton < 1)
                    startMenu.PressedButton = 1;
            }
            else if (cki.Key.GetHashCode() == 40 || cki.Key.GetHashCode() == 34)//ArrowDown, PgDn
            {
                _requstedFeature = MenuID.StartMenu;
                //======||======||=======||======\\
                startMenu.PressedButton += 1;
                if (startMenu.PressedButton > 4)
                    startMenu.PressedButton = 4;
            }
            else if (cki.Key.GetHashCode() == 9)// TAB
            {
                _requstedFeature = MenuID.StartMenu;
                //======||======||=======||======\\
                startMenu.PressedButton -= 1;
                if (startMenu.PressedButton < 1 || startMenu.PressedButton > 3)
                    startMenu.PressedButton = 1;
            }
            //Pressed Buttons
            else if (cki.Key.GetHashCode() == 13 && startMenu.PressedButton == (int)StartMenu.Buttons.NewGame)
            {
                _requstedFeature = FeatureIDAccess[0];
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
            return running;
        }
        private void ClearMenuMemory()
        {
            if (Console.CursorVisible == true)
                Console.CursorVisible = false;

            Console.Clear();
            if (startMenu.MenuElements != null)
                startMenu.MenuElements.Clear();
        }
    }
}
