using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.UI.Menus.Content
{
    public class StartMenu : Menu, IMenu
    {
        public enum Buttons
        {
            Play,
            Load,
            Scoreboard,
            Exit
        }

        public string[] GetMenuItems = new string[4];
        private string[] getMenuItems = new string[4];

        public StartMenu()
        {
            if(this.DefaultValuesSet == false)
                SetDefaultValues();
        }

        //Sets the default values of the StartMenu.
        //A default value manu never change value, or acts a first refference.
        private void SetDefaultValues()
        {
            if (string.IsNullOrEmpty(this.RoutingID))
                this.RoutingID = ("StartMenu");
            
            this.ActiveButton = (int)Buttons.Play;
            this.DefaultValuesSet = true;
        }

        private void Labels(int buttonID)
        {
            string[] unselectedMenuItems = new string[4];
            string[] selectedMenuItems = new string[4];
#region ArrayValueInizilazation
            unselectedMenuItems[0] = ("Play");
            unselectedMenuItems[1] = ("Load");
            unselectedMenuItems[2] = ("Scoreboard");
            unselectedMenuItems[3] = ("Exit");

            selectedMenuItems[0] = (">> Play <<");
            selectedMenuItems[1] = (">> Load <<");
            selectedMenuItems[2] = (">> Scoreboard <<");
            selectedMenuItems[3] = (">> Exit <<");
            #endregion

            if (this.ActiveButton == (int)Buttons.Play)
            {
                getMenuItems[0] = selectedMenuItems[0];
                getMenuItems[1] = unselectedMenuItems[1];
                getMenuItems[2] = unselectedMenuItems[2];
                getMenuItems[3] = unselectedMenuItems[3];
            }
            else if (this.ActiveButton == 1)
            {
                getMenuItems[1] = selectedMenuItems[1];
                getMenuItems[0] = unselectedMenuItems[0];
                getMenuItems[2] = unselectedMenuItems[2];
                getMenuItems[3] = unselectedMenuItems[3];
            }
            else if (this.ActiveButton == 2)
            {
                getMenuItems[2] = selectedMenuItems[2];
                getMenuItems[0] = unselectedMenuItems[0];
                getMenuItems[1] = unselectedMenuItems[1];
                getMenuItems[3] = unselectedMenuItems[3];
            }
            else if (this.ActiveButton == 3)
            {
                getMenuItems[3] = selectedMenuItems[3];
                getMenuItems[0] = unselectedMenuItems[0];
                getMenuItems[1] = unselectedMenuItems[1];
                getMenuItems[2] = unselectedMenuItems[2];
            }

            foreach (var label in getMenuItems);
                //this.Labels.Add(label.ToString());
        }

        public void Content(int menuButton)
        {
            string[] unselectedMenuItems = new string[4];
            string[] selectedMenuItems = new string[4];

            unselectedMenuItems[0] = ("Play");
            unselectedMenuItems[1] = ("Load");
            unselectedMenuItems[2] = ("Scoreboard");
            unselectedMenuItems[3] = ("Exit");

            selectedMenuItems[0] = (">> Play <<");
            selectedMenuItems[1] = (">> Load <<");
            selectedMenuItems[2] = (">> Scoreboard <<");
            selectedMenuItems[3] = (">> Exit <<");

            if (menuButton == 0)
            {
                GetMenuItems[0] = selectedMenuItems[0];
                GetMenuItems[1] = unselectedMenuItems[1];
                GetMenuItems[2] = unselectedMenuItems[2];
                GetMenuItems[3] = unselectedMenuItems[3];
            }
            else if (menuButton == 1)
            {
                GetMenuItems[1] = selectedMenuItems[1];
                GetMenuItems[0] = unselectedMenuItems[0];
                GetMenuItems[2] = unselectedMenuItems[2];
                GetMenuItems[3] = unselectedMenuItems[3];
            }
            else if (menuButton == 2)
            {
                GetMenuItems[2] = selectedMenuItems[2];
                GetMenuItems[0] = unselectedMenuItems[0];
                GetMenuItems[1] = unselectedMenuItems[1];
                GetMenuItems[3] = unselectedMenuItems[3];
            }
            else if (menuButton == 3)
            {
                GetMenuItems[3] = selectedMenuItems[3];
                GetMenuItems[0] = unselectedMenuItems[0];
                GetMenuItems[1] = unselectedMenuItems[1];
                GetMenuItems[2] = unselectedMenuItems[2];
            }
            

            
        }
    }
}
