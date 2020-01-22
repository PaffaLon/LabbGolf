using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.UI.Menus.Content
{
    public class LevelBrowser : Menu
    {
        public enum Buttons
        {
            Exit
        }

        public LevelBrowser()
        {
            if (this.DefaultValuesSet == false)
                SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            if (string.IsNullOrEmpty(this.RoutingID))
                this.RoutingID = ("LevelBrowser");

            this.ActiveButton = (int)Buttons.Exit;
            this.DefaultValuesSet = true;
        }

        public void Content()
        {
            //GetLevelNames
            string[] levelNames = new string[2];
            levelNames[0] = ("Totuerial");
            levelNames[1] = ("");
            levelNames[2] = ("");
        }
    }
}
