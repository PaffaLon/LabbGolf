using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.UI.Forms
{
    interface IForm
    {
        private void SetDefaultValues()
        {
        }
    }
    public class Form
    {
        public string ID { get; set; }
        public bool DefaultValuesSet { get; set; }

        public List<string> Elements { get; set;}
        public List<string> Labels   { get; set; }
        public int ActiveButton { get; set; }

        public Form()
        {
            Elements = new List<string>();
            Labels = new List<string>();
        }
    }
}