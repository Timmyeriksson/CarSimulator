using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TimmysCarSimulator.DrivingClass
{
    public class Driving
    {
        public string LatestInput { get; set; }
        public bool ValidDriving(string inputText, MonsterTruck mTruck)
        {
            bool validInput = true;
            LatestInput = inputText;
            Regex rx = new Regex(@"[FLRB]");
            //No need to split the string here as a string basically is an array of characters and we don't care about positions, we just want to check every character and see if it matches
            //correct input
            foreach (var item in inputText)
            {
                if (rx.IsMatch(item.ToString().ToUpper()))
                {
                    continue;
                }
                else
                {
                    validInput = false;
                    break;
                }
            }
            return validInput;
        }

        public bool DrivingCar(MonsterTruck mTruck, Room room)
        {
            foreach (var item in LatestInput)
            {
                if (mTruck.XPosition <= room.XAxis && mTruck.YPosition <= room.YAxis && mTruck.XPosition > 0 && mTruck.YPosition > 0)
                {
                    switch (item.ToString().ToUpper())
                    {
                        case "F":
                            DriveForward.DriveCarForward(mTruck);
                            break;
                        case "B":
                            DriveBackwards.DriveCarBackwards(mTruck);
                            break;
                        case "L":
                            TurnLeft.TurnCarLeft(mTruck);
                            break;
                        case "R":
                            TurnRight.TurnCarRight(mTruck);
                            break;
                    }
                }
                else
                {
                    //If it crashes before it is finished, there will be no need to continue the simulation
                    break;
                }
            }
            if (mTruck.XPosition > room.XAxis || mTruck.XPosition < 1 || mTruck.YPosition > room.YAxis || mTruck.YPosition < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
