using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.Characters.Players
{
    public class Player : Character
    {
        public int MaxSwingStrength { get; set; }
        public int MinSwingStrength { get; set; }
        public bool Direction { get; set; }

        public Player()
        {
            MinSwingStrength = 1;
            MaxSwingStrength = 20;

        }
    }
}
