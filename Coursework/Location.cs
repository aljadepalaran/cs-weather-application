using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Location
    {
        //property declaration
        private string locationName;
        private string street;
        private string county;
        private string postcode;
        private double latitude;
        private double longitude;
        private Year[] yearsObserved;

        //constructor
        public Location(string _locationName, string _street, string _county, string _postcode, double _latitude, double _longitude, Year[] _yearsObserved)
        {
            locationName = _locationName;
            street = _street;
            county = _county;
            postcode = _postcode;
            latitude = _latitude;
            longitude = _longitude;
            yearsObserved = _yearsObserved;
        }

        //get methods
        public string getLocationName()
        {
            return locationName;
        }
        public string getStreet()
        {
            return street;
        }
        public string getCounty()
        {
            return county;
        }
        public string getPostcode()
        {
            return postcode;
        }
        public double getLatitude()
        {
            return latitude;
        }
        public double getLongitude()
        {
            return longitude;
        }
        public Year[] getYearsObserved()
        {
            return yearsObserved;
        }

        //set methods
        public void setLocationName(string _newLocationName)
        {
            locationName = _newLocationName;
        }
        public void setStreet(string _newStreet)
        {
            street = _newStreet;
        }
        public void setCounty(string _newCounty)
        {
            county = _newCounty;
        }
        public void setPostcode(string _newPostcode)
        {
            postcode = _newPostcode;
        }
        public void setLatitude(double _newLatitude)
        {
            latitude = _newLatitude;
        }
        public void setLongitude(double _newLongitude)
        {
            longitude = _newLongitude;
        }
        public void setYearsObserved(Year[] _newYearsObserved)
        {
            yearsObserved = _newYearsObserved;
        }
    }
}
