using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MusicalInstruments m1 = new MusicalInstruments() { ToolClass = "Неизвестный" };  //Создание неизвестного класса инструмента
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                List<MusicalInstruments> m = new List<MusicalInstruments>();
                m.Add(new MusicalInstruments() { Title = "Гитара", ToolClass = "Cтрунные", CountryOfProduction = "Мексика" });
                m.Add(new MusicalInstruments() { Title = "Флейта", ToolClass = "Духовые", CountryOfProduction = "Германия" });
                m.Add(new MusicalInstruments() { Title = "Виолончель", ToolClass = "Cтрунные", CountryOfProduction = "Италия" });
                m.Add(new MusicalInstruments() { Title = "Барабаны", ToolClass = "Ударные", CountryOfProduction = "США" });
                m.Add(new MusicalInstruments() { Title = "Труба", ToolClass = "Духовые", CountryOfProduction = "Франция" });
                m.Add(new MusicalInstruments() { Title = "Cкрипка", ToolClass = "Cтрунные", CountryOfProduction = "Мексика" });
                m.Add(new MusicalInstruments() { Title = "Рояль", ToolClass = "Клавишные", CountryOfProduction = "Россия" });
                m.Add(new MusicalInstruments() { Title = "Арфа", ToolClass = "Cтрунные", CountryOfProduction = "Франция" });

                Console.WriteLine();
                Console.WriteLine("Отобразить струнные инструменты, изобретенные в Мексике:");

                List<MusicalInstruments> m2 = (from x in m
                                               where x.ToolClass == "Cтрунные" && x.CountryOfProduction == "Мексика"
                                               orderby x.Title // Почему-то не работает сортировка по возрастанию...Много вариантов перепробовал
                                               select x).ToList();

                foreach (var temp in m2)
                {
                    Console.WriteLine(temp.Title);
                }
            }
        }
    }
}
