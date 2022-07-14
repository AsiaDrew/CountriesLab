using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryListView
    {
        //properties
        public List<Country> Countries { get; set; }
        //constructor
        public CountryListView(List<Country> Countries)
        {
            this.Countries = Countries;
        }

        //methods
        public void Display()
        {

            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i}. {Countries[i].Name}");
            }

        }
    }
}
