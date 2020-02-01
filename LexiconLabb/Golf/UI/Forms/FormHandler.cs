using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Golf.UI.Forms.Content;

namespace Golf.UI.Forms
{
    public class FormHandler
    {
        //Public Initialization
        public static List<string> AppFeatureAccess { get; set; }
        public static List<string> FormFeatuers     { get; set; }
        // Private Initialization
        private enum AppForms
        {
            CharacterCreation
        }
        private string _appFeatureRequest;
        private bool _defaultValuesSet;
        private int _runAppForm;

        CreateCharacter createCharacter = new CreateCharacter();
        public FormHandler()
        {
            if(FormFeatuers == null && AppFeatureAccess == null)
            {
                AppFeatureAccess = new List<string>(); 
                FormFeatuers = new List<string>();
            }
            if (_defaultValuesSet == false)
            {
                CreateFormFeatureSignatuers();
                SetDefaultValues();
            }
        }
        //Constructor Helper Methods
#region CHH
        private void CreateFormFeatureSignatuers()
        {
            foreach (var item in Enum.GetNames(typeof(AppForms)))
                FormFeatuers.Add(item);
        }
#endregion
        private void SetDefaultValues()
        {
            _defaultValuesSet = true;
        }
        //Class Methods
        public void LoadForm(string appFeature)
        {
            if (appFeature == FormFeatuers[0])
                _runAppForm = (int)AppForms.CharacterCreation;
            //=================================\\
            else
            {
                Debug.Print("||====================||"          + Environment.NewLine
                            + "Error Code: unknown_app_feature" + Environment.NewLine 
                            + $"appFeature: {appFeature}"       + Environment.NewLine
                            + "Program location: FormHandler.LoadForm");
            }
        }
        public void GetForm()
        {
            ClearFormElements();
            if(_runAppForm == (int)AppForms.CharacterCreation)
            {
                PrintForm();
                FormNavigation();
            }
        }

        private void PrintForm()
        {
            if (_runAppForm == (int)AppForms.CharacterCreation)
            {
                int col = 1;
                foreach (var item in createCharacter.FormElements)
                {
                    Console.SetCursorPosition(((Console.WindowWidth - item.Length) / 2), Console.WindowHeight / 2 + col++);
                    Console.Write(item + Environment.NewLine);
                }
            }
        }
        private void FormNavigation()
        {

        }
        private void ClearFormElements()
        {
            Console.Clear();
            if (Console.CursorVisible == true)
                Console.CursorVisible = false;
        }
    }
}
