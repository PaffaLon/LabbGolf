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
    public static class Engine
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
        public static void Main()
        {
            //Object Initialization
            MenuHandler menuHandler = new MenuHandler();
            LevelHandler levelHandler = new LevelHandler();
            

            StartUp();
            while (_running == true)
            {
                if (RequestedAppFeatures[0].ToString() == MenuHandler.MenuID.StartMenu.ToString())
                {
                    menuHandler.LoadMenu(MenuHandler.MenuID.StartMenu);
                    menuHandler.GetMenu();
                }
                else if (RequestedAppFeatures[0].ToString() == LevelHandler.LevelID.Toturial.ToString())
                {
                    levelHandler.LoadLevel(LevelHandler.LevelID.Toturial);
                    levelHandler.GetLevel();
                }
                else
                {

                }
            }
            ShutDown();
        }
        
        
        /// <summary>
        /// Runs when the application is starting.
        /// </summary>
        private static void StartUp()
        {
            if (_defaultValuesSet == false)
                SetDefaultValues();
            //=================================\\
            if (AppFeatureRequests == null && RequestedAppFeatures == null)
                ListInitialization();
            //=================================\\
            void ListInitialization()
            {
                AppFeatureRequests = new List<Enum>();
                RequestedAppFeatures = new List<Enum>();
            }

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
                    AppFeatureRequests.Add(LevelHandler.LevelID.Toturial);
                }
                void SendAppFeatuers()
                {

                }

                //Sets the value of feilds.
                _running = true;
                _defaultValuesSet = true;
            }
        }

        
        /// <summary>
        /// Runs when the application is shutting down.
        /// </summary>
        private static void ShutDown()
        {

        }
    }
}
