using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Golf_2._0
{
    public class Stuff
    {
        //Private Props Initialization
        private double SwingStrength       { get; set; }
        private double SwingStrengthMax    { get; } = (10);
        private double SwingStrengthMin    { get; } = (0.01);
        private double GolfBallPosition { get; set; }
        private double Angle { get; set; }

        //Private Feaild Initialization
        private int amountOfSwings;
        private bool winConditionMet;
        private bool defaultValuesSet;
        private const double gravity = (9.8);
        private const double golfHolePosition = 100;


        public Stuff()
        {
            if (defaultValuesSet == false)
                SetDefefaultValues();
        }
        //Constructor Helper Methods
#region CHM
        private void SetDefefaultValues()
        {
            GolfBallPosition = 0;
            defaultValuesSet = true;
        }
        #endregion
        //Class Methods
        public void Momo()
        {
            ConsoleKeyInfo cki;

            Console.WriteLine("Game Controles");
            Console.WriteLine("Press space to throw the ball.");
            Console.WriteLine("Press arrow UP to increase your strength.");
            Console.WriteLine("Press Arrow DOWN to lower your strength.");

            cki = Console.ReadKey();
            do
            {
                if (cki.Key.GetHashCode() == 38)//ArrpwUp
                {
                    SwingStrength += 1;
                    Console.WriteLine($"Your swing strength: {SwingStrength}");
                }
                else if (cki.Key.GetHashCode() == 40)//Down
                {
                    SwingStrength += 1;
                    if (SwingStrength < SwingStrengthMin)
                        SwingStrength = 1;

                    Console.WriteLine($"Your swing strength: {SwingStrength}");
                }
                else if (cki.Key.GetHashCode() == 32)//Space
                {
                    Angle = SwingStrength;
                    double _travelDistance;
                    double _ditsance;
                    double _angleInRadianse;
                    amountOfSwings = +amountOfSwings;


                    _angleInRadianse = ((Math.PI / 180) * Angle);
                    _travelDistance = (Math.Pow(SwingStrength, 2) / gravity * Math.Sin(2 * _angleInRadianse));
                    _ditsance = GolfBallPosition - _travelDistance;


                    if (_ditsance == golfHolePosition)
                    {
                        winConditionMet = true;
                        Console.WriteLine("You Win!!!");
                        Thread.Sleep(60000);// Paused 60s
                    }
                    else if (_ditsance < golfHolePosition || _ditsance > golfHolePosition)
                    {
                        Console.WriteLine($"Golfhole position: {golfHolePosition}");
                        Console.WriteLine($"Ball travel distance: {_travelDistance}");
                        Console.WriteLine($"Remaing distance: {_ditsance}");
                    }
                    else
                    {
                        Console.WriteLine("Someting Went wrong with the ditsance");
                        Thread.Sleep(60000);// Paused 60s
                    }
                }
            } while (winConditionMet == false);
        }
    }
}
