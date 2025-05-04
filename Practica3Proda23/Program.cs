namespace Practica3Proda23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  а
            Console.WriteLine("Введите число от 1 до 365-го дня: ");
            int k = int.Parse(Console.ReadLine());
            int day = k % 7;

            if (day == 1) 
            {
                Console.WriteLine($" {k} день - это понедельник");
             }
            else if (day == 2)
            {
                Console.WriteLine($" {k} день - это вторник");
            }
            else if (day == 3)
            {
                Console.WriteLine($" {k} день - это среда");
            }
            else if (day == 4)
            {
                Console.WriteLine($" {k} день - это четверг");
            }
            else if (day == 5)
            {
                Console.WriteLine($" {k} день - это пятница");
            }
            else if (day == 6)
            {
                Console.WriteLine($" {k} день - это суббота");
            }
            else 
            {
                Console.WriteLine($" {k} день - это воскресенье");
            }
            // б
            Console.WriteLine("Введите число от 1 до 365-го дня: ");
            int k1= int.Parse(Console.ReadLine());
            Console.WriteLine("Введите какой по счету был день недели 1 января( от 1 до 7) ");
            int d = int.Parse(Console.ReadLine());
            day = (k1 + d - 1) % 7;

            if (day == 1)
            {
                Console.WriteLine($" {k} день - это понедельник");
            }
            else if (day == 2)
            {
                Console.WriteLine($" {k} день - это вторник");
            }
            else if (day == 3)
            {
                Console.WriteLine($" {k} день - это среда");
            }
            else if (day == 4)
            {
                Console.WriteLine($" {k} день - это четверг");
            }
            else if (day == 5)
            {
                Console.WriteLine($" {k} день - это пятница");
            }
            else if (day == 6)
            {
                Console.WriteLine($" {k} день - это суббота");
            }
            else
            {
                Console.WriteLine($" {k} день - это воскресенье");
            }

        }
    }
}
