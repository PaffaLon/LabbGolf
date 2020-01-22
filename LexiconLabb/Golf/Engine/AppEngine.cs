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
        private enum Sequence
        {
            RunMenuManager,
            RunFormManager,
            RunPlayerManager,
            RunLevelManger,
        }

        private object[] TypeX = new object[4];

        private static List<string> RoutingProtocolIDs
        {
            get;
            set;
        }
        private static string RequestedProtocol { get; set; }
        private static string ActiveProtocol { get; set; }
        private bool Running { get; set; }
        private int RunLayer { get; set; }//Thinking about replacing the property with an object as request refference.
        private int FeatureResive { get; set; }

        MenuManager menuManager = new MenuManager();
        FormManager formManager = new FormManager();
        public AppEngine()
        {
            RoutingProtocolIDs = new List<string>();
            Running = true;
        }

        //Ses the default values of the applications refferences.
        //Runs filepath tests.
        public void AppStarUp()
        {
            void RequestRoutingIDs()
            {
                RoutingProtocolIDs.AddRange(menuManager.GetRoutingID());
                RoutingProtocolIDs.AddRange(formManager.GetRoutingID());
            }
            void ShareRoutingIDs()
            {
                menuManager.ResiveRoutingID(RoutingProtocolIDs[2]);
                menuManager.ResiveRoutingID(RoutingProtocolIDs[3]);
                formManager.ResiveRoutingID(RoutingProtocolIDs[0]);
            }
            void SetDefaultRoutingID()
            {
                RequestedProtocol = RoutingProtocolIDs[0];
            }

            if (RoutingProtocolIDs == null)
            {
                RequestRoutingIDs();
                ShareRoutingIDs();
                SetDefaultRoutingID();
            }

            foreach (var item in RoutingProtocolIDs)
                Debug.Print("UserActions: " + item);
        }

        public void RunTime()
        {
            AppStarUp();
            while (Running == true)
            {
                if(RequestedProtocol == RoutingProtocolIDs[0] || RequestedProtocol == RoutingProtocolIDs[1])
                    RunLayer = (int)Sequence.RunMenuManager;
                
                else if (RequestedProtocol == RoutingProtocolIDs[0] || RequestedProtocol == RoutingProtocolIDs[1])
                {
                    RunLayer = (int)Sequence.RunFormManager;
                }
                else
                {
                    Debug.Print("Error"
                    + Environment.NewLine
                    + "Error Code: Protocol-ID-Error"
                    + Environment.NewLine
                    + "Resived Protocol-ID: "
                    + RequestedProtocol);
                }

                

                //Check where the user are in the program.
                switch (RunLayer)
                {
                    case (int)Sequence.RunMenuManager:
                        //Sending: MenuType, FormType, Running
                        //Reseving: MenuType, FormType
                        (ActiveProtocol, Running) = menuManager.GetMenu(Running);
                        break;
                    case (int)Sequence.RunLevelManger:
                        break;
                    case (int)Sequence.RunPlayerManager:
                        break;
                    default:
                        Debug.Print("Error"
                                    + Environment.NewLine 
                                    + "Error Code: Incorect value."
                                    + Environment.NewLine
                                    + "RunLayer: "
                                    + RunLayer);
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