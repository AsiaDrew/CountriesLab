using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class Country
    {
        //properties
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors = new List<string>();
        //constructor
        public Country(string name, string continent, List<string> colors)
        {
            Name = name;
            Continent = continent;
            Colors = colors;
        }
    }
}
