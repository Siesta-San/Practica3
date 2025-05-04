namespace Practica3proda10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12.Известны два расстояния: одно в километрах, другое — в футах(1 фут 0,305 м). Какое из расстояний меньше?
            Console.Write("Введите значение расстояния в киломметрах:");
            double kilometr = double.Parse(Console.ReadLine());
            Console.Write("Введите значение расстояния в футах:");
            double fut = double.Parse(Console.ReadLine());
            double kilometrs = kilometr * 1000;
            double futi = fut * 0.305;
            if (kilometrs < futi)
            {
                Console.WriteLine($"{kilometrs} килломенров меньше {futi} ");
            }
            else
            {
                Console.WriteLine($"{futi} футов меньше {kilometrs} киломметров");
            }
        }
    }
}
