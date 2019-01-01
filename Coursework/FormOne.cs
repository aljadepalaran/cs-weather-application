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
    public partial class Main : Form
    {
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

        //Called when the program starts
        public Main()
        {
            InitializeComponent(); //creates all the components in the windows form
        }

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

                locationDrop.Items.Add(locationName);

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

        //runs the fileparser when clicked.
        private void LoadButton_Click(object sender, EventArgs e)
        {
            locationDrop.Items.Clear();
            yearDrop.Items.Clear();
            monthDrop.Items.Clear();
              
            ParseFile(); //calls the parse procedure

            MessageBox.Show("Parsing Complete!"); //alerts if the parsing is complete

        }
       
        //testing still in progress
        private void MainView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void locationDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

            locationCheck = true;

            monthDrop.Items.Clear(); //clears the current drop for the month for when selecting a new location
            yearDrop.Items.Clear(); //clears the current drop for the year for when selecting a new location

            string selectedLocation = locationDrop.SelectedItem.ToString(); //declares variable containing the locatin selected
            int indexOfLocation = getLocationData(selectedLocation); //finds the index of the location

            globalSelectedLocation = indexOfLocation;

            Year[] displayYearArray; //an array used to store contents of the years within a location

            displayYearArray = globalArray[indexOfLocation].getYearsObserved(); //assigns value to the displayYearArray

            globalYear = displayYearArray; //assigns value to global year array to be used in another procedure

            //adds the years in the location to the drop down
            for(int x = 0; x < displayYearArray.Length; x++)
            {
                yearDrop.Items.Add(displayYearArray[x].getYear().ToString());
            }
        }

        private void yearDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

            yearCheck = true;

            monthDrop.Items.Clear(); //clears the current drop for the month for when selecting a new year

            string selectedYear = yearDrop.SelectedItem.ToString(); //declares variable containing the locatin selected

            int indexOfYear = getYearData(selectedYear); //finds the index of the year in the location

            globalSelectedYear = indexOfYear;

            Month[] displayMonthArray; //an array used to store contents of the years within a location

            displayMonthArray = globalYear[indexOfYear].getMonths(); //assigns value to the displayYearArray

            globalMonth = displayMonthArray; //assigns value to global month array

            //adds the years in the location to the drop down
            for (int x = 0; x < displayMonthArray.Length; x++)
            {
                monthDrop.Items.Add(displayMonthArray[x].getMonthID().ToString());
            }
        }
        
        private void monthDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthCheck = true;
            selectedMonth = Convert.ToInt32(monthDrop.SelectedItem.ToString()) - 1;
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            if (locationCheck == true & yearCheck == true & monthCheck == true){
                LocationView.Items.Clear();
                YearView.Items.Clear();
                MainView.Items.Clear(); //clears the mainview to prevent addition of months 

                string month = "";
                switch (selectedMonth)
                {
                    case 0:
                        month = "January";
                        break;
                    case 1:
                        month = "February";
                        break;
                    case 2:
                        month = "March";
                        break;
                    case 3:
                        month = "April";
                        break;
                    case 4:
                        month = "May";
                        break;
                    case 5:
                        month = "June";
                        break;
                    case 6:
                        month = "July";
                        break;
                    case 7:
                        month = "August";
                        break;
                    case 8:
                        month = "September";
                        break;
                    case 9:
                        month = "October";
                        break;
                    case 10:
                        month = "November";
                        break;
                    case 11:
                        month = "December";
                        break;
                }
                try
                {
                    //displays all the properties of the location and their values
                    LocationView.Items.Add($"Location | {globalArray[globalSelectedLocation].getLocationName()}");
                    LocationView.Items.Add($"Street | {globalArray[globalSelectedLocation].getStreet()}");
                    LocationView.Items.Add($"County | {globalArray[globalSelectedLocation].getCounty()}");
                    LocationView.Items.Add($"Postcode | {globalArray[globalSelectedLocation].getPostcode()}");
                    LocationView.Items.Add($"Latitude | {globalArray[globalSelectedLocation].getLatitude()}");
                    LocationView.Items.Add($"Longitude | {globalArray[globalSelectedLocation].getLongitude()}");

                    //displays all the properties of the year and their values
                    YearView.Items.Add($"Year | {globalYear[globalSelectedYear].getYear()}");
                    YearView.Items.Add($"Description | {globalYear[globalSelectedYear].getDescription()}");

                    //displays all the properties of the month and their values
                    MainView.Items.Add($"Month | {month}");
                    MainView.Items.Add($"MaximumTemperature | {globalMonth[selectedMonth].getMaxTemperature()}°");
                    MainView.Items.Add($"Minimum Temperature | {globalMonth[selectedMonth].getMinTemperature()}°");
                    MainView.Items.Add($"Days with Frost | {globalMonth[selectedMonth].getDaysFrost()}");
                    MainView.Items.Add($"Rainfall(mm) | {globalMonth[selectedMonth].getRainfall()}");
                    MainView.Items.Add($"Hours of Sunshine | {globalMonth[selectedMonth].getSunshine()}");
                }
                catch (Exception error)
                {
                    //try-catch to make sure that the input is suffficient
                    MessageBox.Show(error.ToString());
                    MessageBox.Show("Have you selected a year and a month?");
                }
            }
            //by theory, some of these should not be called because you cannot have a month without a year
            //you cannot have a year without a location thus you cannot have a month without a location
            else if(locationCheck == false & yearCheck == true & monthCheck == true)
            {
                MessageBox.Show("You haven't selected a location");
            }
            else if (locationCheck == true & yearCheck == false & monthCheck == true)
            {
                MessageBox.Show("You haven't selected a year");
            }
            else if (locationCheck == true & yearCheck == true & monthCheck == false)
            {
                MessageBox.Show("You haven't selected a month");
            }
            else if (locationCheck == false & yearCheck == false & monthCheck == false)
            {
                MessageBox.Show("You haven't selected a location & year & month");
            }
            else if (locationCheck == false & yearCheck == true & monthCheck == false)
            {
                MessageBox.Show("You haven't selected a location & month");
            }
            else if (locationCheck == true & yearCheck == false & monthCheck == false)
            {
                MessageBox.Show("You haven't selected a year & month");
            }
        }

        //finds the index of the year in the array
        public int getYearData(string _selectedYear)
        {
            int indexOfYear = 0;
            string year = _selectedYear;
            int arraySize;

            arraySize = globalYear.Length;

            for (int i = 0; i < (arraySize - 1); i++)
            {
                //checks if the location in the array matches what is being searched for
                if (globalYear[i].getYear().ToString() == year)
                {
                    //MessageBox.Show(location);
                    indexOfYear = i; //assigns i as the array position of the location
                    break;
                }
                else
                {
                }
            }
            return indexOfYear;
        }

        //finds the index of the location in the array
        public int getLocationData(string _location)
        {
            string location = _location;
            int arrayPosition = 0; //will contain the index in the array of locations for the location
            int arraySize;

            arraySize = globalArray.Length;

            for (int i = 0; i < (arraySize - 1); i++)
            {
                //checks if the location in the array matches what is being searched for
                if (globalArray[i].getLocationName() == location)
                {
                    //MessageBox.Show(location);
                    arrayPosition = i; //assigns i as the array position of the location
                    break;
                }
                else
                {
                }
            }
            return arrayPosition;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //special feature!
            //weather prediction?
        }
        
        private void EditButton_Click(object sender, EventArgs e)
        {
            //edit or add the data - will open a new form
            DataForm data = new DataForm(); //declares the form as an instance in the code
            this.Hide(); //hides the current form
            data.Show(); //shows the DataForm
        }
    }
}
