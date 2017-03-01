using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApplication.Models
{
    public abstract class Location
    {

        readonly int radius = 6371; // Radius of the earth

        public double latitude { get;  private set; }
        public double longitude { get; private set; }

        private int visitCount = 0;

        public Location(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public virtual int visit()
        {
            return visitCount++;
        }

        public abstract void ShowDetails();




    }
}