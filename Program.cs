using System;

namespace Lab_12_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности: ");
            double Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина оружности: {0}", CircleAssistant.Length(Radius));
            Console.WriteLine("Площадь оружности: {0}", CircleAssistant.Square(Radius));

            Console.WriteLine("\nВведите координату X точки: ");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y точки: ");
            double Y = Convert.ToDouble(Console.ReadLine());
            CircleAssistant.IsIntersect(Radius,X,Y);


        }

        public static class CircleAssistant
        {
            public static double Length(double Radius)
            {
                return 2 * Math.PI * Radius;
            }

            public static double Square(double Radius)
            {
                return  Math.PI * Math.Pow(Radius,2);
            }

            public static void IsIntersect(double Radius, double x, double y)
            {
                double H = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                if (H <= Radius)
                    {
                    Console.WriteLine("Точка принадлежит окружности");
                }
                else
                {
                    Console.WriteLine("Точка НЕ принадлежит окружности");
                }

            }
        }

    }
}
