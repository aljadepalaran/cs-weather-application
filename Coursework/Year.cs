using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class Year
    {
        //property declaration
        private int theYear;
        private string yearDescription;
        private Month[] monthsObserved;

        //constructor
        public Year(int _theYear, string _yearDescription, Month[] _monthsObserved)
        {
            theYear = _theYear;
            yearDescription = _yearDescription;
            monthsObserved = _monthsObserved;
        }

        //get methods
        public int getYear()
        {
            return theYear;
        }
        public string getDescription()
        {
            return yearDescription;
        }
        public Month[] getMonths()
        {
            return monthsObserved;
        }

        //set methods
        public void setYear(int _newYear)
        {
            theYear = _newYear;
        }
        public void setDescription(string _newDescription)
        {
            yearDescription = _newDescription;
        }
        public void setMonths(Month[] _newMonths)
        {
            monthsObserved = _newMonths;
        }
    }
}
