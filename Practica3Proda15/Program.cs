namespace Practica3Proda15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 17.Даны два прямоугольника, стороны которых параллельны или перпендикулярны осям координат. Известны координаты левого нижнего угла
            // каждого из них и длины их сторон. Один из прямоугольников назовем первым,
            // другой — вторым.
            // а) Определить, принадлежат ли все точки первого прямоугольника второму.
            // б) Определить, принадлежат ли все точки одного из прямоугольников другому.
            // в) Определить, пересекаются ли эти прямоугольники.
            Console.WriteLine("Координаты левого нижнего угла первого прямоугольника:");
            Console.Write("Введите координату X: ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Введите координату Y: ");
            double Y = double.Parse(Console.ReadLine());

            Console.WriteLine("Координаты левого нижнего угла второго прямоугольника:");
            Console.Write("Введите кординату X1 для второго прямоугольника: ");
            double X1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координату Y1 для второго прямоугольника: ");
            double Y1 = double.Parse(Console.ReadLine());

            Console.Write("Введите значение стороны a для первого прямоугольника: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение стороны b для первого прямоугольника: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите значение стороны a для второго прямоугольника:");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Введите значение стороны b для второго прямоугольника:");
            double b1 = double.Parse(Console.ReadLine());

            if (X >= X1 && Y >= Y1 && (X1 + a) <= (X1 + a1) && (Y + b) <= (Y1 + b1))
            {
                Console.WriteLine("Все точки первого прямоугольника принадлежат второму");
            }
            else
            {
                Console.WriteLine("Точки первого прямоугольника НЕ принадлежат второму");
            }
            if (((X >= X1 && Y >= Y1 && (X + a) <= (X1 + a1) && (Y + b) <= (Y1 + b1))) || (X1 >= X && Y1 >= Y && (X1 + a1) <= (X + a) && (Y1 + b1) <= (Y + b)))
            {
                Console.WriteLine("Все точки одного из прямоугольников принадлежат другому");
            }
            else
            {
                Console.WriteLine("Все точки одного из прямоугольников НЕ принадлежат другому");
            }
            if ((X < (X1 + a1) && (X + a) > X1) && (Y < (Y1 + b1) && (Y + b) > b1))
            {
                Console.WriteLine("Прямоугольники пересекаются");
            }
            else
            {
                Console.WriteLine("Прямоугольники НЕ пересекаются");
            }
        }
    }
}
