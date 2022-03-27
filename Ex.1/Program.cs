using System;

namespace Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определить сколько рублей надо для покупки N долларов. Количество N задается с консоли. Курс задается рандомно.
            Console.Write("Введите количество долларов: ");
            double dollars = double.Parse(Console.ReadLine());
            double exchangeRes = DollarExchange(dollars);
            Console.WriteLine($"{dollars}$ на {DateTime.Now.ToString("dd/MM/yyyy")} составляет {exchangeRes} рублей");

            //Определить площадь и периметр прямоугольника.
            Console.Write("Введите высоту: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Введите ширину: ");
            double width = double.Parse(Console.ReadLine());
            double square = GetSquare(width, height);
            double perimeter = GetPerimeter(width, height);
            Console.WriteLine($"Периметр прямоугольника = {perimeter} , Площадь прямоугольника = {square}");

            //Два поезда выехали друг на встречу другу в одинаковое время. Определить, когда они встретятся. Скорости и расстояние задается с консоли.
            Console.Write("Введите скорость 1ого поезда: ");
            double speed1 = double.Parse(Console.ReadLine());
            Console.Write("Введите скорость 2ого поезда: ");
            double speed2 = double.Parse(Console.ReadLine());
            Console.Write("Введите расстояние между ними: ");
            double dist = double.Parse(Console.ReadLine());
            double time = GetTravelTime(speed1,speed2,dist);
            Console.WriteLine($"Поезда встретяться через {time} часа");
        }

        public static double DollarExchange(double dollars)
        {
            Random rnd = new Random();
            double rate = rnd.Next(90, 100);
            return rate * dollars;
        }
        public static double GetSquare(double width, double height)
        {
            return width * height;
        }
        public static double GetPerimeter(double width, double height)
        {
            return 2 * (width + height);
        }
        public static double GetTravelTime(double speed1, double speed2, double dist)
        {
            return dist / (speed1 + speed2);
        }
    }
}
