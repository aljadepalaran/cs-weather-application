using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }
        //declaration of all global variables - used to reference in methods outside the parser
        Location[] globalArray;
        Year[] globalYear;
        Month[] globalMonth;
        int globalSelectedYear;
        int globalSelectedLocation;
        int selectedMonth;
        bool locationCheck = false;
        bool yearCheck = false;
        bool monthCheck = false;

        public void ParseFile()
        {
            //declaration of location properties
            string locationName;
            string street;
            string county;
            string postcode;
            double latitude;
            double longitude;
            Year[] yearsObserved;

            //declaration of year properties
            int theYear;
            string yearDescription;
            Month[] monthsObserved;

            //declaration of month properties
            int monthID;
            double maxTemperature;
            double minTemperature;
            int daysFrost;
            double rainfall;
            double sunshine;

            //declaring class arrays
            Location[] locationArray;

            //declaration of StreamReader variables and methods
            string filePath = "inputEXTENDED.txt"; //the filepath of the text file
            StreamReader fileReader = new StreamReader(filePath); //streamreader to input data from the file

            int numberOfLocations; //number of locations
            int numberOfYears = 0; //the number of years in the location dataset
            int monthCounter; //increments to 12, loops back
            int yearCounter = 0; //increments to same # as years
            int locationCounter = 0;

            numberOfLocations = Convert.ToInt32(fileReader.ReadLine()); //reads the very first line - number of locations

            locationArray = new Location[numberOfLocations]; //initializes the location array
            globalArray = new Location[numberOfLocations];
            while (locationCounter != numberOfLocations)
            {
                //reads location properties
                locationName = fileReader.ReadLine();
                street = fileReader.ReadLine();
                county = fileReader.ReadLine();
                postcode = fileReader.ReadLine();
                latitude = Convert.ToDouble(fileReader.ReadLine());
                longitude = Convert.ToDouble(fileReader.ReadLine());
                numberOfYears = Convert.ToInt32(fileReader.ReadLine());

                chooseLocation.Items.Add(locationName);

                yearsObserved = new Year[numberOfYears]; //initializes the year array

                yearCounter = 0; //resets the counter ready for another location

                //loop to read in the years
                while (yearCounter != numberOfYears)
                {
                    //reads year properties
                    yearDescription = fileReader.ReadLine();
                    theYear = Convert.ToInt32(fileReader.ReadLine());

                    monthsObserved = new Month[12]; //initializes the months array

                    monthCounter = 0; //resets the month counter ready for another year

                    //loop to read in the months
                    while (monthCounter != 12) //month counter - 12 months
                    {
                        //if start of the year, year would have been read already
                        if (monthCounter == 0)
                        {
                            monthID = Convert.ToInt32(fileReader.ReadLine());
                            maxTemperature = Convert.ToDouble(fileReader.ReadLine());
                            minTemperature = Convert.ToDouble(fileReader.ReadLine());
                            daysFrost = Convert.ToInt32(fileReader.ReadLine());
                            rainfall = Convert.ToDouble(fileReader.ReadLine());
                            sunshine = Convert.ToDouble(fileReader.ReadLine());
                        }
                        //if month is not the start, year would loop so would need to be read but no assigned
                        else
                        {
                            fileReader.ReadLine();
                            monthID = Convert.ToInt32(fileReader.ReadLine());
                            maxTemperature = Convert.ToDouble(fileReader.ReadLine());
                            minTemperature = Convert.ToDouble(fileReader.ReadLine());
                            daysFrost = Convert.ToInt32(fileReader.ReadLine());
                            rainfall = Convert.ToDouble(fileReader.ReadLine());
                            sunshine = Convert.ToDouble(fileReader.ReadLine());
                        }

                        Month tempMonth = new Month(monthID, maxTemperature, minTemperature, daysFrost, rainfall, sunshine); //creates the month to add to the month array

                        monthsObserved[monthCounter] = tempMonth; //adds the month to the month array

                        monthCounter++; //increments the month counter - stops infinite loop

                    }

                    Year tempYear = new Year(theYear, yearDescription, monthsObserved); //creates the year to add to the year array

                    yearsObserved[yearCounter] = tempYear; //adds the year to the year array

                    yearCounter++; //increments the year counter - stops infinite loop

                }

                Location tempLocation = new Location(locationName, street, county, postcode, latitude, longitude, yearsObserved); //creates the location to add to the month array

                //MainView.Items.Add(tempLocation);

                locationArray[locationCounter] = tempLocation; //adds the location to the location array

                locationCounter++; //increments the location counter - stops infinite loop

            }
            globalArray = locationArray; //sets the global array so that it can be used outside the parse
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            ParseFile();
        }

        private void chooseLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clears the current boxes
            //prevents build-up of data
            chooseYear.Items.Clear();
            chooseMonth.Items.Clear();

            string selectedLocation = chooseLocation.SelectedItem.ToString();
            int indexOfLocation = getLocationIndex(selectedLocation);
            globalSelectedLocation = indexOfLocation; //assigns a value for the global variable to be used elsewhere
            showYearData(indexOfLocation);
        }

        public int getLocationIndex(string _location)
        {
            string nameOfLocation = _location;
            int indexOfLocation = 0; //variable used to store the index of the location, defaults to 0
            int arraySize;

            arraySize = globalArray.Length;

            for (int i = 0; i < (arraySize - 1); i++)
            {
                //checks if the location in the array matches what is being searched for
                if (globalArray[i].getLocationName() == nameOfLocation)
                {
                    //MessageBox.Show(location);
                    indexOfLocation = i; //assigns i as the array position of the location
                    break;
                }
                else
                {
                }
            }
            return indexOfLocation;
        }

        public void showYearData(int _indexOfLocation)
        {
            int locationIndex = _indexOfLocation;
            int sizeOfLocation; //will store the number of years in the location
            sizeOfLocation = globalArray[locationIndex].getYearsObserved().Length;

            for(int i = 0; i < (sizeOfLocation - 1); i++)
            {
                chooseYear.Items.Add(globalArray[locationIndex].getYearsObserved()[i].getYear());
            }

        }

        private void chooseYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            chooseMonth.Items.Clear();

            //clears the month values
            monthBox.Clear();
            maxTempBox.Clear();
            minTempBox.Clear();
            daysFrostBox.Clear();
            rainfallBox.Clear();
            sunshineBox.Clear();

            int indexOfYear = 0;
            string selectedYear = chooseYear.SelectedItem.ToString();
            indexOfYear = getYearIndex(selectedYear);
            globalSelectedYear = indexOfYear;

            showMonthData(indexOfYear);
        }

        public int getYearIndex(string _selectedYear)
        {
            string yearSelected = _selectedYear;
            int indexOfYear = 0;
            int sizeOfYear = globalArray[globalSelectedLocation].getYearsObserved().Length; //gets the size of the years

            for (int i = 0; i < (sizeOfYear - 1); i++)
            {
                //checks if the location in the array matches what is being searched for
                if (globalArray[globalSelectedLocation].getYearsObserved()[i].getYear().ToString() == yearSelected)
                {
                    //MessageBox.Show(location);
                    indexOfYear = i; //assigns i as the array position of the location
                    break;
                }
                else
                {
                }
            }

            globalYear = globalArray[globalSelectedLocation].getYearsObserved(); //gets the years array

            return indexOfYear;
        }

        public void showMonthData(int _indexOfYear)
        {
            int yearIndex = _indexOfYear;
            int sizeOfYear; //will store the number of years in the location
            sizeOfYear = globalArray[globalSelectedLocation].getYearsObserved().Length;

            for (int i = 0; i < 12; i++)
            {
                chooseMonth.Items.Add(globalArray[globalSelectedLocation].getYearsObserved()[globalSelectedYear].getMonths()[i].getMonthID());
            }
        }

        private void chooseMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMonth = chooseMonth.SelectedItem.ToString();
            int indexOfMonth = getMonthIndex(selectedMonth);
            getMonthIndex(selectedMonth);

            displayMonthData(indexOfMonth);
        }

        public int getMonthIndex(string _selectedMonth)
        {

            string monthSelected = _selectedMonth;
            int monthIndex = 0; //will store the index of the month
            selectedMonth = monthIndex;

            for (int i = 1; i < 12; i++)
            {
                //checks if the location in the array matches what is being searched for
                if (globalArray[globalSelectedLocation].getYearsObserved()[globalSelectedYear].getMonths()[i].getMonthID().ToString() == monthSelected)
                {
                    //MessageBox.Show(location);
                    monthIndex = i; //assigns i as the array position of the location
                    break;
                }
                else
                {
                }
            }

            globalMonth = globalYear[globalSelectedYear].getMonths();

            return monthIndex;
        }

        public void displayMonthData(int _indexOfMonth)
        {
            int indexOfMonth = _indexOfMonth;

            monthBox.Text = globalMonth[indexOfMonth].getMonthID().ToString();
            maxTempBox.Text = globalMonth[indexOfMonth].getMaxTemperature().ToString();
            minTempBox.Text = globalMonth[indexOfMonth].getMinTemperature().ToString();
            daysFrostBox.Text = globalMonth[indexOfMonth].getDaysFrost().ToString();
            rainfallBox.Text = globalMonth[indexOfMonth].getRainfall().ToString();
            sunshineBox.Text = globalMonth[indexOfMonth].getSunshine().ToString();

        }
    }
}
