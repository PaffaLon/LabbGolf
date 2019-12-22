using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.UI.Forms.Content
{
    public class FormCharacterCreation : Form
    {
        public enum Buttons
        {
            Save,
            Exit
        }
        public string[] getlabels = new string[0];
        public void Content()
        {
            string[] labels = new string[0];
            labels[0] = ("Player name: ");
        }
    }
}
