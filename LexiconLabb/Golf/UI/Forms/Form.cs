using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.UI.Forms
{
    interface IFormComponents
    {
        
        void Content();
    }
    public class Form : IUI_Base
    {
        public List<string> Elements { get; set;}
        public int Button { get; set; }

        public Form()
        {
            Elements = new List<string>();
        }
    }
}