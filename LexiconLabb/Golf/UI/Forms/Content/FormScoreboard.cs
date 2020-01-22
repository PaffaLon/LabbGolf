using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.UI.Forms.Content
{
    public class FormScoreboard : Form, IForm
    {
        public FormScoreboard()
        {
            if (this.DefaultValuesSet == false)
                SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            if (string.IsNullOrEmpty(this.RoutingID))
                this.RoutingID = ("Form-Scoreboard");

            this.DefaultValuesSet = true;
        }
        
        public void GetScoreboard()
        {

        }
    }
}
