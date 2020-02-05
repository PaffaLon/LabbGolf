using System;
using System.Collections.Generic;
using System.Text;
using GolfSimplyfied.UI.Menus;
using GolfSimplyfied.UI.Levels;
using GolfSimplyfied.Entities.Characters.Players;
using GolfSimplyfied.Entities.Items;
using GolfSimplyfied.Logic;

namespace GolfSimplyfied
{
    internal static class Engine
    {
        //Public Static Initialization
#region
        /// <summary>
        /// Outgoing requests.
        /// </summary>
        public static List<Enum> AppFeatureRequests { get; set; }
        
        /// <summary>
        /// Incoming requests.
        /// </summary>
        public static List<Enum>  RequestedAppFeatures { get; set; }
#endregion

        //Private Static Initialization
        private static bool _running;
        private static bool _defaultValuesSet;
        static void Main()
        {
            //Object Initialization
            MenuHandler menuHandler = new MenuHandler();
            LevelHandler levelHandler = new LevelHandler();
            

            StartUp();
            while (_running == true)
            {
                if (RequestedAppFeatures[0].ToString() == MenuHandler.MenuID.StartMenu.ToString())
                {
                    menuHandler.LoadMenu(AppFeatureRequests[0]);
                    (_running, RequestedAppFeatures[0]) = menuHandler.GetMenu(ref _running);
                }
                else if (RequestedAppFeatures[0].ToString() == LevelHandler.LevelID.Toturial.ToString())
                {
                    levelHandler.LoadLevel(AppFeatureRequests[0]);
                    levelHandler.GetLevel();
                }
                else
                {
                    
                }
            }
            ShutDown();
            Environment.Exit(0);
        }
        
        
        /// <summary>
        /// Runs when the application is starting.
        /// </summary>
        private static void StartUp()
        {
            if (AppFeatureRequests == null && RequestedAppFeatures == null)
                ListInitialization();
            //=================================\\
            void ListInitialization()
            {
                AppFeatureRequests = new List<Enum>();
                RequestedAppFeatures = new List<Enum>();
            }

            if (_defaultValuesSet == false)
                SetDefaultValues();
            //=================================\\
            //Last Internal Method To Run.
            void SetDefaultValues()
            {
                if (AppFeatureRequests.Count < 1)
                    ResivedAppFeatuers();
                //===========================\\
                if (RequestedAppFeatures.Count > 0)
                    SendAppFeatuers();

                void ResivedAppFeatuers()
                {
                    AppFeatureRequests.Add(MenuHandler.MenuID.StartMenu);
                }
                void SendAppFeatuers()
                {
                    LevelHandler.FeatureIDAccess.Add(MenuHandler.MenuID.StartMenu);
                    MenuHandler.FeatureIDAccess.Add(LevelHandler.LevelID.Toturial);
                }

                //Sets the value of feilds & properties.
                RequestedAppFeatures.Add(MenuHandler.MenuID.StartMenu);
                _running = true;
                _defaultValuesSet = true;
            }
        }

        
        /// <summary>
        /// Runs when the application is shutting down.
        /// Handels application information before temprary values are lost.
        /// </summary>
        private static void ShutDown()
        {

        }
    }
}
