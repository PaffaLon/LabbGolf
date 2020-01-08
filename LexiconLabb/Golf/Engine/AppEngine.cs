using System;
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
    public class AppEngine
    {
        public enum Sequence
        {
            RunMenuManager,
            RunPlayerManager,
            RunLevelManger,
            RunCharacterCreator
        }
        private bool Running { get; set; }
        private int RunLayer { get; set; }//Thinking about replacing the property with an object as request refference.
        private int FeatureResive { get; set; }

        static private List<string> AppEnumItems { get; set; }
        static private List<object> ObjAppFeatuers { get; set; }
        private string AppFeature { get; set; }
        private object Feature { get; set; }

        MenuManager menuManager = new MenuManager();
        FormManager formManager = new FormManager();
        public AppEngine()
        {
            ObjAppFeatuers = new List<object>();
            AppEnumItems = new List<string>();

            Running = true;
        }

        ~AppEngine()
        {

        }

        //Ses the default values of the applications refferences.
        //Runs filepath tests.
        private void AppStarUp()
        {
            ObjectApreach();
            EnumItemAppreach();
            void ObjectApreach()
            {
                Debug.Print("Enterd: ObjectApreach.");
                ObjAppFeatuers.AddRange(menuManager.GetMenuObjects(ObjAppFeatuers));
                ObjAppFeatuers.AddRange(formManager.GetFormObjects(ObjAppFeatuers));
                Debug.Print("Objects in list: " + ObjAppFeatuers.Count.ToString());


                ObjAppFeatuers.ForEach(el => Debug.Print("objects: " + el.ToString()));

                foreach (var item in ObjAppFeatuers)
                {
                    Debug.Print(item.ToString());
                }

            }
        }
        void EnumItemAppreach()
        {
            AppEnumItems.AddRange(menuManager.GetEnumItemNames(AppEnumItems));
            AppEnumItems.ForEach(el => Debug.Print("Enums: " + el));


            RunLayer = (int)Sequence.RunMenuManager;
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