using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.UI.Forms
{
    public class Form
    {
        public List<string> Elements { get; set;}
        public int Button { get; set; }

        public Form()
        {
            Elements = new List<string>();
        }
    }
}