using System;
using System.Collections.Generic;
using System.Text;

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

        public FormManager()
        {

        }

        public int GetForm(int featureRequest)
        {
            if (ActiveForm == (int)Forms.FormCharacterCreation)
            {

            }
            if(ActiveForm == (int)Forms.FormScoreboard)
            {

            }
            ActionRequest = featureRequest;
            return ActionRequest;
        }
    }
}
