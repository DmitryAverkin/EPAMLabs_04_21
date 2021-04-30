using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class MusicalInstruments
    {
        abstract public void Info ();
        abstract public string Play();
        public string ToolClass;
        public string CountryOfProduction;
        public double Price;
        public int YearOfProduction;
        
    }
}
