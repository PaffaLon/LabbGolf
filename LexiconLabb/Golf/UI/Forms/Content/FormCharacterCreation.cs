using System;
using System.Collections.Generic;
using System.Text;


namespace Golf.UI.Forms.Content
{
    public class FormCharacterCreation : Form, IForm
    {
        public enum Buttons
        {
            Play,
            Exit
        }
        public string[] getlabels = new string[1];

        public FormCharacterCreation()
        {
            if (this.DefaultValuesSet == false)
                SetDefaultValues();
        }
        private void SetDefaultValues()
        {
            if (string.IsNullOrEmpty(this.RoutingID))
                this.RoutingID = ("Form-CharacterCreation");

            this.ActiveButton = (int)Buttons.Play;
            this.DefaultValuesSet = true;
        }

        public void Content()
        {
            string[] labels = new string[0];
            labels[0] = ("Player name: ");

            getlabels[0] = labels[0];
        }
    }
}
