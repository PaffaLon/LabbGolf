using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.UI.Forms
{
    interface IForm
    {
        public void LoadForm();
        public enum Buttons { }
    }
    abstract class Form
    {
        //Public Initialization
        public List<string> FormElements { get; set; }
        public int PressedButton { get; set; }


        // Protected Initialization
        #region ProtectedProps
        protected string[] Lables { get; set; }
        protected bool DefaultValuesSet { get; set; }
        #endregion
    }
}
