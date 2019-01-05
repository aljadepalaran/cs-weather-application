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

        Location[] globalArray; //global array of all the locations
        Year[] globalYear; //global array of all the year - assigned later when a year is selected
        Month[] globalMonth; //global array of all the months - assigned later when a month is selected

        int globalSelectedYear; //the index for the year selected in the listbox
        int globalSelectedLocation; //the index for the location selected in the listbox 
        int globalSelectedMonth; //the index for the month selected in the listbox

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

            //declaring class arrays locally
            Location[] locationArray;

            //declaration of StreamReader variables and methods
            string filePath = "inputEXTENDED.txt"; //the filepath of the text file
            StreamReader fileReader = new StreamReader(filePath); //streamreader to input data from the file

            int numberOfLocations; //number of locations
            int numberOfYears = 0; //the number of years in the location dataset
            int monthCounter; //increments to 12, loops back
            int yearCounter = 0; //increments to same # as years
            int locationCounter = 0; //counter used to loop through the locations

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
                            //reading month properties and placing them into the variable
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
                            //reading month properties and placing them into the variable
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
            //clears the listboxes
            chooseLocation.Items.Clear();
            chooseYear.Items.Clear();
            chooseMonth.Items.Clear();

            //clears the location data
            locationNameBox.Clear();
            streetBox.Clear();
            countyBox.Clear();
            postcodeBox.Clear();
            latitudeBox.Clear();
            longitudeBox.Clear();

            //clears the year data
            yearBox.Clear();
            yearDescriptionBox.Clear();

            //clears the month data
            monthBox.Clear();
            maxTempBox.Clear();
            minTempBox.Clear();
            daysFrostBox.Clear();
            rainfallBox.Clear();
            sunshineBox.Clear();

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
            
            globalSelectedLocation = indexOfLocation; //assigns a value for the global variable to be used elsewhere

            Location selectedLocation_LOCAL;
            selectedLocation_LOCAL = globalArray[globalSelectedLocation]; //creates a local copy of the global location array

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
            string nameOfLocation; //stores the name of the location being looked for
            int indexOfLocation = 0; //variable used to store the index of the location, defaults to 0
            int arraySize; //finds the size of the location array - for searching through all of them

            nameOfLocation = _location; //extracts the location name from the parameter
            
            arraySize = globalArray.Length; //extracts the length of the global location array

            for (int i = 0; i < (arraySize); i++)
            {
                //checks if the location in the array matches what is being searched for
                if (globalArray[i].getLocationName() == nameOfLocation)
                {
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
            int locationIndex; //stores the index of the location selected
            int sizeOfLocation; //will store the number of years in the location
            int loopCounter; //will be used for a loop

            Year[] yearArray_LOCAL; //local year array - cleaner code

            locationIndex = _indexOfLocation; //extracts the location index from the parameter
            sizeOfLocation = globalArray[locationIndex].getYearsObserved().Length; //finds the size of the year array for the location selected

            yearArray_LOCAL = globalArray[locationIndex].getYearsObserved(); //assigns values to the local year array
            loopCounter = sizeOfLocation - 1; //declares the loop

            //checks if the loop counter is 0: it will break
            if (loopCounter == 0)
            {
                loopCounter = 1;
            }

            //adds all of the years to the listbox
            for (int i = 0; i < (loopCounter); i++)
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
            
            int indexOfYear = 0; //will store the index of the year selected in the location
            string selectedYear;

            Year selectedYear_LOCAL; //creates a local year object to work on

            //error handling when the user has not selected a year
            if(chooseYear.SelectedItem == null)
            {
                MessageBox.Show("You did not choose a year");
            }
            else
            {
                selectedYear = chooseYear.SelectedItem.ToString(); //sets the selected year

                indexOfYear = getYearIndex(selectedYear); //gets the index of the year using the getYearIndex method

                globalSelectedYear = indexOfYear; //assigns a value to the global selected year so it can be referenced outside the method without passing paramenter

                selectedYear_LOCAL = globalArray[globalSelectedLocation].getYearsObserved()[globalSelectedYear]; //creates a local copy of the year

                yearBox.Text = selectedYear_LOCAL.getYear().ToString(); //changes the value of the text box to the year

                yearDescriptionBox.Text = selectedYear_LOCAL.getDescription(); //changes the value of the text box to the year description
                
                showMonthData(indexOfYear); //displays all of the month data
            }
        }

        //a method to get the index of the year selected - linear search function
        public int getYearIndex(string _selectedYear)
        {
            string yearSelected = _selectedYear; //declares and assigns a value to the s
            int indexOfYear = 0;
            int sizeOfYear = globalArray[globalSelectedLocation].getYearsObserved().Length; //gets the size of the years

            //goes through every object in the global array and checks if it matches the location selected
            for (int i = 0; i < (sizeOfYear - 1); i++)
            {
                //checks if the location in the array matches what is being searched for
                if (globalArray[globalSelectedLocation].getYearsObserved()[i].getYear().ToString() == yearSelected)
                {
                    indexOfYear = i; //assigns i as the array position of the location to the variable that will be returned
                    break;
                }
                else
                {
                }
            }

            globalYear = globalArray[globalSelectedLocation].getYearsObserved(); //gets the years array

            return indexOfYear; //returns the index of the location
        }

        public void showMonthData(int _indexOfYear)
        {
            int yearIndex; //will store the index of the location
            int sizeOfYear; //will store the number of years in the location
            int monthIndex; //will store the index of the month

            yearIndex = _indexOfYear; //sets the index of the year, taken from the parameter

            sizeOfYear = globalArray[globalSelectedLocation].getYearsObserved().Length; //finds the size of the array of years - to be used in the loop

            for (int i = 0; i < 12; i++) //cycles through the months
            {

                monthIndex = globalArray[globalSelectedLocation].getYearsObserved()[globalSelectedYear].getMonths()[i].getMonthID(); //sets the index of the current month in the loop

                chooseMonth.Items.Add(GetMonthName(monthIndex)); //displays the month name into the listbox using the GetMonthName method passing in the monthIndex as a parameter
            }
        }

        //returns the name of the month based on the value of the parameter - the index of the month
        public string GetMonthName(int _monthIndex)
        {
            int monthIndex; //a local variable to store the parameter
            string monthOutput; //declares the output string - the name of the month

            monthOutput = "ERROR"; //sets the value to error in case there is an error - it is the default value

            monthIndex = _monthIndex; //assigns the parameter value to the monthIndex value

            //switch statement to rename the output to the month name based on the index of the month
            switch (monthIndex)
            {
                case 1:
                    monthOutput = "January";
                    break;
                case 2:
                    monthOutput = "February";
                    break;
                case 3:
                    monthOutput = "March";
                    break;
                case 4:
                    monthOutput = "April";
                    break;
                case 5:
                    monthOutput = "May";
                    break;
                case 6:
                    monthOutput = "June";
                    break;
                case 7:
                    monthOutput = "July";
                    break;
                case 8:
                    monthOutput = "August";
                    break;
                case 9:
                    monthOutput = "September";
                    break;
                case 10:
                    monthOutput = "October";
                    break;
                case 11:
                    monthOutput = "November";
                    break;
                case 12:
                    monthOutput = "December";
                    break;
                default:
                    monthOutput = "ERROR";
                    break;
            }

            return monthOutput; //returns the string output
        }

        private void chooseMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedMonth; //will store the selected item

            selectedMonth = chooseMonth.SelectedItem.ToString();//takes in the selected item as a string and assigns it to a local variable

            int indexOfMonth = getMonthIndex(selectedMonth); //returns an int with the month index

            getMonthIndex(selectedMonth); //gets the index of the month by taking in a string and returning an integer

            displayMonthData(indexOfMonth); //calls the procedure that displays the data of the month selected

        }

        public int getMonthIndex(string _selectedMonth)
        {

            string monthSelected; //will store the string that is passed in - the month selected

            monthSelected = _selectedMonth; //assigns the value to the parameter being passed in

            int monthIndex = 0; //will store the index of the month

            switch (monthSelected)
            {
                case "January":
                    monthIndex = 0;
                    break;
                case "February":
                    monthIndex = 1;
                    break;
                case "March":
                    monthIndex = 2;
                    break;
                case "April":
                    monthIndex = 3;
                    break;
                case "May":
                    monthIndex = 4;
                    break;
                case "June":
                    monthIndex = 5;
                    break;
                case "July":
                    monthIndex = 6;
                    break;
                case "August":
                    monthIndex = 7;
                    break;
                case "September":
                    monthIndex = 8;
                    break;
                case "October":
                    monthIndex = 9;
                    break;
                case "November":
                    monthIndex = 10;
                    break;
                case "December":
                    monthIndex = 11;
                    break;
                default:
                    monthIndex = 404;
                    break;
            }

            globalMonth = globalYear[globalSelectedYear].getMonths(); //assigns a value to the global month array - the month that has been selected

            globalSelectedMonth = monthIndex; //sets the value of the selected month to the globalSelectedMonth so it can be used globally

            return monthIndex; //returns and variable containing an integer representing the index of the month

        }
        
        public void displayMonthData(int _indexOfMonth)
        {

            int indexOfMonth; //will store the index of the month taken from the parameter

            indexOfMonth = _indexOfMonth; //assigns the value from the parameter to the local variable

            monthBox.Text = globalMonth[indexOfMonth].getMonthID().ToString(); //sets the value in the textbox for month ID

            maxTempBox.Text = globalMonth[indexOfMonth].getMaxTemperature().ToString(); //sets the value in the textbox for max temperature

            minTempBox.Text = globalMonth[indexOfMonth].getMinTemperature().ToString(); //sets the value in the textbox for min temperature

            daysFrostBox.Text = globalMonth[indexOfMonth].getDaysFrost().ToString(); //sets the value in the textbox for days frosted

            rainfallBox.Text = globalMonth[indexOfMonth].getRainfall().ToString(); //sets the value in the textbox for rainfall
            
            sunshineBox.Text = globalMonth[indexOfMonth].getSunshine().ToString(); //sets the value in the textbox for sunshine

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            Year[] yearArray_LOCAL; //creates a local array of years 
            Month[] monthArray_LOCAL; //creates a local array of months

            //declares variables to hold the new month values - defaults to 0
            double newMaxTemp = 0;
            double newMinTemp = 0;
            int newDaysFrost = 0;
            double newRainfall = 0;
            double newSunshine = 0;

            //declares variables to hold the new year values - defaults to 0 or ""
            int newTheYear = 0;
            string newYearDescription = "";

            //declares variables to hold the new month values - defaults to 0 or ""
            string newLocationName = "";
            string newStreet = "";
            string newCounty = "";
            string newPostcode = "";
            double newLatitude = 0;
            double newLongitude = 0;

            try //try-catch to get any error that may arise - input validation isn't implemented fully
            {
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
                monthArray_LOCAL[globalSelectedMonth].setMaxTemperature(newMaxTemp);
                monthArray_LOCAL[globalSelectedMonth].setMinTemperature(newMinTemp);
                monthArray_LOCAL[globalSelectedMonth].setDaysFrost(newDaysFrost);
                monthArray_LOCAL[globalSelectedMonth].setRainfall(newRainfall);
                monthArray_LOCAL[globalSelectedMonth].setSunshine(newSunshine);
                globalMonth[globalSelectedMonth] = monthArray_LOCAL[globalSelectedMonth];

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

            }
            catch
            {

                MessageBox.Show("ERROR: UNKNOWN - DID YOU LEAVE A FIELD BLANK?"); //an action for if an error occurs

            }

            ChangeFile(); //runs the change file procedure
            
        }

        //rewrites the file
        public void ChangeFile()
        {
            //file writing
            string fileLocation; //contains the location of the testfile
            StreamWriter fileWriter; //used to write to files

            //assigns value to the fileLocation and fileWriter
            fileLocation = "testFile.txt"; //references bin/Debug
            fileWriter = new StreamWriter(fileLocation, false); //instantiates the fileWriter with the parameter false

            //declaration of array sizes - defaults to 0
            int locationSize = 0;
            int yearSize = 0;

            //declaration of counters - defaults to 0 
            int locationCounter = 0;
            int yearCounter = 0;
            int monthCounter = 0;

            //declaration of location properties - defaults to either 0 or ""
            string locationName = "";
            string street = "";
            string county = "";
            string postcode = "";
            double latitude = 0;
            double longitude = 0;

            //declaration of year properties  - defaults to either 0 or ""
            string yearDescription = "";
            int theYear = 0;

            //declaration of month properties  - defaults to 0
            double maxTemperature = 0;
            double minTemperature = 0;
            int daysFrost = 0;
            double rainfall = 0;
            double sunshine = 0;

            //declaration of local arrays of objects
            Location[] locationArray_LOCAL;
            Year[] yearArray_LOCAL;
            Month[] monthArray_LOCAL;

            locationSize = globalArray.Length; //finds the length of the location array - used to loop through locations

            fileWriter.WriteLine(locationSize); //writes the number of locations into the data file
            
            while (locationCounter != locationSize) //loops through the locations
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
            
            ParseFile(); //runs the parser again to update with the current textfile
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //do nothing
        }

        private void addLocationButton_Click(object sender, EventArgs e)
        {
            
            int globalLocationArraySize; //will store the size of the global location array
            int newSize; //will store the new size of the array

            Location[] tempLocationArray; //creates a temporary location array
            Year[] newYearArray = new Year[1]; //creates a new year array to be added into the empty location
            Month[] monthArray = new Month[12]; //creates a new month array to be added into the emply year

            globalLocationArraySize = globalArray.Length; //gets the length of the current array
            newSize = globalLocationArraySize + 1; //assigns the new size of the array - adds one to the current size

            tempLocationArray = globalArray; //duplicates the data into the temporary location array

            globalArray = new Location[newSize]; //redeclares the global array with a bigger size

            for (int i = 0; i < tempLocationArray.Length; i++) //loops through the objects in the location array
            {

                globalArray[i] = tempLocationArray[i]; //copies the temp into the global array

            }

            for (int n = 0; n < 12; n++) //loops through all the months
            {

                monthArray[n] = new Month((n + 1), 0, 0, 0, 0, 0); //fills in the month objects with empty values - 0

            }
            
            newYearArray[0] = new Year(0, "", monthArray); //instantiates a new year

            globalArray[newSize - 1] = new Location("EMPTY", "EMPTY", "EMPTY", "EMPTY", 0, 0, newYearArray); //instantiates the new location in the array with empty values

            globalArray[newSize - 1].setYearsObserved(newYearArray); //sets the year array - redundant but safe

            chooseLocation.Items.Add(globalArray[newSize - 1].getLocationName()); //adds the new location into the listbox
        }

        private void addYearButton_Click(object sender, EventArgs e)
        {

            Year tempYear; //creates a temporary year object

            int locationToAddTo_INDEX = globalSelectedLocation; //which location to add the year to

            int currentLength; //will store the current length of the year array

            int newLength; //will store the new length of the array

            Month[] monthArray = new Month[12]; //declares an array of months

            currentLength = globalArray[locationToAddTo_INDEX].getYearsObserved().Length; //gets the length of the year array in the location selected

            newLength = currentLength + 1; //assigns the new length

            Year[] yearArray_CONTAINER = new Year[newLength]; //copy of the year array in the selected location

            
            for (int n = 0; n < 12; n++) //loops through all of the months
            {

                monthArray[n] = new Month((n + 1), 0, 0, 0, 0, 0); //instantiates the new months values with empty values - 0

            }

            tempYear = new Year(globalArray[locationToAddTo_INDEX].getYearsObserved()[newLength - 2].getYear(), "EMPTY", monthArray); //instantiates the temporary year with empty values

            yearArray_CONTAINER[newLength - 1] = tempYear; //stores the new temporary year into the array of year objects

            for (int i = 0; i < globalArray[locationToAddTo_INDEX].getYearsObserved().Length; i++) //loops through the array of years
            {

                yearArray_CONTAINER[i] = globalArray[locationToAddTo_INDEX].getYearsObserved()[i]; //adds the year to the array of years

            }
            
            globalArray[globalSelectedLocation].setYearsObserved(yearArray_CONTAINER); //sets the array of years

            chooseYear.Items.Add(globalArray[locationToAddTo_INDEX].getYearsObserved()[newLength - 1].getYear()); //adds the new year into the listbox

        }

        private void graphButton_Click(object sender, EventArgs e)
        {

            Graph dataGraph = new Graph(globalSelectedLocation, globalSelectedYear); //instantiates an object to load the form

            this.Hide(); //hides this form

            dataGraph.Show(); //shows the form

        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {

            chooseLocation.Items.Clear(); //clears the location

            string userInput; //holds the search query
            string compareArray; //holds the string being compared

            int compareLength; //holds the length that will be compared

            userInput = searchBar.Text; //assigns a value to the user input

            if (userInput.Length == 0) //checks if the search bar is empty
            {

                DisplayLocations(); //diplays the locations if the search is empty

            }
            else
            {
                for (int i = 0; i < globalArray.Length; i++) //loops through the array of locations
                {
                    if (userInput.Length > globalArray[i].getLocationName().Length) //checks if the search string is longer than the location names
                    {

                        compareLength = globalArray[i].getLocationName().Length; //sets the length to compare as the location - location is the shorter string

                    }
                    else
                    {

                        compareLength = userInput.Length; //sets the length to compare as the search query - search query is the shorter string

                    }

                    compareArray = globalArray[i].getLocationName().Substring(0, compareLength).ToLower(); //shortens the string to allow for comparison

                    if (userInput.Substring(0, compareLength).ToLower() == compareArray) //checks if the string is the same
                    {

                        chooseLocation.Items.Add(globalArray[i].getLocationName()); //adds the value to the listbox if the string is the same

                    }
                }
            }

        }

        //procedure to display all of the locations into the listbox
        public void DisplayLocations()
        {

            int totalLength; //will store the total length of the array of location objects

            string nameOfLocation; //stores the name of the location - cleaner when you output

            totalLength = globalArray.Length; //gets the length of the array of location objects

            for (int i = 0; i < totalLength; i++) //loops through all of the location objects in the array
            {

                nameOfLocation = $"{globalArray[i].getLocationName()}, {globalArray[i].getCounty()}"; //assigns a value to the name of locations to be outputted

                chooseLocation.Items.Add(nameOfLocation); //adds the name of the locations into the listbox

            }

        }

    }
}
