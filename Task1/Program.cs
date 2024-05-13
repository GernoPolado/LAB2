using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int L = 0;
            Console.WriteLine("Введите длину окружности L: ");
            L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Заданная длина окружности L равна - {L} ");


            decimal D = Convert.ToDecimal(L / Math.PI);
            decimal R = D / 2;
            Console.WriteLine($"Расчитанный радиус R равен - {R} ");

            decimal S = Decimal.Multiply(Convert.ToDecimal(Math.PI) * Convert.ToDecimal(2), Convert.ToDecimal(Math.Pow(Convert.ToDouble(R), 2)));
            Console.WriteLine($"Расчитанная площадь S равна - {S} ");


            Console.ReadKey();

        }
    }
}
