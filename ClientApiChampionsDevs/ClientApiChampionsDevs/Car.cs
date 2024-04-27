using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiChampionsDevs
{
    internal class Car
    {
        public Car(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public string Name { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Year}";
        }
    }
}
