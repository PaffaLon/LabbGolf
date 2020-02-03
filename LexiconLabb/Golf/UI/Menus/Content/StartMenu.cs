using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Golf.UI.Menus.Content
{
    sealed class StartMenu : Menu, IMenu
    {
        public enum Buttons
        {
            NewGame     = 1,
            LoadGame    = 2,
            ScoreBoard  = 3,
            Exit        = 4
        }
        public StartMenu()
        {
            if (this.DefaultValuesSet == false)
                SetDefaultValues();
        }
        private void SetDefaultValues()
        {
            if (this.MenuElements == null)
                this.MenuElements = new List<string>();

            if(this.SelectedMenuItems == null && this.UnselectedMenuItems == null)
            {
                this.UnselectedMenuItems = new string[4];
                this.SelectedMenuItems = new string[4];
#region ArrayValueInitialization
                this.UnselectedMenuItems[0] = ("New Game ");
                this.UnselectedMenuItems[1] = ("Load Game");
                this.UnselectedMenuItems[2] = ("Scoreboard");
                this.UnselectedMenuItems[3] = ("Exit");

                this.SelectedMenuItems[0] = (">>  New Game    <<");
                this.SelectedMenuItems[1] = (">>  Load Game   <<");
                this.SelectedMenuItems[2] = (">>  Scoreboard  <<");
                this.SelectedMenuItems[3] = (">> Exit <<");
#endregion
            }

            this.PressedButton = (int)Buttons.NewGame;
            this.DefaultValuesSet = true;
        }
 

        public void LoadMenu(int button)
        {
            if (button == (int)Buttons.NewGame)
            {
                this.MenuElements.Add(new string(this.SelectedMenuItems[0]));
                this.MenuElements.Add(new string(this.UnselectedMenuItems[1]));
                this.MenuElements.Add(UnselectedMenuItems[2]);
                this.MenuElements.Add(UnselectedMenuItems[3]);
            }
            else if(button == (int)Buttons.LoadGame)
            {
                this.MenuElements.Add(this.UnselectedMenuItems[0]);
                this.MenuElements.Add(this.SelectedMenuItems[1]);
                this.MenuElements.Add(this.UnselectedMenuItems[2]);
                this.MenuElements.Add(this.UnselectedMenuItems[3]);
            }
            else if(button == (int)Buttons.ScoreBoard)
            {
                this.MenuElements.Add(this.UnselectedMenuItems[0]);
                this.MenuElements.Add(this.UnselectedMenuItems[1]);
                this.MenuElements.Add(this.SelectedMenuItems[2]);
                this.MenuElements.Add(this.UnselectedMenuItems[3]);
            }
            else if (button == (int)Buttons.Exit)
            {
                this.MenuElements.Add(this.UnselectedMenuItems[0]);
                this.MenuElements.Add(this.UnselectedMenuItems[1]);
                this.MenuElements.Add(this.UnselectedMenuItems[2]);
                this.MenuElements.Add(this.SelectedMenuItems[3]);
            }
        }

        private void DebugPrint()
        {
            foreach (var item in this.UnselectedMenuItems)
            {
                Debug.Print($"StartMenu || this.UnselectedMenuItems: {item}");
            }
            foreach (var item in this.SelectedMenuItems)
            {
                Debug.Print($"StartMenu || this.SelectedMenuItems: {item}");
            }

            foreach (var item in this.MenuElements)
            {
                Debug.Print($"StartMenu || this.MenuElements: {item}");
            }
        }
    }
}
