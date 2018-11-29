using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimmysCarSimulator
{
    //Class and method is static because it never needs to be instantiated. It is only needed for basic methods.
    public static class DriveForward
    {
        public static void DriveCarForward(MonsterTruck mTruck)
        {
            switch (mTruck.Direction)
            {
                case "E":
                    mTruck.XPosition += 1;
                    break;
                case "W":
                    mTruck.XPosition -= 1;
                    break;
                case "N":
                    mTruck.YPosition += 1;
                    break;
                case "S":
                    mTruck.YPosition -= 1;
                    break;
            }
        }
    }
}
