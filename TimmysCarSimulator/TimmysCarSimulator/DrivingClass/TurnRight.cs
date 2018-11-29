using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimmysCarSimulator
{
    //Class and method is static because it never needs to be instantiated. It is only needed for basic methods.
    public static class TurnRight
    {
        public static void TurnCarRight(MonsterTruck mTruck)
        {
            switch (mTruck.Direction)
            {
                case "E":
                    mTruck.Direction = "S";
                    break;
                case "W":
                    mTruck.Direction = "N";
                    break;
                case "N":
                    mTruck.Direction = "E";
                    break;
                case "S":
                    mTruck.Direction = "W";
                    break;
            }
        }
    }
}
