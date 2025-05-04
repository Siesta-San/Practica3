namespace Practica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            1. Вычислить значение логического выражения при всех возможных значениях логических величин А и В:
            //            а) не(не А и не В) и А;
            //            б) не(не А или не В) или А;
            //            в) не(не А или не В) и В.
            Console.WriteLine("Введите значение А (true или false): ");
            bool A1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение B (true или false): ");
            bool B1 = bool.Parse(Console.ReadLine());
            bool C1 = !(!A1 && !B1) && A1;
            Console.WriteLine($"не (не {A1} и не {B1}) и {A1} = {C1}");
  
            bool C2 = !(!A1 || !B1) || A1;
            Console.WriteLine($"не (не {A1} или не {B1}) или {A1} = {C2}");

            bool C3 = !(!A1 || !B1) && B1;
            Console.WriteLine($"не (не {A1} или не {B1}) и {B1} = {C3}");
        }
    }
}
