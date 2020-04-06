using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_Khysainov
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            //Вводим координаты 
            Console.Write("R=");
            double R = double.Parse(Console.ReadLine());
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());
            //Теперь используя полученные от пользователя данные проводим математику
            if (Math.Abs(x) <= R && Math.Abs(y) <= R && x * y <= 0 &&
                Math.Pow(x + R, 2) + Math.Pow(y - R, 2) >= R * R &&
                Math.Pow(x - R, 2) + Math.Pow(y + R, 2) >= R * R)
                //Если все правельно:
                Console.WriteLine("Точка принадлежит выбранной области");
                //Если нет:
            else Console.WriteLine("Точка не принадлежит выбранной области");

            Console.WriteLine("Чтобы закрыть нажмите Enter");
            Console.ReadLine();
        }
    }
}
