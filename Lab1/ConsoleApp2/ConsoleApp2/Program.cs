using System;

namespace ConsoleApp2
{
 

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Гитара");
            Guitar g = new Guitar("Cтрунные", "Мексика", 33000, 2012);
            g.Info();
            Console.WriteLine();
            Console.WriteLine($"Звук = {g.Play()}");

            Console.WriteLine("---------------------------");

            Console.WriteLine("Барабаны");
            Drum d = new Drum ("Ударные", "Америка", 57500.50, 2015);
            d.Info();
            Console.WriteLine();
            Console.WriteLine($"Звук = {d.Play()}");
        }
    }
}
