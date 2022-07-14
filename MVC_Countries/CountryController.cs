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
        public List<Country> CountryDb = new List<Country>()
        {
            new Country("USA","North America",new List<string>{"Red","White","Blue"}),
            new Country("Japan","Asia",new List<string>{"Red","White"}),
            new Country("China","Asia",new List<string>{"Red","Yellow"}),
            new Country("North Korea ","Asia", new List<string> { "Red", "White" }),
            new Country("South Korea","Asia",new List<string>{"Red","White","Blue","Black"}),
            new Country("Austrialia ","Australia", new List<string> { "Red","White","Blue"}),
            new Country("Russia", "Europe", new List<string> {"white", "blue", "red"}),
            new Country("United Kingdom","Europe", new List<string> { "Blue", "White", "Red" }),
        };
        //constructor
        public CountryController()
        {
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
                CountryListView clv = new CountryListView(CountryDb);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
                clv.Display();
                int index = int.Parse(Console.ReadLine());
                CountryAction(CountryDb[index]);
                Console.WriteLine("Would u like to learn about another country?(y/n)");
                if (Console.ReadLine().ToLower().Trim() == "y")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine("GoodBye!");
                    goAgain = false;
                    break;
                }
            }
        }
    }
}
