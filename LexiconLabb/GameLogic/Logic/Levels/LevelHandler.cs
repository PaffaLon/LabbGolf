using System;
using System.Collections.Generic;
using System.Text;
using SimpleGolf.Logic.Levels.Lvls;

namespace SimpleGolf.Logic.Levels
{
    public class LevelHandler
    {
        public enum LevelID
        {
            Toturial,
        }

        Toturial toturial = new Toturial();
        public LevelHandler()
        {

        }

        public void RunLevel(LevelID levelID)
        {
            switch (levelID)
            {
                case LevelID.Toturial:
                    
                    break;
                default:
                    break;
            }
        }
    }
}
