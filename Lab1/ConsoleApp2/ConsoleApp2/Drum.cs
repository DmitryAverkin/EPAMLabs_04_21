using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Drum : MusicalInstruments
    {
        public Drum(string ToolClass, string CountryOfProduction, double Price, int YearOfProduction)

        {
            this.ToolClass = ToolClass;
            this.CountryOfProduction = CountryOfProduction;
            this.Price = Price;
            this.YearOfProduction = YearOfProduction;
        }
        override public void Info()
        {
            Console.WriteLine($"Класс инструмента: {ToolClass}");
            Console.WriteLine($"Cтрана производства: {CountryOfProduction}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Год производства: {YearOfProduction}");
        }
        public override string Play()
        {
            return "Тыщщщ";
        }
    }
}