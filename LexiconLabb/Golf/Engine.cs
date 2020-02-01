using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Golf.UI;

namespace Golf
{
    public static class Engine
    {
        private enum RunAppLayer
        {
            RunEntity,
            RunUI
        }
        
        private static string AppFeatureRequest    { get; set; }
        private static string AppfeatureRequsted   { get; set; }
        
        private static List<string> AppFeatuers { get; set; }
        private static bool _running;
        private static int _runAppLayer;
        private static bool _defualtValuesSet;

        static Engine()
        {
            
        }
        //Constructor Helpers
        private static void StartUp()
        {
            if(AppFeatuers == null)
            {
                AppFeatuers = new List<string>();
            }
            
            if (AppFeatuers.Count < 1)
                ReseiveAppFeatuers();
            if (AppFeatuers.Count >= 1)
                SendAppFeatuers();
            if (_defualtValuesSet == false)
                SetDefaultValues();

            DebugPrint();
            void ReseiveAppFeatuers()
            {
                foreach (var item in UIHandler.UIFeatuers)
                    AppFeatuers.Add(item);

                
            }
            void SendAppFeatuers()
            {
                
            }
            void SetDefaultValues()
            {
                AppFeatureRequest = AppFeatuers[0];
                _runAppLayer = (int)RunAppLayer.RunUI;
                _running = true;
                _defualtValuesSet = true;
            }
            void DebugPrint()
            {
                foreach (var item in UIHandler.UIFeatuers)
                    Debug.Print(Environment.NewLine + $"AppFeatuers Items: {item}");
            }
        }

        //Class Methods
        static void Main()
        {
            UIHandler uIHandler = new UIHandler();
            if (_defualtValuesSet == false)
                StartUp();
            //=================================\\
            if(AppFeatureRequest == AppFeatuers[0])
            {
                AppfeatureRequsted = AppFeatureRequest;
                _runAppLayer = (int)RunAppLayer.RunUI;
            }
            //=================================\\
            else if (AppFeatureRequest == AppFeatuers[1])
            {
                AppfeatureRequsted = AppFeatureRequest;
                _runAppLayer = (int)RunAppLayer.RunEntity;
            }
            //=================================\\
            else
            {
                Debug.Print("||====================||"              + Environment.NewLine
                        + "Error Code: unknown_app_feature"         + Environment.NewLine
                        + $"AppFeatureRequest: {AppFeatureRequest}" + Environment.NewLine
                        + "Program location: Engine.Main");
            }
            //=================================\\
            while (_running == true)
            {
                switch (_runAppLayer)
                {
                    case (int)RunAppLayer.RunUI:
                        Debug.Print($"AppFeatureRequest: {AppFeatureRequest}");
                        uIHandler.LoadUI(AppFeatureRequest);
                        _running = uIHandler.GetUI(ref _running);
                        break;
                    case (int)RunAppLayer.RunEntity:
                        break;
                    default:
                        Debug.Print($"Unexpected value. _runAppLayer: {_runAppLayer}");
                        break;
                }
            }
            Environment.Exit(0);
        }
    }
}
