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
        public enum MenuID
        {
            StartMenu
        }
        #endregion
        //Private Initialization
#region
        private bool _defaultValuesSet;
        private int _runAppMenu;
#endregion
        //Object Initialization
        StartMenu startMenu = new StartMenu();
        public MenuHandler()
        {
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
        public void LoadMenu(MenuID menuID)
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
        public void GetMenu()
        {
            ClearMenuMemory();
            if(_runAppMenu == (int)MenuID.StartMenu)
            {
                startMenu.LoadMenu(startMenu.PressedButton);
            }   
            PrintMenu();
            Menunavigation();
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
        private void Menunavigation()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();
            //Navigate UP or DOWN
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
                if (startMenu.PressedButton < 1 || startMenu.PressedButton > 3) startMenu.PressedButton = 1;
            }
            //Pressed Buttons
            else if (cki.Key.GetHashCode() == 13 && startMenu.PressedButton == (int)StartMenu.Buttons.NewGame)
            {
                Console.Clear();
                Console.WriteLine("The New Game feature have not been implemented.");
                Thread.Sleep(1000);
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
                Environment.Exit(0);
            }
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
