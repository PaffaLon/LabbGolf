using System.Collections.Generic;

namespace Golf.UI.Menus
{
    interface IMenu
    {
        public enum Buttons { }
        private void SetDefaultValues() { }
    }
    public class Menu
    {
        public string RoutingID { get; set; }
        
        public List<string> Elements { get; set; }
        public List<string> Labels { get; set; }
        public bool DefaultValuesSet { get; set; }
        
        public int ActiveButton { get; set; }

        public Menu()
        {
            Elements = new List<string>();
            Labels = new List<string>();
        }
    }
}