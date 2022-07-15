using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    internal class CountryController
    {
        //properties
        public List<Country> CountryDb { get; set; } = new List<Country>()
        {
            new Country("USA","North America",new List<string>{"Red","White","Blue"}),
            new Country("Japan","Asia",new List<string>{"Red","White"}),
            new Country("China","Asia",new List<string>{"Red","Yellow"}),
            new Country("North Korea ","Asia", new List<string> { "Red", "White" }),
            new Country("South Korea","Asia",new List<string>{"Red","White","Blue","Black"}),
            new Country("Austrialia ","Australia", new List<string> { "Red","White","Blue"}),
            new Country("Russia", "Asia", new List<string> {"white", "blue", "red"}),
            new Country("United Kingdom","Europe", new List<string> { "Blue", "White", "Red" }),
            new Country("Zimbabwe", "Africa", new List<string> {"Green", "Yellow", "Red", "White", "Black"}),
            new Country("South Africa", "Africa", new List<string> {"green", "yellow", "white", "red", "blue", "black"}),
            new Country("Canada", "North America", new List<string>{"Red", "White"}),
            new Country("Brazil", "South America", new List<string>{"Blue", "Green", "Yellow"})
        };
        //constructor
        public CountryController()
        {
            //empty
        }
        //methods
        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }
        public void WelcomeAction()
        {
            bool goAgain = true;
            while (goAgain)
            {
                try
                {
                    CountryListView clv = new CountryListView(CountryDb);
                    Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
                    clv.Display();
                    int index = int.Parse(Console.ReadLine());
                    CountryAction(CountryDb[index]);

                }
                catch (FormatException e)
                {
                    Console.WriteLine($"\n{e.Message}");
                }
                catch (ArgumentOutOfRangeException a)
                {
                    Console.WriteLine($"\n{a.Message}");
                }
                Console.WriteLine("\nWould u like to learn about another country?(y/n)");
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y")
                {
                    Console.Clear();
                    continue;
                }
                else if (choice == "n")
                {
                    Console.WriteLine("\nGoodBye!");
                    goAgain = false;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("invalid,try again enter a number\n");
                    goAgain = true;
                }
            }
        }
    }
}
