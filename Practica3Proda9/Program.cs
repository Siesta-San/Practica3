namespace Practica3Proda9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //           11.Даны четыре различных вещественных числа. Не используя полный условный оператор, определить:
            //           а) наибольшее из них;
            //           б) наименьшее из них.
            Console.Write("Введите значение для числа a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение для числа b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение для числа c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Введите значение для числа d: ");
            double d = double.Parse(Console.ReadLine());
            if (a > b && a > c && a > d)
            {

               Console.WriteLine($"Наибольшее число {a}");
            }
            if (a < b && a < c && a < d)
            {

                Console.WriteLine($"Наименьшее число {a}");
            }
            if (b > a && b > c && b > d)
            {

                Console.WriteLine($"Наибольшее число {b}");
            }
            if (b < a && b < c && b < d)
            {

                Console.WriteLine($"Наименьшее число {b}");
            }
            if (c > a && c > b && c > d)
            {

                Console.WriteLine($"Наибольшее число {c}");
            }
            if (c < a && c < b && c < d)
            {

                Console.WriteLine($"Наименьшее число {c}");
            }
            if (d > a && d > b && d > c)
            {

                Console.WriteLine($"Наибольшее число {d}");
            }
            if (d < a && d < b && d < c)
            {

                Console.WriteLine($"Наименьшее число {d}");
            }
        }
    }
}
