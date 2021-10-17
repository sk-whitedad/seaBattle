using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace seaBattle
{
    class Ship
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Ship()
        {
                X = (new Random()).Next(5);
                Y = (new Random()).Next(5);
        }
    }
}
