namespace Practica3Proda6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8 Даны два различных вещественных числа. Определить:
            // а) какое из них больше;
            // б) какое из них меньше.
            Console.WriteLine("Введите значение для числа a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение для числа b:");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"Число {a} больше числа {b}");
            }
            else
            {
                Console.WriteLine($"Число {b} больше числа {a}");
            }
        }
    }
}