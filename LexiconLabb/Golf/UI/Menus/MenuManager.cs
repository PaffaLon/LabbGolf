﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Golf.UI.Menus.Content;

namespace Golf.UI.Menus
{
    public class MenuManager
    {
        MainMenu mainMenu = new MainMenu();
        CharacterCreationMenu characterCreationMenu = new CharacterCreationMenu();

        private enum ApplicationMenus{
            SplashMenu,
            LoadGame,
            ScoreBoardMenu,
            CharacterCreation
        }
        private int ActiveApplicationMenu { get; set; }
        public MenuManager()
        {
            ActiveApplicationMenu = (int)ApplicationMenus.SplashMenu;
            mainMenu.Button = (int)MainMenu.Buttons.Play;
        }

        /// <summary>
        /// Requests the needed menu infomation from the respective menu componnent.
        /// </summary>
        public void GetMenu()
        {
            ClearMenuElements();
            if(ActiveApplicationMenu == (int)ApplicationMenus.SplashMenu)
            {
                mainMenu.Content(mainMenu.Button);
                foreach (var item in mainMenu.GetMenuItems)
                    mainMenu.Elements.Add(item);
            }
            if(ActiveApplicationMenu == (int)ApplicationMenus.CharacterCreation)
            {
                characterCreationMenu.Content();
                foreach (var item in characterCreationMenu.GetComponents)
                    characterCreationMenu.Elements.Add(item);
            }
            PrintMenuContent();
            MenuNavigation();
        }
        private void PrintMenuContent()
        {
            Console.Clear();
            if(ActiveApplicationMenu == (int)ApplicationMenus.SplashMenu)

                CenterText();
            
            else if(ActiveApplicationMenu == (int)ApplicationMenus.LoadGame)
            {
                //To do
            }
            else if(ActiveApplicationMenu == (int)ApplicationMenus.ScoreBoardMenu)
            {
                //To do
            }
            else if(ActiveApplicationMenu == (int)ApplicationMenus.CharacterCreation)
            {
                CenterText();
            }
        }
        /// <summary>
        /// Make it possible for the user to interact and navigate with the applications menues.
        /// Pressing a arrow key results in one behavior.
        /// Pressing the enter key results in one behavior.
        /// This allows the user to reach a deeper level in the application in a logical manner.
        /// </summary>
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
                    ActiveApplicationMenu = (int)ApplicationMenus.CharacterCreation;
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
            if(ActiveApplicationMenu == (int)ApplicationMenus.CharacterCreation)
            {
                if(cki.Key.GetHashCode() == 13)
                {
                    string _playerName;
                    //To Do:
                    //  * Set Cursor Position, to after displayMessage.
                    _playerName = characterCreationMenu.GetPlayerName();
                    //To Do:
                    //  * Call the proper class & metod to create a new player object,
                    //      for storing the new player name.
                    //  * Close menu.
                    //  * Launch toturial level.
                }
            }
            GetMenu();
        }
        private void CenterText()
        {
            int col = Console.WindowHeight / Console.WindowHeight + 1;
            switch (ActiveApplicationMenu)
            {
                case (int)ApplicationMenus.CharacterCreation:
                    foreach (var item in characterCreationMenu.Elements)
                    {
                        Console.SetCursorPosition((Console.WindowWidth - item.Length) / 2, Console.WindowHeight / 2 - 6 + col++);
                        Console.Write(item + Environment.NewLine);
                    }
                    break;
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

            if (characterCreationMenu.Elements != null)
                characterCreationMenu.Elements.Clear();
        }
    }
}