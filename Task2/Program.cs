using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            decimal y1 = 0;
            decimal y2 = 0;
            decimal x1 = 0;
            decimal x2 = 0;


            Console.WriteLine("Введите координату первой из 2х диоганальных вершин по оси Y: ");
            y1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите координату первой из 2х диоганальных вершин по оси X: ");
            x1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите координату второй из 2х диоганальных вершин по оси Y: ");
            y2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите координату второй из 2х диоганальных вершин по оси X: ");
            x2 = Convert.ToDecimal(Console.ReadLine());

            decimal P = Math.Abs(y1 - y2) + Math.Abs(x1 - x2);
            Console.WriteLine($"Расчетная величина периметра P равна - {P}");

            decimal S = Decimal.Multiply(Math.Abs(y1 - y2), Math.Abs(x1 - x2));
            Console.WriteLine($"Расчетная величина площади S равна - {S}");

            Console.ReadKey();


        }
    }
}
