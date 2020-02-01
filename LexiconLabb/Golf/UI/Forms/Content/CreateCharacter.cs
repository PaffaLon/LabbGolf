using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.UI.Forms.Content
{
    sealed class CreateCharacter : Form, IForm
    {
        
        public CreateCharacter()
        {
            if (this.DefaultValuesSet == false)
                SetDefaultValues();
        }
        //Constructor Helper Methods
        private void SetDefaultValues()
        {
            if (this.Lables == null)
                this.Lables = new string[1];
            this.Lables[0] = ("Enter playername: ");

            this.DefaultValuesSet = true;
        }
        //Class Methods
        public void LoadForm()
        {
            this.FormElements.Add(this.Lables[0]);
        }
        public void GetUsrIpt()
        {

        }
    }
}