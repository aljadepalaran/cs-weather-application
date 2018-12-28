using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Month
    {
        //property declaration
        private int monthID;
        private double maxTemperature;
        private double minTemperature;
        private int daysFrost;
        private double rainfall;
        private double sunshine;

        //constructor
        public Month(int _monthID, double _maxTemperature, double _minTemperature, int _daysFrost, double _rainfall, double _sunshine)
        {
            monthID = _monthID;
            maxTemperature = _maxTemperature;
            minTemperature = _minTemperature;
            daysFrost = _daysFrost;
            rainfall = _rainfall;
            sunshine = _sunshine;
        }

        //get methods
        public int getMonthID()
        {
            return monthID;
        }
        public double getMaxTemperature()
        {
            return maxTemperature;
        }
        public double getMinTemperature()
        {
            return minTemperature;
        }
        public int getDaysFrost()
        {
            return daysFrost;
        }
        public double getRainfall()
        {
            return rainfall;
        }
        public double getSunshine()
        {
            return sunshine;
        }

        //set methods
        public void setMonthID(int _newMonthID)
        {
            monthID = _newMonthID;
        }
        public void setMaxTemperature(double _newMaxTemperature)
        {
            maxTemperature = _newMaxTemperature;
        }
        public void setMinTemperature(double _newMinTemperature)
        {
            minTemperature = _newMinTemperature;
        }
        public void setDaysFrost(int _newDaysFrost)
        {
            daysFrost = _newDaysFrost;
        }
        public void setRainfall(double _newRainfall)
        {
            rainfall = _newRainfall;
        }
        public void setSunshine(double _newSunshine)
        {
            sunshine = _newSunshine;
        }
    }
}
