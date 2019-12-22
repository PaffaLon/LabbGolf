using System.Collections.Generic;

namespace Golf.UI.Menus
{
    public class Menu : IUI_Base
    {
        public List<string> Elements { get; set; }
        public int Button { get; set; }

        public Menu()
        {
            Elements = new List<string>();
        }
    }
}