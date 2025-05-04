namespace Practica3Proda4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 Записать условие, которое является истинным, когда:
            // а) каждое из чисел А и В больше 100;
            // б) хотя бы одно из чисел А и В положительное;
            // в) каждое из чисел А, В, С кратно(делится без остатка) трем;
            // г) только одно из чисел А, В и С меньше 50;
            // д) хотя бы одно из чисел А, В, С отрицательно.
            // е) каждое из чисел X и Y нечетное;
            // ж) только одно из чисел X и Y меньше 20;
            // з) хотя бы одно из чисел X и Y равно нулю;
            // и) каждое из чисел X, Y, Z отрицательное;
            // к) только одно из чисел X, Y и Z кратно пяти;
            // л) хотя бы одно из чисел X, Y, Z  больше 100
            Console.Write("Введите число A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Введите число C: ");
            double C = double.Parse(Console.ReadLine());
            Console.Write("Введите число X: ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double Y = double.Parse(Console.ReadLine());
            Console.Write("Введите число Z: ");
            double Z = double.Parse(Console.ReadLine());

            bool a = A > 100 && B > 100;
            bool b = A > 0 || B > 0;
            bool v = (A % 3 == 0) && (B % 3 == 0) && (C % 3 == 0);
            bool g = A < 50 || B < 50 || C < 50;
            bool d = A < 0 || B < 0 || C < 0;
            bool e = (X % 2 != 0) && (Y % 2 != 0);
            bool j = X < 20 || Y < 20;
            bool z = X == 0 || Y == 0;
            bool i = X < 0 && Y < 0 && Z < 0;
            bool k = (X % 5 == 0) || (Y % 5 == 0) || (Z % 5 == 0);
            bool L = X > 100 || Y > 100 || Z > 100;

            if (a == true)
            {
                Console.WriteLine($"каждое из чисел {A} и {A} больше 100: {a} ");
            }
            if (b == true)
            {
                Console.WriteLine($"хотя бы одно из чисел {A} и {A} положительное: {b} ");
            }
            if (v == true)
            {
                Console.WriteLine($"каждое из чисел {A}, {A}, {A} кратно (делится без остатка) трем: {v}");
            }
            if (g == true)
            {
                Console.WriteLine($"только одно из чисел {A}, {B} и {B} меньше 50: {g}");
            }
            if (d == true)
            {
                Console.WriteLine($"хотя бы одно из чисел {A}, {B}, {B} отрицательно: {d}");
            }
            if (e == true)
            {
                Console.WriteLine($"каждое из чисел {X} и {Y} нечетное: {e}");
            }
            if (j == true)
            {
                Console.WriteLine($"только одно из чисел {X} и {Y} меньше 20: {j}");
            }
            if (z == true)
            {
                Console.WriteLine($"хотя бы одно из чисел {Y} и {Y} равно нулю: {z}");
            }
            if (i == true)
            {
                Console.WriteLine($"каждое из чисел {X}, {Y}, {Z} отрицательное: {i}");
            }
            if (k == true)
            {
                Console.WriteLine($"только одно из чисел {X}, {Y} и {Z} кратно пяти: {k}");
            }
            if (L == true)
            {
                Console.WriteLine($"хотя бы одно из чисел {X}, {Y}, {Z}  больше 100: {L}");
            }

        }
    }
}
