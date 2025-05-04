namespace Practica3Proda7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7 Рассчитать значение у при заданном значении х:
            // y = sin(x) при x> 0 или y = cos(x) в противном случае.
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            if (x > 0)
            {
                Math.Sin(x);
            }
            else {
                double y = Math.Cos(x);
            }
            Console.WriteLine($"При x = {x}, y = {y}");
        }
    }
}
