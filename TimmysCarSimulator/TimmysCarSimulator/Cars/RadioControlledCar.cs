using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimmysCarSimulator
{
    public abstract class RadioControlledCar
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public string Direction { get; set; }
    }
}
