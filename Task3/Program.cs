using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal x1 = 0;
            decimal y1 = 0;
            decimal x2 = 0;
            decimal y2 = 0;
            decimal x3 = 0;
            decimal y3 = 0;

            decimal a = 0;
            decimal b = 0;
            decimal c = 0;

            decimal S = 0;
            decimal P = 0;
            decimal pHalf = 0;

            bool flg;

            //Принимаем значения координат

            Console.WriteLine("Введите координаты первой вершины треугольника последовательно в порядке x, y:");
            x1 = Convert.ToDecimal(Console.ReadLine());
            y1 = Convert.ToDecimal(Console.ReadLine());

            flg = true;
            while (flg)
            {

                Console.WriteLine("Введите координаты второй вершины треугольника последовательно в порядке x, y:");
                x2 = Convert.ToDecimal(Console.ReadLine());
                y2 = Convert.ToDecimal(Console.ReadLine());

                if (x2 != x1 || y2 != y1)
                {
                    flg = false;
                }
            }

            flg = true;
            while (flg)
            {

                Console.WriteLine("Введите координаты третьей вершины треугольника последовательно в порядке x, y:");
                x3 = Convert.ToDecimal(Console.ReadLine());
                y3 = Convert.ToDecimal(Console.ReadLine());

                if (!(x1 / x2 == y1 / y2 && x2 / x3 == y2 / y3 && x1 / x3 == y1 / y3))
                {
                    flg = false;
                }
                else
                {
                    Console.WriteLine("Третья вершина не может лежать на одной прямой с 2-мя другими.");
                }

            }

            //Расчитываем стороны треугольника

            a = CalcLen(x1, y1, x2, y2);
            b = CalcLen(x1, y1, x3, y3);
            c = CalcLen(x2, y2, x3, y3);

            //Расчитываем площадь треугольника

            P = (a + b + c);
            pHalf = P / (decimal)2;

            S = Convert.ToDecimal(Math.Sqrt((double)pHalf * ((double)pHalf - (double)a) * ((double)pHalf - (double)b) * ((double)pHalf - (double)c)));

            //Выводим результат
            Console.WriteLine($"Обозначены следующие координаты точек вершин треугольника ({x1},{y1}); ({x2},{y2}); ({x3},{y3})");
            Console.WriteLine("Стороны треугольника :");
            Console.WriteLine($"    A = {a}");
            Console.WriteLine($"    B = {b}");
            Console.WriteLine($"    C = {c}");
            Console.WriteLine($"Прощадь треугольника составляет - {S}");
            Console.ReadKey();
        }


        //метод определения длины прямой между 2-мя точками

        public static decimal CalcLen(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            decimal k1 = Math.Abs(x1 - x2);
            decimal k2 = Math.Abs(y1 - y2);
            decimal g = Convert.ToDecimal(Math.Sqrt(Math.Pow((double)k1, 2) + Math.Pow((double)k2, 2)));

            return g;
        }

    }
}
