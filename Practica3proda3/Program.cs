namespace Practica3proda3
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            Записать логические выражения, которые имеют значение «Истина» только при выполнении указанных условий:
//            а) x < 2 и у< 3;
//            б) неверно, что x< 2;
//            в) x < 1 или y< 2;
//            г) неверно, что(x < 0 и x < 5);
//            д) x < 0 и у > 5;
//            е) 10 < x < 20;
//            ж) x > 3 или x< 1;
//            з) 0 < y < 4 и x< 5;
//            и) х > 3  и x< 10
            Console.Write("Введите пожалуйста значение для числа x(ввести нужно именно число): ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите пожалуйста значение для числа y(ввести нужно именно число): ");
            double y = double.Parse(Console.ReadLine());

            bool a = x < 2 && y < 3;
            bool b = !(x < 2);
            bool v = x < 1 || y < 2;
            bool g = !(x < 0 && x < 5);
            bool d = x < 0 && y > 5;
            bool e = 10 < x && x < 20;
            bool j = x > 3 || x < 1;
            bool z = (0 < y && y < 4) && x < 5;
            bool i = x > 3 && x < 10;
            if (a == true) { 
                Console.WriteLine($"{x} < 2 и {y} < 3 = {a}");
            }
            if (b == true)
            {
                Console.WriteLine($"не ({x} < 2) = {b} ");
            }
            if (v == true)
            {
                Console.WriteLine($"{x} < 1 или {y} < 2 = {v} ");
            }
            if (g == true)
            {
                Console.WriteLine($"не ({x} < 0 и {x} < 5) = {g} ");
            }
            if (d == true)
            {

                Console.WriteLine($"{x} < 0 и {y} > 5 = {d} ");
            }
            if (e == true)
            {
                Console.WriteLine($"10 < {x} и {x} < 20 = {e} ");
            }
            if (j == true)
            {
                Console.WriteLine($"{x} > 3 или {x} < 1 = {j} ");
            }
            if (z == true)
            {
                Console.WriteLine($"(0 < {y} и {y} < 4) и {x} < 5 = {z}");
            }
            if (i == true)
            {
                Console.WriteLine($"{x} > 3 и {x} < 10 = {i} ");
            }
        }
    }
}
