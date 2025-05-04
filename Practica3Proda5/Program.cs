namespace Practica3Proda5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6 Записать условие, которое является истинным, когда:
            // а) целое А кратно двум или трем;
            // б) целое А не кратно трем и оканчивается нулем.
            // а) целое N кратно пяти или семи;
            // б) целое N кратно четырем и не оканчивается нулем.

            Console.Write("Введите число A: ");
            int A = int.Parse(Console.ReadLine());
            bool a = A % 2 == 0 || A % 3 == 0;
            if (a == true) {
            Console.WriteLine($"целое {A} кратно двум или трем: {a}");
            }
            
            bool b = A! / 3 == 0 && A % 10 == 0;
            if (b == true) {
            Console.WriteLine($"целое {A} не кратно трем и оканчивается нулем: {b}");
            }

            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());
            bool c = N % 5 == 0 || N % 7 == 0;
            if (c == true) {
            Console.WriteLine($"целое {N} кратно пяти или семи: {c}");
            }

            bool d = N % 4 == 0 && N % 10 != 0;
            if (d == true) { 
            Console.WriteLine($"целое {N} кратно четырем и не оканчивается нулем: {d}");
            }
        }
    }
}
