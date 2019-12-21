using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.UI.Menus
{
    public class Menu
    {
        public List<string> Elements { get; set; }
        public int Button { get; set; }

        public Menu()
        {
            Elements = new List<string>();
        }
    }
}