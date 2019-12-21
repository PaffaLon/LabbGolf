using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Golf.UI.Menus;

namespace Golf.Engine
{
    /// <summary>
    /// The AppRuntime class determents where the user are located in the application.
    /// Which segemts of code to run, stand alone or simultatnious.
    /// </summary>
    public class AppEngine
    {

        private enum App {
            RunMenuManager,
            RunLevelManger,
            RunPlayerManager
        }
        private int CodeRun { get; set; }
        private bool Running { get; set; }
        private int AppMenu { get; set; }

        MenuManager menuManager = new MenuManager();
        public AppEngine()
        {
            Running = true;
            CodeRun = (int)App.RunMenuManager;
        }

        ~AppEngine()
        {

        }

        public void RunTime()
        {
            AppStarUp();
            //var pogo = (AppMenuT: AppMenu, BrakeRunTime: Running);
            while (Running == true)
            {
                //menuManager.GetMenu(Running);
                //Check where the user are in the program.
                switch (AppMenu)
                {
                    case (int)MenuManager.ApplicationMenus.CharacterCreation:
                        break;
                    case (int)MenuManager.ApplicationMenus.LoadGame:
                        break;
                    case (int)MenuManager.ApplicationMenus.ScoreBoardMenu:
                        break;

                    //(int)MenuManager.ApplicationMenus.StartMenu;
                    default:
                            (AppMenu, Running) = menuManager.GetMenu(Running);
                        break;
                }
            }
            AppShutDown();
        }

        //Ses the default values of the applications refferences.
        //Runs filepath tests.
        private void AppStarUp()
        {
            AppMenu = (int)MenuManager.ApplicationMenus.StartMenu;
        }

        public void RunAppMenu()
        {
        }
        public void RunLevel()
        {

        }

        private void GetUserAppActivity()
        {

        }

        //Shuts Down Appllication.
        private static void AppShutDown()
        {
            Environment.Exit(0);
        }
    }
}