using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.UI.Menus.Content
{
    public class Scoreboard
    {

        public string[] getMenuItems = new string[0];
        public void Content(int menuButton)
        {
            string[] unselectedMenuItems = new string[0];
            string[] selectedMenuItems = new string[0];

            unselectedMenuItems[0] = ("Exit");
            selectedMenuItems[0] = (">> Exit <<");

            if(menuButton == 0)
                getMenuItems[0] = unselectedMenuItems[0];

            if (menuButton == 1)
                getMenuItems[0] = selectedMenuItems[0];
        }
        public void GetScoreboard()
        {

        }
    }
}
