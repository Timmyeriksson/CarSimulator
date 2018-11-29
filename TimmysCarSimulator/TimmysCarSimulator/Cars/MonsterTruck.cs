using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TimmysCarSimulator
{
    public class MonsterTruck : RadioControlledCar
    {
        public int MyProperty { get; set; }
        public bool CheckValidPosition(string inputText, Room room)
        {
            var textArray = inputText.Split(' ');

            var isInt = CheckIfInt(textArray);

            var smaller = CheckIfSmaller(room);

            var isDirection = CheckIfDirection(textArray);

            if (textArray.Length == 3 && isInt && smaller && isDirection)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckIfInt(string[] textArray)
        {
            Regex rx = new Regex(@"^\d+$");

            if (rx.IsMatch(textArray[0]) && rx.IsMatch(textArray[1]))
            {
                XPosition = Convert.ToInt32(textArray[0]);

                YPosition = Convert.ToInt32(textArray[1]);

                return true;
            }
            else
            {
                return false;
            }

        }

        private bool CheckIfDirection(string[] inputDirection)
        {
            Regex rx = new Regex(@"[NSWE]");

            if (inputDirection.Length == 3 && rx.IsMatch(inputDirection[2].ToUpper()))
            {
                Direction = inputDirection[2].ToUpper();
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckIfSmaller(Room room)
        {
            if (XPosition > room.XAxis || YPosition > room.YAxis)
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
