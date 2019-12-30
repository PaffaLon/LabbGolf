using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Golf.UI.Menus;
using Golf.UI.Forms;

namespace Golf.Engine
{
    /// <summary>
    /// The AppRuntime class determents where the user are located in the application.
    /// Which segemts of code to run, stand alone or simultatnious.
    /// </summary>
    public class AppEngine
    {
        public enum Sequence {
            RunMenuManager,
            RunPlayerManager,
            RunLevelManger,
            RunCharacterCreator
        }
        private bool Running { get; set; }
        private int FeatureRequst { get; set; }//Thinking about replacing the property with an object as request refference.
        private int FeatureResive { get; set; }

        MenuManager menuManager = new MenuManager();
        FormManager formManager = new FormManager();
        public AppEngine()
        {
            Running = true;
        }

        ~AppEngine()
        {

        }

        //Ses the default values of the applications refferences.
        //Runs filepath tests.
        private void AppStarUp()
        {
            FeatureRequst = (int)Sequence.RunMenuManager;
        }

        public void RunTime()
        {
            AppStarUp();
            while (Running == true)
            {
                //Check where the user are in the program.
                switch (FeatureRequst)
                {
                    case (int)Sequence.RunLevelManger:
                        break;
                    case (int)Sequence.RunPlayerManager:
                        break;
                    case (int)Sequence.RunCharacterCreator:
                            (FeatureRequst, FeatureResive) = formManager.GetForm(FeatureRequst);
                        break;
                    default:
                            (FeatureRequst, Running) = menuManager.GetMenu(Running);
                        break;
                }
                UpdateRequest(FeatureRequst, FeatureResive);
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