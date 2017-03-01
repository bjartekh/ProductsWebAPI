using System.Collections.Generic;
using ProductsApplication.Models;


/**
 * To compile this from csc:
 * # first add City and location to module
csc Models\City.cs Models\Location.cs /t:module
# will create City.netmodule
csc /addmodule:City.netmodule Reference\CityOverview.cs

 * 
 */
namespace ProductsApplication.Reference
{
    public class CityOverview
    {


        public static void Main()
        {

            List<City> cities = new List<City>();
            cities.Add(new City("NewYork", 8000000, 40.730610, -73.935242));
            cities.Add(new City("Bergen", 200000, 60.397076, 5.324383));


            foreach (City c in cities)
            {
                c.ShowDetails();
            }


        }
    }
}