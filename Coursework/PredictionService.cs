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
    public partial class PredictionService : Form
    {

        Location[] globalArray;
        
        public PredictionService()
        {
            InitializeComponent();

            ParseFile();

            DisplayLocations();

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

                locationArray[locationCounter] = tempLocation; //adds the location to the location array

                locationCounter++; //increments the location counter - stops infinite loop

            }
            globalArray = locationArray; //sets the global array so that it can be used outside the parse
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {

            locationContainer.Items.Clear(); //clears the location

            string userInput; //holds the search query
            string compareArray; //holds the string being compared

            int compareLength; //holds the length that will be compared

            userInput = searchBar.Text;

            if (userInput.Length == 0)
            {
                DisplayLocations();
            }
            else
            {
                for (int i = 0; i < globalArray.Length; i++)
                {
                    if (userInput.Length > globalArray[i].getLocationName().Length)
                    {
                        compareLength = globalArray[i].getLocationName().Length;
                    }
                    else
                    {
                        compareLength = userInput.Length;
                    }

                    compareArray = globalArray[i].getLocationName().Substring(0, compareLength).ToLower();

                    if (userInput.Substring(0, compareLength).ToLower() == compareArray)
                    {
                        locationContainer.Items.Add(globalArray[i].getLocationName());
                    }
                }
            }
            
        }

        public void DisplayLocations()
        {
            int totalLength;
            string nameOfLocation;

            totalLength = globalArray.Length;
            

            for(int i = 0; i < totalLength; i++)
            {
                nameOfLocation = $"{globalArray[i].getLocationName()}, {globalArray[i].getCounty()}";
                locationContainer.Items.Add(nameOfLocation);
            }

        }

        private void locationContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string locationSelected;
            int locationIndex;

            locationSelected = locationContainer.SelectedItem.ToString();

            locationIndex = GetLocationIndex(locationSelected);

        }

        public int GetLocationIndex(string _location)
        {
            string locationSelected;
            int outputIndex = 0;

            locationSelected = _location;

            for (int i = 0; i < globalArray.Length; i++)
            {
                if(globalArray[i].getLocationName() == locationSelected)
                {
                    outputIndex = i;
                }
                else
                {
                    //do nothing 
                }
            }
            return outputIndex;
        }

        private void PredictionService_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphing = e.Graphics;
            Pen borderPen = new Pen(Color.Blue);

            graphing.DrawLine(borderPen, 300, 0, 300, 500);

        }
    }
}
