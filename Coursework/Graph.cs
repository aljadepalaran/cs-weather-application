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
    public partial class Graph : Form
    {

        //declaration of all global variables - used to reference in methods outside the parser
        Location[] globalArray;
        int chosenLocationIndex;
        int chosenYearIndex;
        int yBoundary = 250;
        int radioChoice;
        bool radioCheck = false;

        //LABEL CONTROL PANEL
        Color labelTextColour = Color.Red;
        Color labelBackColour = Color.Transparent;
        Size labelSize = new Size(25,25);
        Font labelFont = new Font("Arial", 6, FontStyle.Bold);

        //GRAPH CONTROL PANEL

        public Graph()
        {

            InitializeComponent();

        }

        public Graph(int _location, int _year)
        {

            InitializeComponent();

            chosenLocationIndex = _location;
            chosenYearIndex = _year;

            ParseFile();

            DisplayMaxTemp();
            DisplayMinTemp();
            DisplayDaysFrost();
            DisplayRainfall();
            DisplaySunshine();

            radioChoice = 0;

            LoadLabels();

        }

        public void LoadLabels()
        {

            Label maxTempLabel, minTempLabel, daysFrostLabel, rainfallLabel, sunshineLabel;

            Size titleSize = new Size(200,50);

            // M A X   T E M P   L A B E L
            maxTempLabel = new Label();
            maxTempLabel.Location = new Point(525, 20);
            maxTempLabel.Text = "Max Temp";
            maxTempLabel.ForeColor = labelTextColour;
            maxTempLabel.BackColor = labelBackColour;
            maxTempLabel.Font = new Font("Arial", 25, FontStyle.Bold); ;
            maxTempLabel.Size = titleSize;

            minTempLabel = new Label();
            minTempLabel.Location = new Point(925, 20);
            minTempLabel.Text = "Min Temp";
            minTempLabel.ForeColor = labelTextColour;
            minTempLabel.BackColor = labelBackColour;
            minTempLabel.Font = new Font("Arial", 25, FontStyle.Bold); ;
            minTempLabel.Size = titleSize;

            daysFrostLabel = new Label();
            daysFrostLabel.Location = new Point(110, 425);
            daysFrostLabel.Text = "Days Frost";
            daysFrostLabel.ForeColor = labelTextColour;
            daysFrostLabel.BackColor = labelBackColour;
            daysFrostLabel.Font = new Font("Arial", 25, FontStyle.Bold); ;
            daysFrostLabel.Size = titleSize;

            rainfallLabel = new Label();
            rainfallLabel.Location = new Point(525, 425);
            rainfallLabel.Text = "Rainfall";
            rainfallLabel.ForeColor = labelTextColour;
            rainfallLabel.BackColor = labelBackColour;
            rainfallLabel.Font = new Font("Arial", 25, FontStyle.Bold); ;
            rainfallLabel.Size = titleSize;

            sunshineLabel = new Label();
            sunshineLabel.Location = new Point(925, 425);
            sunshineLabel.Text = "Sunshine";
            sunshineLabel.ForeColor = labelTextColour;
            sunshineLabel.BackColor = labelBackColour;
            sunshineLabel.Font = new Font("Arial", 25, FontStyle.Bold); ;
            sunshineLabel.Size = titleSize;

            Controls.Add(maxTempLabel);
            Controls.Add(minTempLabel);
            Controls.Add(daysFrostLabel);
            Controls.Add(rainfallLabel);
            Controls.Add(sunshineLabel);


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

        private void Graph_Paint(object sender, PaintEventArgs e)
        {
            Graphics L = e.Graphics;
            Pen P = new Pen(Color.LimeGreen);

            //writes the borders (debugging purpose)
            L.DrawLine(P, 0, 400, 1200, 400);
            L.DrawLine(P, 400, 0, 400, 800);
            L.DrawLine(P, 800, 0, 800, 800);

        }

        public void DisplayMaxTemp()
        {

            Location selectedLocation;

            Year selectedYear;

            Month[] displayMonths;

            PictureBox[] arrayOne = new PictureBox[12];

            Label[] labelArray = new Label[12];

            double maxTempValue; //will store the value of the maximum temperature
            int multiplierY; //will change relatively how tall the graph is so you have larger graphs that take more room
            double offsetY = 0; //will make sure the graphs are level
            int maxValue;
            int[] maxTempArray = new int[12];

            //extracts all the data from the global array
            selectedLocation = globalArray[chosenLocationIndex];
            selectedYear = globalArray[chosenLocationIndex].getYearsObserved()[chosenYearIndex];
            displayMonths = selectedYear.getMonths();

            //fills in an array of integers with all the values in the max temp data set.
            for (int n = 0; n < 12; n++)
            {
                maxTempArray[n] = Convert.ToInt32(displayMonths[n].getMaxTemperature());
            }

            //searches for the largest value in the array
            maxValue = LinearSearch(maxTempArray);

            //finds the multiplier
            multiplierY = yBoundary / maxValue;

            for (int i = 0; i < 12; i++)
            {
                maxTempValue = multiplierY * displayMonths[i].getMaxTemperature();

                offsetY = Math.Round(maxTempValue);

                arrayOne[i] = new PictureBox();
                arrayOne[i].Location = new Point((425 + (i * 30)), (350 - Convert.ToInt32(offsetY)));
                arrayOne[i].Size = new Size(25, Convert.ToInt32(maxTempValue));
                arrayOne[i].BackColor = Color.LimeGreen;
                PictureBox displayBox = arrayOne[i];
                Controls.Add(displayBox);


                labelArray[i] = new Label();
                labelArray[i].Location = new Point((427 + (i * 30)), 375);
                labelArray[i].Text = GetMonthName(i);
                labelArray[i].ForeColor = labelTextColour;
                labelArray[i].BackColor = labelBackColour;
                labelArray[i].Font = labelFont;
                labelArray[i].Size = labelSize;
                

                Label displayLabel = labelArray[i];
                Controls.Add(labelArray[i]);
            }
        }

        public void DisplayMinTemp()
        {

            Location selectedLocation;

            Year selectedYear;

            Month[] displayMonths;

            PictureBox[] arrayOne = new PictureBox[12];

            Label[] labelArray = new Label[12];

            double minTempValue; //will store the value of the maximum temperature
            int multiplierY; //will change relatively how tall the graph is so you have larger graphs that take more room
            double offsetY = 0; //will make sure the graphs are level
            int maxValue;
            int[] minTempArray = new int[12];

            //extracts all the data from the global array
            selectedLocation = globalArray[chosenLocationIndex];
            selectedYear = globalArray[chosenLocationIndex].getYearsObserved()[chosenYearIndex];
            displayMonths = selectedYear.getMonths();

            //fills in an array of integers with all the values in the max temp data set.
            for (int n = 0; n < 12; n++)
            {
                minTempArray[n] = Convert.ToInt32(displayMonths[n].getMinTemperature());
            }

            //searches for the largest value in the array
            maxValue = LinearSearch(minTempArray);

            //finds the multiplier
            multiplierY = yBoundary / maxValue;

            for (int i = 0; i < 12; i++)
            {
                minTempValue = multiplierY * displayMonths[i].getMinTemperature();

                offsetY = Math.Round(minTempValue);

                arrayOne[i] = new PictureBox();
                arrayOne[i].Location = new Point((825 + (i * 30)), (350 - Convert.ToInt32(offsetY)));
                arrayOne[i].Size = new Size(25, Convert.ToInt32(minTempValue));
                arrayOne[i].BackColor = Color.LimeGreen;
                PictureBox displayBox = arrayOne[i];
                Controls.Add(displayBox);

                labelArray[i] = new Label();
                labelArray[i].Location = new Point((827 + (i * 30)), 375);
                labelArray[i].Text = GetMonthName(i);
                labelArray[i].ForeColor = labelTextColour;
                labelArray[i].BackColor = labelBackColour;
                labelArray[i].Font = labelFont;
                labelArray[i].Size = labelSize;

                Label displayLabel = labelArray[i];
                Controls.Add(displayLabel);
            }
        }

        public void DisplayDaysFrost()
        {

            Location selectedLocation;

            Year selectedYear;

            Month[] displayMonths;

            PictureBox[] arrayOne = new PictureBox[12];

            Label[] labelArray = new Label[12];

            int daysFrost; //will store the value of the maximum temperature
            int multiplierY; //will change relatively how tall the graph is so you have larger graphs that take more room
            int offsetY = 0; //will make sure the graphs are level
            int maxValue;
            int[] daysFrostArray = new int[12];

            //extracts all the data from the global array
            selectedLocation = globalArray[chosenLocationIndex];
            selectedYear = globalArray[chosenLocationIndex].getYearsObserved()[chosenYearIndex];
            displayMonths = selectedYear.getMonths();

            //fills in an array of integers with all the values in the max temp data set.
            for (int n = 0; n < 12; n++)
            {
                daysFrostArray[n] = displayMonths[n].getDaysFrost();
            }

            //searches for the largest value in the array
            maxValue = LinearSearch(daysFrostArray);

            //finds the multiplier
            multiplierY = yBoundary / maxValue;

            for (int i = 0; i < 12; i++)
            {
                daysFrost = multiplierY * displayMonths[i].getDaysFrost();

                offsetY = daysFrost;

                arrayOne[i] = new PictureBox();
                arrayOne[i].Location = new Point((25 + (i * 30)), (750 - offsetY));
                arrayOne[i].Size = new Size(25, daysFrost);
                arrayOne[i].BackColor = Color.LimeGreen;
                PictureBox displayBox = arrayOne[i];
                Controls.Add(displayBox);

                labelArray[i] = new Label();
                labelArray[i].Location = new Point((27 + (i * 30)), 775);
                labelArray[i].Text = GetMonthName(i);
                labelArray[i].ForeColor = labelTextColour;
                labelArray[i].BackColor = labelBackColour;
                labelArray[i].Font = labelFont;
                labelArray[i].Size = labelSize;

                Label displayLabel = labelArray[i];
                Controls.Add(displayLabel);

            }
        }

        public void DisplayRainfall()
        {

            Location selectedLocation;

            Year selectedYear;

            Month[] displayMonths;

            PictureBox[] arrayOne = new PictureBox[12];

            Label[] labelArray = new Label[12];

            double rainfall; //will store the value of the maximum temperature
            int multiplierY; //will change relatively how tall the graph is so you have larger graphs that take more room
            int offsetY = 0; //will make sure the graphs are level
            int maxValue;
            int[] rainfallArray = new int[12];

            //extracts all the data from the global array
            selectedLocation = globalArray[chosenLocationIndex];
            selectedYear = globalArray[chosenLocationIndex].getYearsObserved()[chosenYearIndex];
            displayMonths = selectedYear.getMonths();

            //fills in an array of integers with all the values in the max temp data set.
            for (int n = 0; n < 12; n++)
            {
                rainfallArray[n] = Convert.ToInt32(displayMonths[n].getRainfall());
            }

            //searches for the largest value in the array
            maxValue = LinearSearch(rainfallArray);

            //finds the multiplier
            multiplierY = yBoundary / maxValue;

            for (int i = 0; i < 12; i++)
            {
                rainfall = multiplierY * displayMonths[i].getRainfall();

                offsetY = Convert.ToInt32(rainfall);

                arrayOne[i] = new PictureBox();
                arrayOne[i].Location = new Point((425 + (i * 30)), (750 - offsetY));
                arrayOne[i].Size = new Size(25, Convert.ToInt32(rainfall));
                arrayOne[i].BackColor = Color.LimeGreen;
                PictureBox displayBox = arrayOne[i];
                Controls.Add(displayBox);


                labelArray[i] = new Label();
                labelArray[i].Location = new Point((427 + (i * 30)), 775);
                labelArray[i].Text = GetMonthName(i);
                labelArray[i].ForeColor = labelTextColour;
                labelArray[i].BackColor = labelBackColour;
                labelArray[i].Font = labelFont;
                labelArray[i].Size = labelSize;

                Label displayLabel = labelArray[i];
                Controls.Add(displayLabel);
            }
        }

        public void DisplaySunshine()
        {

            Location selectedLocation;

            Year selectedYear;

            Month[] displayMonths;

            PictureBox[] arrayOne = new PictureBox[12];

            Label[] labelArray = new Label[12];

            int sunshine; //will store the value of the maximum temperature
            int multiplierY; //will change relatively how tall the graph is so you have larger graphs that take more room
            int offsetY = 0; //will make sure the graphs are level
            int maxValue;
            int[] sunshineArray = new int[12];

            //extracts all the data from the global array
            selectedLocation = globalArray[chosenLocationIndex];
            selectedYear = globalArray[chosenLocationIndex].getYearsObserved()[chosenYearIndex];
            displayMonths = selectedYear.getMonths();

            //fills in an array of integers with all the values in the max temp data set.
            for (int n = 0; n < 12; n++)
            {
                sunshineArray[n] = Convert.ToInt32(displayMonths[n].getSunshine());
            }

            //searches for the largest value in the array
            maxValue = LinearSearch(sunshineArray);

            //finds the multiplier
            multiplierY = yBoundary / maxValue;

            for (int i = 0; i < 12; i++)
            {
                sunshine = multiplierY * Convert.ToInt32(displayMonths[i].getSunshine());

                offsetY = sunshine;

                arrayOne[i] = new PictureBox();
                arrayOne[i].Location = new Point((825 + (i * 30)), (750 - offsetY));
                arrayOne[i].Size = new Size(25, sunshine);
                arrayOne[i].BackColor = Color.LimeGreen;
                PictureBox displayBox = arrayOne[i];
                Controls.Add(displayBox);


                labelArray[i] = new Label();
                labelArray[i].Location = new Point((827 + (i * 30)), 775);
                labelArray[i].Text = GetMonthName(i);
                labelArray[i].ForeColor = labelTextColour;
                labelArray[i].BackColor = labelBackColour;
                labelArray[i].Font = labelFont;
                labelArray[i].Size = labelSize;


                Label displayLabel = labelArray[i];
                Controls.Add(displayLabel);
            }
        }

        public int LinearSearch(int[] _numberArray)
        {
            int[] arraySearch;

            int maxValue = 0;
            int arrayLength;

            arraySearch = _numberArray;
            arrayLength = arraySearch.Length;

            for (int x = 0; x < arrayLength; x++)
            {
                if(arraySearch[x] > maxValue)
                {
                    maxValue = arraySearch[x]; //swaps the value to the bigger value
                }
                else
                {
                    //do nothing
                }
            }

            return maxValue;
        }

        private void backButton_Click(object sender, EventArgs e)
        {

            DataForm loadForm = new DataForm();

            this.Hide();

            loadForm.Show();

        }

        public string GetMonthName(int _monthIndex)
        {
            int monthIndex;

            string monthOutput = "";

            monthIndex = _monthIndex + 1;

            switch (monthIndex)
            {
                case 1:
                    monthOutput = "JAN";
                    break;
                case 2:
                    monthOutput = "FEB";
                    break;
                case 3:
                    monthOutput = "MAR";
                    break;
                case 4:
                    monthOutput = "APR";
                    break;
                case 5:
                    monthOutput = "MAY";
                    break;
                case 6:
                    monthOutput = "JUN";
                    break;
                case 7:
                    monthOutput = "JUL";
                    break;
                case 8:
                    monthOutput = "AUG";
                    break;
                case 9:
                    monthOutput = "SEP";
                    break;
                case 10:
                    monthOutput = "OCT";
                    break;
                case 11:
                    monthOutput = "NOV";
                    break;
                case 12:
                    monthOutput = "DEC";
                    break;
                default:
                    monthOutput = "ERROR";
                    break;
            }

            return monthOutput;
        }

        private void predictButton_Click(object sender, EventArgs e)
        {

            if (radioCheck == false)
            {
                MessageBox.Show("You have not selected a month property");
            }
            else if(radioCheck == true)
            {
                PredictionService loadForm = new PredictionService(chosenLocationIndex, chosenYearIndex, radioChoice);

                loadForm.Show();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioChoice = 0;
            radioCheck = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioChoice = 1;
            radioCheck = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioChoice = 2;
            radioCheck = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioChoice = 3;
            radioCheck = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioChoice = 4;
            radioCheck = true;
        }
    }
}
