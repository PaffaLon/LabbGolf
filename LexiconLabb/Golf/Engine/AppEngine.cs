using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Golf.UI.Menus;
using Golf.UI.Forms;
using System.Diagnostics;

namespace Golf.Engine
{
    /// <summary>
    /// The AppRuntime class determents where the user are located in the application.
    /// Which segemts of code to run, stand alone or simultatnious.
    /// </summary>
    interface IUserActionProtocol
    {
        public object ActionRequest { get; set; }
        public object ActionSend { get; set; }
        
    } 

    public class AppEngine : IUserActionProtocol
    {
        public object ActionRequest { get; set; }
        public object ActionSend { get; set; }
        public enum Sequence
        {
            RunMenuManager,
            RunPlayerManager,
            RunLevelManger,
            RunCharacterCreator
        }

        private static List<string> UserActions
        {
            get;
            set;
        }
        private bool Running { get; set; }
        private int RunLayer { get; set; }//Thinking about replacing the property with an object as request refference.
        private int FeatureResive { get; set; }

        MenuManager menuManager = new MenuManager();
        FormManager formManager = new FormManager();
        public AppEngine()
        {
            UserActions = new List<string>();
            Running = true;
        }

        //Ses the default values of the applications refferences.
        //Runs filepath tests.
        private void AppStarUp()
        {
            UserActions.Add(menuManager.GetUserActions());
            formManager.GetUserActions();
            
            
        }

        public void RunTime()
        {
            AppStarUp();
            while (Running == true)
            {
                //Check where the user are in the program.
                switch (RunLayer)
                {
                    case (int)Sequence.RunLevelManger:
                        break;
                    case (int)Sequence.RunPlayerManager:
                        break;
                    case (int)Sequence.RunCharacterCreator:
                        (RunLayer, FeatureResive) = formManager.GetForm(RunLayer);
                        break;
                    default:
                        //Sending: MenuType, FormType, Running
                        //Reseving: MenuType, FormType
                        (RunLayer, Running) = menuManager.GetMenu(Running);
                        break;
                }
                UpdateRequest(RunLayer, FeatureResive);
            }
            AppShutDown();
        }

        private Tuple<int, int> UpdateRequest(int featureRequest, int FeatureResive)
        {
            featureRequest = FeatureResive;
            var tuple = Tuple.Create(item1: featureRequest, item2: FeatureResive);
            return tuple;
        }

        //Shuts Down Appllication.
        private static void AppShutDown()
        {
            Environment.Exit(0);
        }
    }
} 