namespace Practica3Proda18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 20.Дано целое число k(1 <= k <= 365).Определить, каким будет k - й день года: выходным(суббота и воскресенье) или рабочим, если 1 января — понедельник.
            // Даны два различных вещественных числа.Определить наибольшее и
            // наименьшее из них, не используя полный условный оператор, а применив:
            // а) два неполных условных оператора;
            // б) один неполный условный оператор.
            Console.WriteLine("Введите день в году (1-365):");
            int k = int.Parse(Console.ReadLine());
            int dayWeek = (k - 1) % 7;
            bool weekend = dayWeek == 5 || dayWeek == 6;
            if (weekend)
            {
                Console.WriteLine($"{k}-й день - это выходной рабочий");
            }
            else
            {
                Console.WriteLine($"{k}-й день - это рабочий");
            }
            // 20.1 Даны два различных вещественных числа.Определить наибольшее и наименьшее из них, не используя полный условный оператор, а применив:
            // а) два неполных условных оператора;
            // б) один неполный условный оператор.
            Console.WriteLine("Задача 20.1");
            Console.WriteLine("Введите любое число a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите любое число b: ");
            double b = double.Parse(Console.ReadLine());

            // a
            if (a > b )
            {
                Console.WriteLine($"Максимальное число {a}, минимальное число {b} ");

            }
            if (b > a)
            {
                Console.WriteLine($"Максимальное число {b}, минимальное число {a}");
            }
            // б
            double min = a;
            double max = b;
            if (a > b)
            {
                max = a;
                min = b;
            }
            Console.WriteLine($"Максимальное число {max}, минимальное число {min} ");
        }
    }
}
