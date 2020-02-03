using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGolf.Logic.Levels
{
    interface ILevel
    {
        public void UpdateWinCondition();
        public void PlayerWins();
        public void UpdateItemPosition();
    }
    abstract class Level
    {
        protected bool DefaultValuesSet { get; set; }
        protected string Name { get; set; }
        protected int MaxSwingStrength { get; set; }
        protected int MinSwingStrength { get; } = 0;
    }
}
