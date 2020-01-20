using System;
using System.Collections.Generic;
using System.Text;
using Golf.UI.Forms.Content;

namespace Golf.UI.Forms
{
    public class FormManager
    {
        public List<string> AccessAcctions { get; set; }
        public static List<string> FormActions { get; set; }
        public int ActiveForm { get; set; }
        private enum AppForms
        {
            FormCharacterCreation,
            FormScoreboard
        }
        private int FeatureRequest { get; set; }

        FormCharacterCreation FormCharacterCreation = new FormCharacterCreation();
        FormScoreboard formScoreboard = new FormScoreboard();
        public FormManager()
        {
            AccessAcctions = new List<string>();
            FormActions = new List<string>();
        }

        public void GetUserActions()
        {
            FormActions.Add(FormCharacterCreation.ID);
            FormActions.Add(formScoreboard.ID);
        }
        
        public Tuple<int, int> GetForm(int featureRequest)
        {
            if (ActiveForm == (int)AppForms.FormCharacterCreation)
            {
                FormCharacterCreation.Content();
                foreach (var item in FormCharacterCreation.getlabels)
                    FormCharacterCreation.Elements.Add(item);
            }
            if(ActiveForm == (int)AppForms.FormScoreboard)
            {

            }
            PrintFormContent();
            FormNaviagtion();
            var pogo = Tuple.Create(item1: featureRequest, item2: FeatureRequest);
            return pogo;
        }
        private void PrintFormContent()
        {
            Console.Clear();
            if(ActiveForm == (int)AppForms.FormCharacterCreation)
            {
                CenterOnScreen();
            }
            if(ActiveForm == (int)AppForms.FormScoreboard)
            {
                
            }

            void CustomPosition(int col, int row)
            {
                Console.SetCursorPosition(col, row);
            }

            void CenterOnScreen()
            {
                int col = Console.WindowHeight / Console.WindowHeight + 1;
                foreach (var item in FormCharacterCreation.Elements)
                {
                    Console.SetCursorPosition((Console.WindowWidth - item.Length) / 2, Console.WindowHeight / 2 - 6 + col++);
                    Console.Write(item + Environment.NewLine);
                }
            }
        }
        private void FormNaviagtion()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();

            if(ActiveForm == (int)AppForms.FormCharacterCreation)
            {
                if(cki.Key.GetHashCode() == 13)//Enter
                {
                    //To Do
                    // * Save player name to prop.
                    // * Request loading of toturial level,
                }
                if(cki.Key.GetHashCode() == 7)//Esc
                {
                    //To Do
                    // * Exit to previous menu.
                }
            }
            if(ActiveForm == (int)AppForms.FormScoreboard)
            {
                //To Do
                // * Form Key Actions.
            }
        }

        private void ClearFormElements()
        {
            if (Console.CursorVisible == true)
                Console.CursorVisible = false;

            if (FormCharacterCreation.Elements != null)
                FormCharacterCreation.Elements.Clear();
        }
    }
}
