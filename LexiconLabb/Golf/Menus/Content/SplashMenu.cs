using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.Menus.Content
{
    class SplashMenu : Menu
    {
        public enum Buttons
        {
            Play,
            Load,
            Scoreboard,
            Exit
        }
        public string[] GetMenuItems = new string[4];

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
            if(menuButton == 0)
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
