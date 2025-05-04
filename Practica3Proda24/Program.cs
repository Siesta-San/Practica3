namespace Practica3Proda24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  26.С начала 1990 года по некоторый день прошло n месяцев и 2 дня. Определить название месяца (январь, февраль и т. п.) этого дня.
            Console.WriteLine("Введите прошедшее количество месяцев");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число января");
            int day = int.Parse(Console.ReadLine());
            int year = 1990;
            int m = n / 12;
            int t = 0;
            string month = "";
            if (n > 12)
            {
                year = 1990 + (n / 12); 
            }
            if (n % 12 == 1 || t == 1) 
            {
                if (day + 2 > 31)
                {
                    month = "февраль";
                } else
                {
                    month = "январь";
                }
            }
            if (n % 12 == 2 || t == 2)
            {
                if (day + 2 > 28)
                {
                    month = "март";
                } else
                {
                    month = "февраль";
                }
            }
            if (n % 12 == 3 || t == 3)
            {
                if (day + 2 > 31)
                {
                    month = "апрель";
                } else
                {
                    month = "март";
                }
            }
            if (n % 12 == 4 || t == 4)
            {
                if (day + 2 > 30)
                {
                    month = "май";
                } else
                {
                    month = "апрель";
                }
            }
            if (n % 12 == 5 || t == 5)
            {
                if (day + 2 > 31)
                {
                    month = "июнь";
                } else
                {
                    month = "май";
                }
            }
            if (n % 12 == 6 || t == 6)
            {
                if (day + 2 > 30)
                {
                    month = "июль";
                }
                else
                {
                    month = "июнь";
                }
            }
            if (n % 12 == 7 || t == 7)
            {
                if (day + 2 > 31)
                {
                    month = "август";
                }
                else
                {
                    month = "июль";
                }
            }
            if (n % 12 == 8 || t == 8)
            {
                if (day + 2 > 31)
                {
                    month = "сентябрь";
                }
                else
                {
                    month = "август";
                }
            }
            if (n % 12 == 9 || t == 9)
            {
                if (day + 2 > 30)
                {
                    month = "октябрь";
                }
                else
                {
                    month = "сентябрь";
                }
            }
            if (n % 12 == 10 || t == 10)
            {
                if (day + 2 > 31)
                {
                    month = "ноябрь";
                }
                else
                {
                    month = "октябрь";
                }
            }
            if (n % 12 == 11 || t == 11)
            {
                if (day + 2 > 30)
                {
                    month = "декабрь";
                }
                else
                {
                    month = "ноябрь";
                }
            }
            if (n % 12 == 0) 
            {
                if (day + 2 > 31)
                {
                    month = "январь";
                    year += 1; 
                }
                else
                {
                    month = "декабрь";
                }
            }

            Console.WriteLine(year + " " + month);
        
        }
    }
}
