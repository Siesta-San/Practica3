namespace Practica3Proda11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13.Известны две скорости: одна в километрах в час, другая — в метрах в секунду. Какая из скоростей больше?
            Console.Write("Введите значение скорости(км/час):");
            double kilometr = double.Parse(Console.ReadLine());
            Console.Write("Введите значение скорости(м/секунда)");
            double fut = double.Parse(Console.ReadLine());
            double kilometrs = kilometr * 1000 / 3600;
            double futi = fut;
            if (kilometrs < futi)
            {
                Console.WriteLine($"скорость {kilometrs}км/час меньше {futi}м/секунду ");
            }
            else
            {
                Console.WriteLine($"скорость {futi}м/c меньше {kilometrs}км/час");
            }
        }
    }
}
