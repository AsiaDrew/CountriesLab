using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryView
    {
        //properties
        public Country DisplayCountry { get; set; }
        //constructor
        public CountryView(Country _DisplayCountry)
        {
            DisplayCountry = _DisplayCountry;
        }
        //methods
        public void Display()
        {
            Console.WriteLine($"COUNTRY DISPLAY\nName: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}");
            Console.WriteLine("Flag Colors:");
            foreach (string c in DisplayCountry.Colors)
            {
                string color = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(c);
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(color);
                if (color == "Black")
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                Console.WriteLine(c);
                Console.ResetColor();
            }
        }
    }
}
