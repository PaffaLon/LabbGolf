using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.Logic.Stages
{
    public class LevelManager
    {
        public enum GameLevel_ID
        {
            Toturial = 0,
            Flatland,
            TheBrass,
            Horizon
        }
        public int SelectedLevel;

        public void GetLevel(int levelID)
        {
            switch (SelectedLevel)
            {
                case (int)GameLevel_ID.Flatland:
                    break;
                case (int)GameLevel_ID.TheBrass:
                    break;
                case (int)GameLevel_ID.Horizon:
                    break;
                default: //Touerial.
                    break;
            }
        }

        private void GetLoadedGame()
        {

        }
    }
}
