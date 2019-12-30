using System;
using System.Collections.Generic;
using System.Text;
using Golf.UI.Forms.Content;

namespace Golf.UI.Forms
{
    public class FormManager
    {
        public enum Forms
        {
            FormCharacterCreation,
            FormScoreboard
        }

        public int ActiveForm { get; set; }
        private int ActionRequest { get; set; }
        private int NewSequence { get; set; }
        private int FeatureSend { get; set; }

        FormCharacterCreation FormCharacterCreation = new FormCharacterCreation();
        FormScoreboard formScoreboard = new FormScoreboard();
        public FormManager()
        {

        }

        public Tuple<int, int> GetForm(int featureRequest)
        {
            if (ActiveForm == (int)Forms.FormCharacterCreation)
            {
                FormCharacterCreation.Labels();
                foreach (var item in FormCharacterCreation.getlabels)
                    FormCharacterCreation.Elements.Add(item);
            }
            if(ActiveForm == (int)Forms.FormScoreboard)
            {

            }
            PrintFormContent();
            FormNaviagtion();
            var pogo = Tuple.Create(item1: featureRequest, item2: FeatureSend);
            return pogo;
        }
        private void PrintFormContent()
        {
            Console.Clear();
            if(ActiveForm == (int)Forms.FormCharacterCreation)
            {
                CenterOnScreen();
            }
            if(ActiveForm == (int)Forms.FormScoreboard)
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

            if(ActiveForm == (int)Forms.FormCharacterCreation)
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
            if(ActiveForm == (int)Forms.FormScoreboard)
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
