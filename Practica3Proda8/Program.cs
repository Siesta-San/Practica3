namespace Practica3Proda8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10 Даны три различных вещественных числа.Не используя полный условный оператор, определить:
            // а) наибольшее из них;
            // б) наименьшее из них.
            Console.Write("Введите значение для числа a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение для числа b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение для числа c: ");
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                if (b  > c)
                {
                    Console.WriteLine($"Наибольшее число {a}, наименьшее {c}"); 
                }
                if (c > b)
                {
                    Console.WriteLine($"Наибольшее число {a}, наименьшее {b}");
                }
            }
            if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine($"Наибольшее число {b}, наименьшее {c}");
                }
                if (c > a)
                {
                    Console.WriteLine($"Наибольшее число {b}, наименьшее {a}");
                }
            }
            if (c > b && c > a)
            {
                if (b > a)
                {
                    Console.WriteLine($"Наибольшее число {c}, наименьшее {a}");
                }
                if (a > b)
                {
                    Console.WriteLine($"Наибольшее число {c}, наименьшее {b}");
                }
            }
        }
    }
}
