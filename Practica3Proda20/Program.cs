using System.Runtime.InteropServices;

namespace Practica3Proda20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //22.Имеется стол прямоугольной формы с размерами a x b(a и b — целые числа, a > b). В каком случае на столе можно разместить большее количество
            // картонных прямоугольников с размерами c x d(c и d — целые числа, c > d):
            //при размещении их длинной стороной вдоль длинной стороны стола или вдоль
            //короткой.Прямоугольники не должны
            //свисать со стола.
            Console.Write("Введите значениe числа a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значениe числа b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите значениe числа c: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Введите значениe числа d: ");
            int d = int.Parse(Console.ReadLine());
            double long1 = Math.Pow(a / c, 2);
            double short2 = Math.Pow(b / d, 2);
            if (long1 > short2)
            {
                Console.WriteLine("Больше картонок поместится вдоль длинной стороны");

            }
            else
            {
                Console.WriteLine("Больше картонок поместится вдоль короткой стороны");
            }
        }
    }
}
