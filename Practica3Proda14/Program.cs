namespace Practica3Proda14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 16.Определить, является ли число, а делителем числа b? А наоборот? (Получить два ответа.)
            Console.Write("Введите любое значение числа a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите любое значение числа b:");
            double b = double.Parse(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine("Число b является делителем числа a");
            }
            else
            {
                Console.WriteLine("Число b не является делителем числа a");
            }
            if (b % a == 0)
            {
                Console.WriteLine("Число a является делителем числа b");
            }
            else
            {
                Console.WriteLine("Число a не является делителем числа b");
            }
        }
    }
}
