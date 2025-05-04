namespace Practica3Proda21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 23. Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства: «валету» — 11, «даме» — 12, «королю» — 13,
            //«тузу» — 14 Порядковые номера остальных карт соответствуют их названиям
            //(«шестерка», «девятка» и т.п.).По заданному номеру карты k(6 <= k <= 14) определить достоинство соответствующей карты.
            Console.Write("Введите номер карты от 6 до 14: ");
            int k = int.Parse(Console.ReadLine());
            if (k == 6) 
            {
                Console.Write("Шестёрка"); 
            }
            else if (k == 7) 
            { 
                Console.Write("Семёрка"); 
            }
            else if (k == 8) 
            {
                Console.Write("Восьмёрка"); 
            }
            else if (k == 9) 
            { 
                Console.Write("Девятка"); 
            }
            else if (k == 10) 
            { 
                Console.Write("Десятка"); 
            }
            else if (k == 11) 
            { 
                Console.Write("Валет"); 
            }
            else if (k == 12) 
            { 
                Console.Write("Дама"); 
            }
            else if (k == 13) 
            { 
                Console.Write("Король"); 
            }
            else if (k == 14)
            { 
                Console.Write("Туз"); 
            }
        }
    }
}
