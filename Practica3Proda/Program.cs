namespace Practica3Proda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 Вычислить значение логического выражения при всех возможных значениях логических величин А, В и С:
            // а) не(А или не В и С);
            // б) А и не(В и А или не С);
            // в) не(не А или В и С)
            // г) не(А или не В и С) или С;
            // д) не(А и не В или С) и В;
            // е) не(не А или В и С) или А.

            // a 
            Console.WriteLine("Введите значение А (true/false): ");
            bool A1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение B (true/false): ");
            bool B1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение С (true/false): ");
            bool C1 = bool.Parse(Console.ReadLine());
            bool N1 = !(A1 || !B1 && C1);
            Console.WriteLine($"не ({A1} или {B1}) и {C1} = {N1}");

            // б
            bool N2 = A1 && !((B1 && A1) || !C1);
            Console.WriteLine($"{A1} и не ({B1} и {A1} или не {C1} = {N2} ");
            
            // в
            bool N3 = !(!A1 || B1 && C1);
            Console.WriteLine($"не (не {A1} или {B1} и {C1} = {N3}");

            // г
            bool N4 = !(A1 || !B1 && C1) && B1;
            Console.WriteLine($"не ({A1} или {B1} и {C1}) и {B1} = {N4}");
            
            // д
            bool N5 = !(A1 && !B1 || C1) && B1;
            Console.WriteLine($"не ({A1} и {B1}) или {C1}) и {B1} =  {N5}");

            // e
            bool N6 = !(!A1 || B1 && C1) || A1;
            Console.WriteLine($"не (не {A1} или {B1}) и {C1}) или {A1} = {N6}");
        }
    }
}
