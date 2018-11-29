using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TimmysCarSimulator
{
    public class Room
    {
        public int XAxis { get; set; }
        public int YAxis { get; set; }

        public bool CheckValidAxis(string inputText)
        {
            var textArray = inputText.Split(' ');

            var isInt = CheckIfInt(textArray);

            if (textArray.Length == 2 && isInt)
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
                XAxis = Convert.ToInt32(textArray[0]);

                YAxis = Convert.ToInt32(textArray[1]);

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
