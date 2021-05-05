using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class MusicalInstruments
    {
        public string Title { get; set; }

        private string ToolClass1;
        public string ToolClass
        {
            get => ToolClass1;
            set
            {
                if (value == "Духовые" || value == "Ударные" || value == "Cтрунные" || value == "Клавишные")
                    ToolClass1 = value;
                else
                    throw
                    new ArgumentException("Неизвестный класс инструмента не существует");
            }
        }
        public string CountryOfProduction { get; set; }

    }
}
