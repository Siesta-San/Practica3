namespace Practica3Proda22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //24.Мастям игральных карт условно присвоены следующие порядковые номера: масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3, масти
            //«червы» — 4, а достоинству карт: «валету» — 11, «даме» — 12, «королю» — 13,
            //«тузу» — 14(порядковые номера карт остальных достоинств соответствуют их
            //названиям: «шестерка», «девятка» и т.п.).По заданным номеру масти m(1 <=
            //m <= 4) и номеру достоинства карты k(6 <= k <= 14) определить полное
            //название(масть и достоинство) соответствующей карты в виде «Дама пик»,
            //Шестерка бубен» и т. п.
            Console.Write("Введите номер масти карты от 1 до 4: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите номер карты от 6 до 14: ");
            int k = int.Parse(Console.ReadLine());
            string name = "";
            if (m == 1)
            {
                 name = "Пики";
            }
            else if (m == 2)
            {
                 name = "Трефы";
            }
            else if (m == 3) 
            {
                 name = "Бубны";
            }
            else if (m == 4)
            {
                name = "Червы";
            }

            if (k == 6)
            { 
                Console.WriteLine($"Шестёрка {name} "); 
            }
            else if (k == 7) { 
                Console.WriteLine($"Семёрка {name}"); 
            }
            else if (k == 8) 
            {
                Console.WriteLine($"Восьмёрка {name}"); 
            }
            else if (k == 9) 
            { 
                Console.WriteLine($"Девятка {name}"); 
            }
            else if (k == 10)
            { 
                Console.WriteLine($"Десятка {name}");
            }
            else if (k == 11) 
            {
                Console.WriteLine($"Валет {name}"); 
            }
            else if (k == 12) 
            { 
                Console.WriteLine("Дама {name}"); 
            }
            else if (k == 13) 
            { 
                Console.WriteLine($"Король {name}");
            }
            else if (k == 14) 
            { 
                Console.WriteLine($"Туз {name}");
            }

        }
    }
}
