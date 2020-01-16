using System;
using System.Collections.Generic;
using System.Text;
using Golf.UI.Forms.Content;

namespace Golf.UI.Forms
{
    public class FormManager
    {
        private enum AppForms
        {
            FormCharacterCreation,
            FormScoreboard
        }
        static public List<string> GetAppForms { get; set; }
        static public List<object> ObjGetAppForms { get; set; }
        static public List<object> AccessToObjects { get; set; }
        
        public int ActiveForm { get; set; }
        private int FeatureSend { get; set; }

        FormCharacterCreation FormCharacterCreation = new FormCharacterCreation();
        FormScoreboard formScoreboard = new FormScoreboard();
        public FormManager()
        {
            ObjGetAppForms = new List<object>();
        }

        public List<object> GetFormObjects(List<object> list)
        {
            if (ObjGetAppForms.Count == 0)
            {
                ObjGetAppForms = new List<object>();
                ObjGetAppForms.Add(FormCharacterCreation);
                ObjGetAppForms.Add(formScoreboard);
            }
            else if(ObjGetAppForms.Count > 0)
            {
                AccessToObjects = list;
            }

            return ObjGetAppForms;
        }

        public List<string> GetFormEnumItems(List<object> list)
        {
            if (GetAppForms == null)
            {
                GetAppForms = new List<string>();
                foreach (var item in Enum.GetValues(typeof(AppForms)))
                {
                    GetAppForms.Add(Convert.ToString(item));
                }
            }
            return GetAppForms;
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
            var pogo = Tuple.Create(item1: featureRequest, item2: FeatureSend);
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
