using System.Collections.Generic;

namespace Golf.UI.Menus
{
    interface IMenu
    {
        void Content(int button);
        enum Buttons { };
    }
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