using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApplication.Models
{
    public class City : Location
    {
        private string name;
        private int population;

        private int initialVisit = 100;

        public City(string name, int population, double latitude, double longitude) : base(latitude, longitude)
        {
            this.name = name;
            this.population = population;
        }


        public override int visit()
        {
            return initialVisit + base.visit();
        }


        public override void ShowDetails()
        {
            Console.WriteLine(name + " " + population + " " + latitude + " " + longitude);
        }

    }
}