using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seaBattle
{
    class Fire
    {
        public delegate void AccountHandler(string msg);
        public event AccountHandler Notify;
        public int X { get; set; }
        public int Y { get; set; }
        public void fireGo(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine($"Огонь по координатам: {x}:{y}");
        }
        public bool Result(int x, int y, int x1, int y1)
        {
            bool res;
            if (x == x1 && y == y1)
            {
                Notify?.Invoke($"Цель поражена по координатам {x}:{y}");   // Вызов события
                res = true;
            }
            else
            {
                Notify?.Invoke($"Мимо цели! Повторить залп с коррекцией!");   // Вызов события
                res = false;
            }

            return res;
        }



    }
}
