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
            ParseFile(); //runs after the form is loaded
        }

        private void chooseLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clears the current listboxes - stops appends
            chooseYear.Items.Clear();
            chooseMonth.Items.Clear();

            //clears the textboxes with the location data - removes old data
            locationNameBox.Clear();
            streetBox.Clear();
            countyBox.Clear();
            postcodeBox.Clear();
            latitudeBox.Clear();
            longitudeBox.Clear();

            //clears the textboxes with the year data - removes old data
            yearBox.Clear();
            yearDescriptionBox.Clear();

            //clears the textboxes with the month data - removes old data
            monthBox.Clear();
            maxTempBox.Clear();
            minTempBox.Clear();
            daysFrostBox.Clear();
            rainfallBox.Clear();
            sunshineBox.Clear();

            string selectedLocation = chooseLocation.SelectedItem.ToString(); //takes in the location selected
            int indexOfLocation = getLocationIndex(selectedLocation); //gets the index of the location selected

            MessageBox.Show(selectedLocation);
            globalSelectedLocation = indexOfLocation; //assigns a value for the global variable to be used elsewhere

            Location selectedLocation_LOCAL;

            selectedLocation_LOCAL = globalArray[globalSelectedLocation]; //creates a local copy of the global location array

            MessageBox.Show($"NAME: {selectedLocation_LOCAL.getLocationName()}, INDEX:{globalSelectedLocation}");

            //fills in the location data when a location has been selected
            locationNameBox.Text = selectedLocation_LOCAL.getLocationName();
            streetBox.Text = selectedLocation_LOCAL.getStreet();
            countyBox.Text = selectedLocation_LOCAL.getCounty();
            postcodeBox.Text = selectedLocation_LOCAL.getPostcode();
            latitudeBox.Text = selectedLocation_LOCAL.getLatitude().ToString();
            longitudeBox.Text = selectedLocation_LOCAL.getLongitude().ToString();
            
            showYearData(indexOfLocation); //displays the location to the listbox
        }

        public int getLocationIndex(string _location)
        {
            string nameOfLocation;
            int indexOfLocation = 0; //variable used to store the index of the location, defaults to 0
            int arraySize;

            nameOfLocation = _location;
            arraySize = globalArray.Length; //extracts the length of the global location array

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
            int locationIndex;
            int sizeOfLocation; //will store the number of years in the location

            Year[] yearArray_LOCAL; //local year array - cleaner code

            locationIndex = _indexOfLocation;
            sizeOfLocation = globalArray[locationIndex].getYearsObserved().Length;

            yearArray_LOCAL = globalArray[locationIndex].getYearsObserved(); //assigns values to the local year array

            //adds all of the years to the listbox
            for (int i = 0; i < (sizeOfLocation - 1); i++)
            {
                chooseYear.Items.Add(yearArray_LOCAL[i].getYear());
            }

        }

        private void chooseYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clears the month selected and its values
            chooseMonth.Items.Clear(); 
            monthBox.Clear();
            maxTempBox.Clear();
            minTempBox.Clear();
            daysFrostBox.Clear();
            rainfallBox.Clear();
            sunshineBox.Clear();

            //clears the year data
            yearBox.Clear();
            yearDescriptionBox.Clear();

            int indexOfYear = 0;
            string selectedYear;
            Year selectedYear_LOCAL;

            selectedYear = chooseYear.SelectedItem.ToString();
            indexOfYear = getYearIndex(selectedYear);
            globalSelectedYear = indexOfYear;

            selectedYear_LOCAL = globalArray[globalSelectedLocation].getYearsObserved()[globalSelectedYear]; //creates a local copy of the year

            yearBox.Text = selectedYear_LOCAL.getYear().ToString();
            yearDescriptionBox.Text = selectedYear_LOCAL.getDescription();

            showMonthData(indexOfYear); //displays all of the month data
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

        private void submitButton_Click(object sender, EventArgs e)
        {

            //creates a local copy of the year and month array - cleaner code
            Year[] yearArray_LOCAL;
            Month[] monthArray_LOCAL;

            //declares variables to hold the new month values
            double newMaxTemp;
            double newMinTemp;
            int newDaysFrost;
            double newRainfall;
            double newSunshine;

            //declares variables to hold the new year values
            int newTheYear;
            string newYearDescription;

            //declares variables to hold the new month values
            string newLocationName;
            string newStreet;
            string newCounty;
            string newPostcode;
            double newLatitude;
            double newLongitude;

            //extracts the month values from the textboxes and assigns them to associated variable
            newMaxTemp = Convert.ToDouble(maxTempBox.Text);
            newMinTemp = Convert.ToDouble(minTempBox.Text);
            newDaysFrost = Convert.ToInt32(daysFrostBox.Text);
            newRainfall = Convert.ToDouble(rainfallBox.Text);
            newSunshine = Convert.ToDouble(sunshineBox.Text);

            //extracts the year values from the textboxes and assigns them to associated variable
            newTheYear = Convert.ToInt32(yearBox.Text);
            newYearDescription = yearDescriptionBox.Text;

            //extracts the location values from the textboxes and assigns them to associated variable
            newLocationName = locationNameBox.Text;
            newStreet = streetBox.Text;
            newCounty = countyBox.Text;
            newPostcode = postcodeBox.Text;
            newLatitude = Convert.ToDouble(latitudeBox.Text);
            newLongitude = Convert.ToDouble(longitudeBox.Text);

            //creates local copies of the arrays
            yearArray_LOCAL = globalArray[globalSelectedLocation].getYearsObserved();
            monthArray_LOCAL = yearArray_LOCAL[globalSelectedYear].getMonths();

            //sets the new values into the selected month
            monthArray_LOCAL[selectedMonth].setMaxTemperature(newMaxTemp);
            monthArray_LOCAL[selectedMonth].setMinTemperature(newMinTemp);
            monthArray_LOCAL[selectedMonth].setDaysFrost(newDaysFrost);
            monthArray_LOCAL[selectedMonth].setRainfall(newRainfall);
            monthArray_LOCAL[selectedMonth].setSunshine(newSunshine);
            globalMonth[selectedMonth] = monthArray_LOCAL[selectedMonth];

            //sets the new values into the selected year
            globalYear[globalSelectedYear].setYear(newTheYear);
            globalYear[globalSelectedYear].setDescription(newYearDescription);
            globalYear[globalSelectedYear].setMonths(globalMonth);

            //sets the new values into the selected location
            globalArray[globalSelectedLocation].setLocationName(newLocationName);
            globalArray[globalSelectedLocation].setStreet(newStreet);
            globalArray[globalSelectedLocation].setCounty(newCounty);
            globalArray[globalSelectedLocation].setPostcode(newPostcode);
            globalArray[globalSelectedLocation].setLatitude(newLatitude);
            globalArray[globalSelectedLocation].setLongitude(newLongitude);
            globalArray[globalSelectedLocation].setYearsObserved(globalYear);

            //CHECK IF THERE ARE SAME YEARS IN DATA - BUBBLE SORT
            //IF == THEN STOP
            //ELSE, SORT ARRAYS

            ChangeFile();
        }

        //rewrites the file
        public void ChangeFile()
        {
            //file writing
            string fileLocation; //contains the location of the testfile
            StreamWriter fileWriter; //used to write to files

            //assigns value to the fileLocation and fileWriter
            fileLocation = "testFile.txt";
            fileWriter = new StreamWriter(fileLocation, false);

            //declaration of array sizes
            int locationSize = 0;
            int yearSize = 0;

            //declaration of counters
            int locationCounter = 0;
            int yearCounter = 0;
            int monthCounter = 0;

            //declaration of location properties
            string locationName = "";
            string street = "";
            string county = "";
            string postcode = "";
            double latitude = 0;
            double longitude = 0;

            //declaration of year properties
            string yearDescription = "";
            int theYear = 0;

            //declaration of month properties
            double maxTemperature = 0;
            double minTemperature = 0;
            int daysFrost = 0;
            double rainfall = 0;
            double sunshine = 0;

            //declaration of local arrays
            Location[] locationArray_LOCAL;
            Year[] yearArray_LOCAL;
            Month[] monthArray_LOCAL;

            locationSize = globalArray.Length; //finds the length of the location array - used to loop through locations

            fileWriter.WriteLine(locationSize); //writes the number of locations into the data file
            
            while (locationCounter != locationSize)
            {

                locationArray_LOCAL = globalArray; //creates a local instance of the location array

                //assigns location properties
                locationName = locationArray_LOCAL[locationCounter].getLocationName();
                street = locationArray_LOCAL[locationCounter].getStreet();
                county = locationArray_LOCAL[locationCounter].getCounty();
                postcode = locationArray_LOCAL[locationCounter].getPostcode();
                latitude = locationArray_LOCAL[locationCounter].getLatitude();
                longitude = locationArray_LOCAL[locationCounter].getLongitude();

                //writes location properties
                fileWriter.WriteLine(locationName);
                fileWriter.WriteLine(street);
                fileWriter.WriteLine(county);
                fileWriter.WriteLine(postcode);
                fileWriter.WriteLine(latitude);
                fileWriter.WriteLine(longitude);

                yearArray_LOCAL = locationArray_LOCAL[locationCounter].getYearsObserved();  //creates a local instance of the year array

                yearSize = yearArray_LOCAL.Length;
                fileWriter.WriteLine(yearSize);

                yearCounter = 0; //resets the counter ready for another location

                //loop to read in the years
                while (yearCounter != yearSize)
                {

                    //assigns year properties
                    yearDescription = yearArray_LOCAL[yearCounter].getDescription().ToString();
                    theYear = yearArray_LOCAL[yearCounter].getYear();

                    //writes year properties
                    fileWriter.WriteLine(yearDescription);
                    fileWriter.WriteLine(theYear);

                    //creates a local version of the month array
                    monthArray_LOCAL = yearArray_LOCAL[yearCounter].getMonths();

                    monthCounter = 0; //resets the month counter ready for another year

                    //loop to write in the months
                    while (monthCounter != 12) //month counter - 12 months
                    {
                        //assigns month properties
                        maxTemperature = monthArray_LOCAL[monthCounter].getMaxTemperature();
                        minTemperature = monthArray_LOCAL[monthCounter].getMinTemperature();
                        daysFrost = monthArray_LOCAL[monthCounter].getDaysFrost();
                        rainfall = monthArray_LOCAL[monthCounter].getRainfall();
                        sunshine = monthArray_LOCAL[monthCounter].getSunshine();

                        //checks if the month is the first - stops the year from being appended twice
                        if (monthCounter == 0)
                        {
                            //writes the month properties to the file
                            fileWriter.WriteLine(monthCounter + 1);
                            fileWriter.WriteLine(maxTemperature);
                            fileWriter.WriteLine(minTemperature);
                            fileWriter.WriteLine(daysFrost);
                            fileWriter.WriteLine(rainfall);
                            fileWriter.WriteLine(sunshine);
                        }
                        else
                        {
                            //writes the month properties to the file (and year)
                            fileWriter.WriteLine(theYear);
                            fileWriter.WriteLine(monthCounter + 1);
                            fileWriter.WriteLine(maxTemperature);
                            fileWriter.WriteLine(minTemperature);
                            fileWriter.WriteLine(daysFrost);
                            fileWriter.WriteLine(rainfall);
                            //checks if the month is the last in the entire data set - stops the creation of a blank line at the end
                            if (locationCounter == (locationSize - 1) & yearCounter == (yearSize - 1) & monthCounter == 11) 
                            {
                                fileWriter.Write(sunshine); //writes the hours of sunshine
                            }
                            else
                            {
                                fileWriter.WriteLine(sunshine); //writes the hours of sunshine
                            }
                        }
                        monthCounter++; //increments the month counter - stops infinite loop
                    }
                    yearCounter++; //increments the year counter - stops infinite loop
                }
                locationCounter++; //increments the location counter - stops infinite loop
            }
            fileWriter.Close(); //closes the file writer
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //clears the current listboxes - stops appends
            chooseLocation.Items.Clear();
            chooseYear.Items.Clear();
            chooseMonth.Items.Clear();

            //runs the file parser again
            ParseFile();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //do nothing
        }

        private void addLocationButton_Click(object sender, EventArgs e)
        {
            int globalLocationArraySize;
            int newSize;

            Location[] tempLocationArray;
            Year[] newYearArray = new Year[1];
            Month[] monthArray = new Month[12];

            globalLocationArraySize = globalArray.Length; //gets length
            newSize = globalLocationArraySize + 1; //new size

            tempLocationArray = globalArray; //copies the data

            globalArray = new Location[newSize]; //resizes

            //copies the temp into the global
            for (int i = 0; i < tempLocationArray.Length; i++)
            {
                globalArray[i] = tempLocationArray[i];
            }

            for(int n = 0; n < 11; n++)
            {
                monthArray[n] = new Month((n + 1), 0, 0, 0, 0, 0);
            }

            newYearArray[0] = new Year(0, "", monthArray);

            globalArray[newSize - 1] = new Location("EMPTY", "EMPTY", "EMPTY", "EMPTY", 0, 0, newYearArray);
            
            chooseLocation.Items.Add(globalArray[newSize - 1].getLocationName());
        }

        private void addYearButton_Click(object sender, EventArgs e)
        {
            //expand year array
            //add blank year to listbox
            //fill with 12 blank months
        }

        public void SortYears()
        {

        }
    }
}
