using System;
using System.Collections.Generic;
using System.Text;


namespace Golf.UI.Forms.Content
{
    public class FormCharacterCreation : Form
    {
        public enum Buttons
        {
            Play,
            Exit
        }
        public string[] getlabels = new string[1];
        public void Labels()
        {
            string[] labels = new string[0];
            labels[0] = ("Player name: ");

            getlabels[0] = labels[0];
        }

        private void ButtonPlay()
        {
            string lable = ("Play");
            
        }

        private void Button()
        {

        }
    }
}
