namespace Practica3Proda12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14.Дано натуральное число.
            //а) Верно ли, что оно заканчивается четной цифрой?
            //б) Верно ли, что оно заканчивается нечетной цифрой?

            Console.WriteLine("Введите значение для натурального числа x");
            int x = int.Parse(Console.ReadLine());

            bool tr = (x % 10 == 0) || (x % 10 == 2) || (x % 10 == 4) || (x % 10 == 6) || (x % 10 == 8);

            if (tr)
            {
                Console.WriteLine($"число {x} заканчивается четной цифрой");
            } else
            {
                Console.WriteLine($"число {x} заканчивается НЕчетной цифрой");
            }
            

        }
    }
}
