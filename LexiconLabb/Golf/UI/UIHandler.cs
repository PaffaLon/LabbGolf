using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Golf.UI.Menus;
using Golf.UI.Forms;

namespace Golf.UI
{
    public class UIHandler
    {
        //Public Initialization
        private enum UIs
        {
            Menus,
            Forms,
            Levels
        }
        public static List<string> UIFeatuers { get; set; }
        public static List<string> AppFeatureAccess { get; set; }

        //Private Initialization
        private string _appFeatureRequsted;
        private string _appFeatureRequest;
        private bool _defaultValuesSet;
        private int _runUI;

        MenuHandler menuHandler = new MenuHandler();
        FormHandler formHandler = new FormHandler();
        public UIHandler()
        {
            if(UIFeatuers == null && AppFeatureAccess == null)
            {
                AppFeatureAccess = new List<string>();
                UIFeatuers = new List<string>();
                CreateUIFeatureSignatures();
            }

            if(_defaultValuesSet == false)
                SetDefaultValues();
        }
        //Constructor Helper Methods
#region CMM
        private void CreateUIFeatureSignatures()
        {
            foreach (var item in Enum.GetNames(typeof(UIs)))
                UIFeatuers.Add(item);
        }
        private void SetDefaultValues()
        {
            ReseiveAppFeatuers();
            SendAppFeatuers();
            DebugPrint();

            void ReseiveAppFeatuers()
            {
                foreach (var item in MenuHandler.MenuFeatuers)
                    AppFeatureAccess.Add(item);

                foreach (var item in FormHandler.FormFeatuers)
                    AppFeatureAccess.Add(item);
            }
            void SendAppFeatuers()
            {
                MenuHandler.AppFeatureAccess.Add(FormHandler.FormFeatuers[0]);
            }
            void DebugPrint()
            {
                Debug.Print(Environment.NewLine);
                foreach (var item in UIFeatuers)
                    Debug.Print($"UIFeatuers Items: {item}");

                Debug.Print(Environment.NewLine);
                foreach (var item in AppFeatureAccess)
                    Debug.Print($"AppFeatureAccess Items: {item}");
            }
            _runUI = (int)UIs.Menus;
            _defaultValuesSet = true;
        }
#endregion

        //Class Methods
        public void LoadUI(string appFeature)
        {
            if(appFeature == UIFeatuers[0])
                _runUI = (int)UIs.Menus;
            //=================================\\
            else if (appFeature == UIFeatuers[1])
                _runUI = (int)UIs.Forms;
            //=================================\\
            else if (appFeature == UIFeatuers[2])
                _runUI = (int)UIs.Levels;
            //=================================\\
            else
            {
                Debug.Print("||====================||" + Environment.NewLine
                            + "Error Code: unknown_app_feature" + Environment.NewLine
                            + $"appFeature: {appFeature}" + Environment.NewLine
                            + "Program location: UIHandler.LoadUI");
            }
            //=================================\\
            if (appFeature == AppFeatureAccess[2])
                _runUI = (int)UIs.Forms;
            //=================================\\
            else
            {
                Debug.Print("||====================||"          + Environment.NewLine
                            + "Error Code: unknown_app_feature" + Environment.NewLine
                            + $"appFeature: {appFeature}"       + Environment.NewLine
                            + "Program location: UIHandler.LoadUI");
            }
            
            _appFeatureRequsted = appFeature;
        }
        public Tuple<bool, string> GetUI(ref bool running)
        {
            if(_runUI == (int)UIs.Menus) 
            {
                menuHandler.LoadMenu(_appFeatureRequest);
                (running, _appFeatureRequsted) = menuHandler.GetMenu(ref running);
                Debug.Print("Program Location: UIHandler.GetUI" + Environment.NewLine
                            + "Values passed in:::" + Environment.NewLine
                            + $"running: {running}" + Environment.NewLine
                            + $"_appFeatureRequest: {_appFeatureRequest}");
            }
            else if (_runUI == (int)UIs.Forms) 
            {
                formHandler.LoadForm(_appFeatureRequest);
                formHandler.GetForm();
            }
            else if (_runUI == (int)UIs.Levels) 
            {

            }
            var
            return running;
        }
    }
}
