using System;
using System.Collections.Generic;
using System.Text;

namespace GolfSimplyfied.UI.Menus
{
    public interface IMenu
    {
        public void LoadMenu(int value);
        public enum Buttons { }
    }
    abstract class Menu
    {
        //Public Initialization
        public List<string> MenuElements { get; set; }
        public int PressedButton { get; set; }
        public Enum ID { get; set; }

        //Protected Initialization
        protected string[] SelectedMenuItems { get; set; }
        protected string[] UnselectedMenuItems { get; set; }
        protected bool DefaultValues { get; set; }
    }
}
