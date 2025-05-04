namespace Practica3Proda2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:
            // а) (x ∨ y) → (у ≡ x)
            // б) (x ∨ y) ≡ (у ∧ x)
            // в) (x ∧ y) ∨ (у → x)
            // г) (x ≡ y) → у
            // д) (x ∨ y) → (z ≡ x);
            // е) (x ≡ (z ∨ y)) ∨ ((x→ z) ∧ (y → x));
            //ж) y → (z ≡ x);
            //з) x ≡ (y → z).
            Console.WriteLine("Введите значение X: ");
            bool X = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            bool Y = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение Z: ");
            bool Z = bool.Parse(Console.ReadLine());

            bool a = !(X || Y) || (Y == X);
            bool b = (X || Y) == (Y && X);
            bool v = (X && Y) || (!Y || X);
            bool g = !(X == Y) || Y;
            bool d = !(X || Y) || (Z == X);
            bool e = (X == (Z || Y)) || ((!X || Z) && (!Y || X));
            bool j = !Y || (Z == X);
            bool z = X == (!Y || Z);

            Console.WriteLine($"не ({X} или {Y}) или ({Y} = {X}) = {a} ");
            Console.WriteLine($"({X} или {Y} = ({Y} и {X}) = {b} = {b} ");
            Console.WriteLine($"({X} и {Y}) или (не {Y} или {X}) = {v} ");
            Console.WriteLine($"не ({X} = {Y}) или {Y} = {g} ");
            Console.WriteLine($"не ({X} или {Y}) или ({Z} = {X}) = {d} ");
            Console.WriteLine($"({X} = ({Z} = {Y}) или ((не {X} или {Z}) и (не {Y} или {X})) = {e} ");
            Console.WriteLine($"не {Y} или ({Z} = {X}) = {j}");
            Console.WriteLine($"{X} = (не {Y} или {Z}) = {z} ");
        }
    }
}
