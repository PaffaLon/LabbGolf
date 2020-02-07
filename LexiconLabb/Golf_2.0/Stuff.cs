using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Golf_2._0
{
    public class Stuff
    {
        private int MyPower { get; set; }
        private enum Power
        {
            Increment,
            decement
        }
        //Private Props Initialization
        private double SwingStrengthMin    { get; } = (0.01);
        private double GolfBallPosition { get; set; }
        private double Angle;

        //Private Feaild Initialization
        private int amountOfSwings;
        private bool winConditionMet;
        private bool defaultValuesSet;
        private const double gravity = (9.8);
        private const double golfHolePosition = 10.00;
        private int swings = 1;
        private bool ValidAngle;


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
            Console.TreatControlCAsInput = true;
            #region
            Console.WriteLine("Game Controles");
            Console.WriteLine("Press space to throw the ball.");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("UpArrow:                Angle + 1");
            Console.WriteLine("Ctrl + UpArrow:         Angle + 0.1");
            Console.WriteLine("Ctrl + Shift + UpArrow: Angle + 0.01");
            Console.WriteLine("Ctrl + Alt   + UpArrow: Angle + 10");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("DownArrow:                Angle - 1");
            Console.WriteLine("Ctrl + UpArrow:           Angle - 0.1");
            Console.WriteLine("Ctrl + Shift + DownArrow: Angle - 0.01");
            Console.WriteLine("Ctrl + Alt   + DownArrow: Angle - 10");
            Console.WriteLine(Environment.NewLine);
            #endregion
            while (winConditionMet == false)
            {
                //Double.TryParse(Console.ReadLine(), out Angle);
                SetAngle();
                ValidAngle = false;
                //ArrpwUp
                #region comment
                /*
                if (cki.Key.GetHashCode() == 38 && (((cki.Modifiers & ConsoleModifiers.Control) != 0)) && (((cki.Modifiers & ConsoleModifiers.Shift) != 0)))
                {
                    Angle += 0.01;
                    MyPower = (int)Power.Increment;
                    StrengthCheck();
                }
                else if (cki.Key.GetHashCode() == 38 && ((cki.Modifiers & ConsoleModifiers.Control) != 0))
                {
                    Angle += 0.1;
                    MyPower = (int)Power.Increment;
                    StrengthCheck();
                }
                else if (cki.Key.GetHashCode() == 38)
                {
                    Angle += 1;
                    MyPower = (int)Power.Increment;
                    StrengthCheck();
                }
                */
                #endregion

                //Down
                #region comment
                /*
                if (cki.Key.GetHashCode() == 40 && (((cki.Modifiers & ConsoleModifiers.Control) != 0)) && (((cki.Modifiers & ConsoleModifiers.Shift) != 0)))
                {
                    Angle -= 0.01;
                    MyPower = (int)Power.decement;
                    StrengthCheck();
                }
                else if (cki.Key.GetHashCode() == 40 && ((cki.Modifiers & ConsoleModifiers.Control) != 0))
                {
                    Angle -= 0.1;
                    MyPower = (int)Power.decement;
                    StrengthCheck();
                }
                else if (cki.Key.GetHashCode() == 40)
                {
                    Angle -= 1;
                    MyPower = (int)Power.decement;
                    StrengthCheck();
                }
                */
                #endregion
                //Space  cki.Key.GetHashCode() == 32
                bool gogo = true;
                if (gogo == true)
                {
                    double _travelDistance;
                    double _distanceToHole;
                    double _angleInRadianse;
                    amountOfSwings = swings++;


                    _angleInRadianse = ((Math.PI / 180) * Angle);
                    _travelDistance = (Math.Pow(Angle, 2) / gravity * Math.Sin(2 * _angleInRadianse));
                    //GolfBallPosition = _travelDistance;

                    _distanceToHole = _travelDistance - golfHolePosition;
                    GolfBallPosition = _distanceToHole;
                    Math.Round(_distanceToHole, 2);

                    
                    if (GolfBallPosition == golfHolePosition)
                    {
                        winConditionMet = true;
                        Console.WriteLine("You Win!!!");
                        Thread.Sleep(60000);// Paused 60s
                        Debug.Print($"_ditsance: {_distanceToHole}");
                    }
                    else if (GolfBallPosition < golfHolePosition || GolfBallPosition > golfHolePosition)
                    {
                        Console.SetCursorPosition(70, 4);
                        Console.WriteLine($"Chose Angle: {Angle}");
                        Console.SetCursorPosition(70, 5);
                        Console.WriteLine($"Amount of swings: {amountOfSwings}");
                        Console.SetCursorPosition(70, 6);
                        Console.WriteLine($"Golfhole position: {golfHolePosition}");
                        Console.SetCursorPosition(70, 7);
                        Console.WriteLine($"Golfball position: {GolfBallPosition}");
                        Console.SetCursorPosition(70, 8);
                        Console.WriteLine($"Ball travel distance: {_travelDistance}");
                        Console.SetCursorPosition(70, 9);
                        Console.WriteLine($"Remaing distance: {_distanceToHole}" + Environment.NewLine);
                    }
                    else
                    {
                        Console.WriteLine("Someting Went wrong with the ditsance");
                        Thread.Sleep(60000);// Paused 60s
                    }
                }
            } 
        }
        private void SetAngle()
        {
            string _Ipt;
            while(ValidAngle == false)
            {
                Console.SetCursorPosition(70, 0);
                Console.WriteLine("                         ");
                Console.SetCursorPosition(70, 0);
                _Ipt = Console.ReadLine();
                double.TryParse(_Ipt, out Angle);
                Debug.Print(Angle.ToString());

                if (Angle <= 379 || Angle >= 0)
                    ValidAngle = true;
                else
                    ValidAngle = false;
            }
        }
        private void StrengthCheck()
        {
            if(MyPower == (int)Power.Increment)
            {
                Console.SetCursorPosition(70, 3);
                Console.WriteLine($"Your swing Angle: {Angle}");
            }
            else if (MyPower == (int)Power.decement)
            {
                if (Angle < SwingStrengthMin)
                    Angle = 1;

                Console.SetCursorPosition(70, 3);
                Console.WriteLine($"Your swing Angle: {Angle}");
            }
        }
    }
}
