using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Golf.UI.Menus.Content;
using Golf.Characters.Players;
using Golf.Engine;
using System.Diagnostics;

namespace Golf.UI.Menus
{
    public class MenuManager
    {
        MainMenu mainMenu = new MainMenu();
        CharacterCreationMenu characterCreationMenu = new CharacterCreationMenu();
        PlayerManager playerManager = new PlayerManager();

        public enum ApplicationMenus{
            StartMenu,
            LoadGame,
            ScoreBoardMenu,
            CharacterCreation
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
        public bool GetMenu(bool running)
        {
            ClearMenuElements();
            if(ActiveAppMenu == (int)ApplicationMenus.StartMenu)
            {
                mainMenu.Content(mainMenu.Button);
                foreach (var item in mainMenu.GetMenuItems)
                    mainMenu.Elements.Add(item);
            }
            if(ActiveAppMenu == (int)ApplicationMenus.CharacterCreation)
            {
                characterCreationMenu.Content();
                foreach (var item in characterCreationMenu.GetComponents)
                    characterCreationMenu.Elements.Add(item);
            }
            PrintMenuContent();
            running = MenuNavigation(running);

            var party = (AppMenu: ActiveAppMenu, BrakeRunTime: running);
            Debug.Print("GetMenu running: " + running.ToString());
            Debug.Print("-.-.-.-.-.-");
            return (party.AppMenu, party.BrakeRunTime);
            
            //return running; 
        }
        private void PrintMenuContent()
        {
            Console.Clear();
            if(ActiveAppMenu == (int)ApplicationMenus.StartMenu)
                CenterText();
            
            else if(ActiveAppMenu == (int)ApplicationMenus.LoadGame)
            {
                //To do
            }
            else if(ActiveAppMenu == (int)ApplicationMenus.ScoreBoardMenu)
            {
                //To do
            }
            else if(ActiveAppMenu == (int)ApplicationMenus.CharacterCreation)
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
        private bool MenuNavigation(bool running)
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
                    ActiveAppMenu = (int)ApplicationMenus.CharacterCreation;
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
            if(ActiveAppMenu == (int)ApplicationMenus.CharacterCreation)
            {
                if(cki.Key.GetHashCode() == 13)
                {
                    string _playerName;
                    //To Do:
                    //  * Set Cursor Position, to after displayMessage.
                    _playerName = characterCreationMenu.GetPlayerName();
                    //To Do:
                    Player player = new Player(_playerName);
                    playerManager.AddPlayer(player);
                    
                    //  * Close menu.
                    //  * Launch toturial level.
                }
            }
            //-END: of IF statments-\\
            Debug.Print("return running from NAV: " + running.ToString());
            return running;
        }
        private void CenterText()
        {
            int col = Console.WindowHeight / Console.WindowHeight + 1;
            switch (ActiveAppMenu)
            {
                case (int)ApplicationMenus.CharacterCreation:
                    foreach (var item in characterCreationMenu.Elements)
                    {
                        Console.SetCursorPosition((Console.WindowWidth - item.Length) / 2, Console.WindowHeight / 2 - 6 + col++);
                        Console.Write(item);
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
