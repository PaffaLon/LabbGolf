using System.Collections.Generic;

namespace Golf.UI.Menus
{
    interface IMenu
    {
        
    }
    public class Menu
    {
        public string Name { get; set; }
        public object Object { get; set; }
        
        public List<string> Elements { get; set; }
        public int Button { get; set; }

        public Menu()
        {
            Elements = new List<string>();
        }
    }
}