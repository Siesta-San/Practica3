namespace Practica3Proda13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 15.Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
            // Площадь круг S = π * R2; Площадь квадрата S = a2;
            Console.Write("Введите значение радиуса круга:");
            double R = double.Parse(Console.ReadLine());
            Console.Write("Введите значение стороны квадрата:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь круга:");
            double S1 = Math.PI * Math.Pow(R, 2);
            Console.WriteLine(S1);
            Console.WriteLine("Площадь квадрата:");
            double S2 = Math.Pow(a, 2);
            Console.WriteLine(S2);
            if (S1 > S2)
            {
                Console.WriteLine($"Площадь круга {S1} больше площади квадрата {S2} ");
            }
            else
            {
                Console.WriteLine($"Площадь квадрата {S2} больше площади круга {S1} ");
            }
        }
    }
}
