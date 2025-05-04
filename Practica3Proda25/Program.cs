namespace Practica3Proda25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 27.Дата некоторого дня характеризуется двумя натуральными числами:  m(порядковый номер месяца) и n(число). По заданным n и m определить:
            // а) дату предыдущего дня(принять, что n и m не характеризуют 1 января);
            // б) дату следующего дня(принять, что n и m не характеризуют 31 декабря).
            // a 
            Console.WriteLine("Введите номер месяца от 1 до 12: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число от 1 до 31: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 1)
            {
                n -= 1;
            } else
            {
                if (m > 1)
                {
                    m -= 1;
                    n = 31;
                }
            }
            Console.WriteLine($"Число предыдущего дня: {n} ");
            // б 
            Console.WriteLine("б");
            if (n < 31)
            {
                n += 1;
            }
            else
            {
                if (m < 12)
                {
                    m += 1;
                    n = 1;
                }
            }
            Console.WriteLine($"Число предыдущего дня: {n} ");
        }
    }
}
