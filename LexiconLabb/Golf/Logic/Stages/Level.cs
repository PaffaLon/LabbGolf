using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.Logic.Stages
{
    public class Level
    {
        public enum Difficulity
        {
            Beginer,
            Easy,
            Hard
        }

        public enum AccessLevel
        {
            Granted,
            Revoked
        }
        public string Name  { get; set; }
        public int MaxScore { get; set; }
        public int MinScore { get; set; }
        public int StartinPositionGolfBall  { get; set; }
        public int StartingPositionGolfHole { get; set; }
        public int StartingPostionPlayer    { get; set; }
    }
}
