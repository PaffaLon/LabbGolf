using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.Logic.Stages.Levels
{
    public class Toturial : Level
    {

        public string GetLevelName(string levelName)
        {
            this.Name = ("Toturial");
            return this.Name;
        }

        public void LevelDefaultSettings()
        {
            GetDifficulity();
            GetObjectStartingPositions();

            void GetObjectStartingPositions()
            {
                this.StartingPositionGolfHole = 0;
                this.StartinPositionGolfBall = 35;
                this.StartingPostionPlayer = this.StartinPositionGolfBall - 1;
            }

            int GetDifficulity()
            {
                this.Difficulity = (int)DifficulityRatings.Beginer;
                return this.Difficulity;
            }
        }

    }
}