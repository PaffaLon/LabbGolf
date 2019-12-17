using System;
using System.Collections.Generic;
using System.Text;
using Golf.UI.Menus;

namespace Golf.Engine
{
    /// <summary>
    /// The AppRuntime class determents where the user are located in the application.
    /// Which segemts of code to run, stand alone or simultatnious.
    /// </summary>
    public class AppRuntime
    {

        private enum App{
            RunMenuManager,
            RunLevelManger,
            RunPlayerManager
        }
        private int CodeRun { get; set; }
        private bool Running { get; set; }

        MenuManager menuManager = new MenuManager();
        public AppRuntime()
        {
            Running = true;
            CodeRun = (int)App.RunMenuManager;
        }

        ~AppRuntime()
        {

        }

        public void RunTime()
        {
            while(Running == true)
            {
                menuManager.GetMenu();
            }
        }

        private void GetUserAppActivity()
        {

        }
    }
}
