using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Полет
{
    class Program
    {
        static void Main()
        {
            string[] mass = Console.ReadLine().Split(' '); //считываем строку и разбиваем значения по пробелу

            double h = double.Parse(mass[0]); //присваиваем переменным значения
            double t = double.Parse(mass[1]);
            double v = double.Parse(mass[2]);
            double x = double.Parse(mass[3]);

            if (5000 <= h && h <= 12000 && 50 <= t && t <= 1200 && 1 <= x && x < v && v <= 100 && h <= t * v) 
                //делаем проверку значений по условию
            {
                Console.WriteLine("{0:0.0#####} {1:0.0#####}", h <= t * x ? 0 : (h - x * t) / (v - x), h > x * t ? t : h / x); 
                //если все нормально вычисляем и выводим информацию
            }
            else
            {
                Console.WriteLine("Ошибка диапазона данных");
                Main(); //если ошибка ввода в диапазоне перезапускаем метод
            }

            Console.ReadKey(); //останавливаем работу консоли
        }
    }
}
