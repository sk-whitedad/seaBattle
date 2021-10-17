using System;

namespace seaBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();//создали корабль на поле с рандомными координатами 
            Fire fire = new Fire();
            fire.Notify += DisplayMessage;   // Добавляем обработчик для события Notify
            Console.WriteLine($"Обнаружен вражеский корабль!");
            Console.WriteLine($"Координаты корабля: {ship.X}:{ship.Y}");
            while (true)
            {
                Console.WriteLine($"Установить прицел по координатам: X:Y");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                fire.fireGo(x, y);
                if(fire.Result(x, y, ship.X, ship.Y))
                {
                    return;
                };
              
                       
                  
            }
        }


        private static void DisplayMessage(string msg)
        {
            Console.WriteLine(msg);
        }



    }
}
