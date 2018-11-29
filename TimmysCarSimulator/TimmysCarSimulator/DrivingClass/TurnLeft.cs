using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimmysCarSimulator
{
    //Class and method is static because it never needs to be instantiated. It is only needed for basic methods.
    public static class TurnLeft
    {
        public static void TurnCarLeft(MonsterTruck mTruck)
        {
            switch (mTruck.Direction)
            {
                case "E":
                    mTruck.Direction = "N";
                    break;
                case "W":
                    mTruck.Direction = "S";
                    break;
                case "N":
                    mTruck.Direction = "W";
                    break;
                case "S":
                    mTruck.Direction = "E";
                    break;
            }
        }
    }
}
