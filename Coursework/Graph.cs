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

        //<--- LABEL CONTROL PANEL --->
        Color labelTextColour = Color.Red;
        Color labelBackColour = Color.Transparent;
        Size labelSize = new Size(25, 25);
        Font labelFont = new Font("Arial", 6, FontStyle.Bold);
        Size titleSize = new Size(200, 50); //declares the size for the title labels

        public Graph()
        {

            InitializeComponent();

        }

        public Graph(int _location, int _year) //a constructor that takes in the location index and year index 
        {

            InitializeComponent();

            chosenLocationIndex = _location;
            chosenYearIndex = _year;

            ParseFile(); //runs the parser to fill the arrays

            //displays all of the graphs
            DisplayMaxTemp();
            DisplayMinTemp();
            DisplayDaysFrost();
            DisplayRainfall();
            DisplaySunshine();

            radioChoice = 0;

            LoadLabels(); //loads all of the labels for the graphs

        }

        public void LoadLabels()
        {

            //declares the new labels
            Label maxTempLabel;
            Label minTempLabel;
            Label daysFrostLabel;
            Label rainfallLabel;
            Label sunshineLabel;
            //instantiates and edits the properties for the max temperature label
            maxTempLabel = new Label();
            maxTempLabel.Location = new Point(525, 20);
            maxTempLabel.Text = "Max Temp";
            maxTempLabel.ForeColor = labelTextColour;
            maxTempLabel.BackColor = labelBackColour;
            maxTempLabel.Font = new Font("Arial", 25, FontStyle.Bold); ;
            maxTempLabel.Size = titleSize;

            //instantiates and edits the properties for the min temperature label
            minTempLabel = new Label();
            minTempLabel.Location = new Point(925, 20);
            minTempLabel.Text = "Min Temp";
            minTempLabel.ForeColor = labelTextColour;
            minTempLabel.BackColor = labelBackColour;
            minTempLabel.Font = new Font("Arial", 25, FontStyle.Bold); ;
            minTempLabel.Size = titleSize;

            //instantiates and edits the properties for the days frost label
            daysFrostLabel = new Label();
            daysFrostLabel.Location = new Point(110, 425);
            daysFrostLabel.Text = "Days Frost";
            daysFrostLabel.ForeColor = labelTextColour;
            daysFrostLabel.BackColor = labelBackColour;
            daysFrostLabel.Font = new Font("Arial", 25, FontStyle.Bold); ;
            daysFrostLabel.Size = titleSize;

            //instantiates and edits the properties for the rainfall label
            rainfallLabel = new Label();
            rainfallLabel.Location = new Point(525, 425);
            rainfallLabel.Text = "Rainfall";
            rainfallLabel.ForeColor = labelTextColour;
            rainfallLabel.BackColor = labelBackColour;
            rainfallLabel.Font = new Font("Arial", 25, FontStyle.Bold); ;
            rainfallLabel.Size = titleSize;

            //instantiates and edits the properties for the sunshine label
            sunshineLabel = new Label();
            sunshineLabel.Location = new Point(925, 425);
            sunshineLabel.Text = "Sunshine";
            sunshineLabel.ForeColor = labelTextColour;
            sunshineLabel.BackColor = labelBackColour;
            sunshineLabel.Font = new Font("Arial", 25, FontStyle.Bold); ;
            sunshineLabel.Size = titleSize;

            //adds in all of the labels
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

            Location[] locationArray;

            //declaration of StreamReader variables and methods
            string filePath = "inputEXTENDED.txt";
            StreamReader fileReader = new StreamReader(filePath);

            //declaring variables used in looping
            int numberOfLocations;
            int numberOfYears = 0;
            int monthCounter;
            int yearCounter = 0;
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

            Graphics L = e.Graphics; //creates a graphics object

            Pen P = new Pen(Color.LimeGreen); //creates a pen object

            //draws lines for borders to separate the graphs
            L.DrawLine(P, 0, 400, 1200, 400);
            L.DrawLine(P, 400, 0, 400, 800);
            L.DrawLine(P, 800, 0, 800, 800);

        }

        public void DisplayMaxTemp()
        {
            try {
                //declaring all the objects that is used in displaying the max temperature
                Location selectedLocation;
                Year selectedYear;
                Month[] displayMonths;
                PictureBox[] arrayOne = new PictureBox[12];
                Label[] labelArray = new Label[12];

                //declaring variables used to get the data and display the data
                double maxTempValue;
                int multiplierY;
                double offsetY;
                int maxValue;
                int[] maxTempArray = new int[12];
                bool negativeValue = false;

                offsetY = 0; //defaults the offset to 0

                //extracts all the data from the global array
                selectedLocation = globalArray[chosenLocationIndex];

                selectedYear = globalArray[chosenLocationIndex].getYearsObserved()[chosenYearIndex];

                displayMonths = selectedYear.getMonths();

                for (int n = 0; n < 12; n++)
                {

                    maxTempArray[n] = Convert.ToInt32(displayMonths[n].getMaxTemperature()); //assigns values into the array of max temperatures

                }

                maxValue = LinearSearch(maxTempArray); //uses the LinearSearch procedure to find the highest value in the array

                multiplierY = yBoundary / maxValue; //finds the multiplier

                for (int i = 0; i < 12; i++)
                {

                    maxTempValue = multiplierY * displayMonths[i].getMaxTemperature(); //sets the value of the max temp for the month 

                    //checks if the value is negative
                    if (maxTempValue < 0)
                    {

                        negativeValue = true; //used to change the colour of the labels

                        maxTempValue = Math.Abs(maxTempValue); //turns the value to positive

                    }

                    offsetY = Math.Round(maxTempValue); //sets the offset of the bar to level the bar

                    //instantiates and edits the properties for the max temperature picturebox
                    arrayOne[i] = new PictureBox();
                    arrayOne[i].Location = new Point((425 + (i * 30)), (350 - Convert.ToInt32(offsetY)));
                    arrayOne[i].Size = new Size(25, Convert.ToInt32(maxTempValue));

                    if (negativeValue == true)
                    {

                        arrayOne[i].BackColor = Color.Red;

                    }
                    else
                    {

                        arrayOne[i].BackColor = Color.LimeGreen;

                    }

                    //instantiates and edits the properties for the max temperature label
                    labelArray[i] = new Label();
                    labelArray[i].Location = new Point((427 + (i * 30)), 375);
                    labelArray[i].Text = GetMonthName(i);
                    labelArray[i].ForeColor = labelTextColour;
                    labelArray[i].BackColor = labelBackColour;
                    labelArray[i].Font = labelFont;
                    labelArray[i].Size = labelSize;

                    //adds the label and the picturebox
                    Controls.Add(labelArray[i]);
                    Controls.Add(arrayOne[i]);
                }
            }
            catch
            {

                DisplayError();

            }
        }

        public void DisplayMinTemp()
        {

            try
            {
                //declaring all the objects that is used in displaying the max temperature
                Location selectedLocation;
                Year selectedYear;
                Month[] displayMonths;
                PictureBox[] arrayOne = new PictureBox[12];
                Label[] labelArray = new Label[12];

                //declaring variables used to get the data and display the data
                double minTempValue;
                int multiplierY;
                double offsetY;
                int maxValue;
                int[] minTempArray = new int[12];
                bool negativeValue = false;

                offsetY = 0; //defaults the offset to 0

                selectedLocation = globalArray[chosenLocationIndex];

                selectedYear = globalArray[chosenLocationIndex].getYearsObserved()[chosenYearIndex];

                displayMonths = selectedYear.getMonths();

                for (int n = 0; n < 12; n++)
                {

                    minTempArray[n] = Convert.ToInt32(displayMonths[n].getMinTemperature()); //assigns values into the array of min temperatures

                }

                maxValue = LinearSearch(minTempArray); //uses the LinearSearch procedure to find the highest value in the array

                multiplierY = yBoundary / maxValue; //finds the multiplier

                for (int i = 0; i < 12; i++)
                {

                    minTempValue = multiplierY * displayMonths[i].getMinTemperature(); //sets the value of the min temp for the month 

                    //checks if the value is negative
                    if (minTempValue < 0)
                    {

                        negativeValue = true; //used for label colour

                        minTempValue = Math.Abs(minTempValue); //turns the value positive

                    }

                    offsetY = Math.Round(minTempValue); //sets the offset of the bar to level the bar

                    //instantiates and edits the properties for the min temperature picturebox
                    arrayOne[i] = new PictureBox();
                    arrayOne[i].Location = new Point((825 + (i * 30)), (350 - Convert.ToInt32(offsetY)));
                    arrayOne[i].Size = new Size(25, Convert.ToInt32(minTempValue));

                    if (negativeValue == true)
                    {

                        arrayOne[i].BackColor = Color.Red;

                    }
                    else
                    {

                        arrayOne[i].BackColor = Color.LimeGreen;

                    }

                    //instantiates and edits the properties for the min temperature label
                    labelArray[i] = new Label();
                    labelArray[i].Location = new Point((827 + (i * 30)), 375);
                    labelArray[i].Text = GetMonthName(i);
                    labelArray[i].ForeColor = labelTextColour;
                    labelArray[i].BackColor = labelBackColour;
                    labelArray[i].Font = labelFont;
                    labelArray[i].Size = labelSize;

                    //adds the label and the picturebox
                    Controls.Add(arrayOne[i]);
                    Controls.Add(labelArray[i]);

                }
            }
            catch
            {
            }

        }

        public void DisplayDaysFrost()
        {
            try
            {

                //declaring all the objects that is used in displaying the max temperature
                Location selectedLocation;
                Year selectedYear;
                Month[] displayMonths;
                PictureBox[] arrayOne = new PictureBox[12];
                Label[] labelArray = new Label[12];

                //declaring variables used to get the data and display the data
                int daysFrost;
                int multiplierY;
                int offsetY;
                int maxValue;
                int[] daysFrostArray = new int[12];
                bool negativeValue = false;

                offsetY = 0; //defaults the offset to 0

                selectedLocation = globalArray[chosenLocationIndex];

                selectedYear = globalArray[chosenLocationIndex].getYearsObserved()[chosenYearIndex];

                displayMonths = selectedYear.getMonths();

                for (int n = 0; n < 12; n++)
                {

                    daysFrostArray[n] = displayMonths[n].getDaysFrost(); //assigns values into the array of days frost

                }

                maxValue = LinearSearch(daysFrostArray); //uses the LinearSearch procedure to find the highest value in the array

                multiplierY = yBoundary / maxValue; //finds the multiplier

                for (int i = 0; i < 12; i++)
                {
                    daysFrost = multiplierY * displayMonths[i].getDaysFrost(); //sets the value of the days frost for the month 

                    //checks if the value is negative
                    if (daysFrost < 0)
                    {

                        negativeValue = true; //used for label colour

                        daysFrost = Math.Abs(daysFrost); //turns the value to positive

                    }

                    offsetY = daysFrost; //sets the offset of the bar to level the bar

                    //instantiates and edits the properties for the days frost picturebox
                    arrayOne[i] = new PictureBox();
                    arrayOne[i].Location = new Point((25 + (i * 30)), (750 - offsetY));
                    arrayOne[i].Size = new Size(25, daysFrost);

                    if (negativeValue == true)
                    {

                        arrayOne[i].BackColor = Color.Red;

                    }
                    else
                    {

                        arrayOne[i].BackColor = Color.LimeGreen;

                    }

                    //instantiates and edits the properties for the days frost label
                    labelArray[i] = new Label();
                    labelArray[i].Location = new Point((27 + (i * 30)), 775);
                    labelArray[i].Text = GetMonthName(i);
                    labelArray[i].ForeColor = labelTextColour;
                    labelArray[i].BackColor = labelBackColour;
                    labelArray[i].Font = labelFont;
                    labelArray[i].Size = labelSize;

                    //adds the label and the picturebox
                    Controls.Add(arrayOne[i]);
                    Controls.Add(labelArray[i]);

                }
            }
            catch
            {
            }
        }

        public void DisplayRainfall()
        {

            try
            {
                //declaring all the objects that is used in displaying the max temperature
                Location selectedLocation;
                Year selectedYear;
                Month[] displayMonths;
                PictureBox[] arrayOne = new PictureBox[12];
                Label[] labelArray = new Label[12];

                //declaring variables used to get the data and display the data
                double rainfall;
                int multiplierY;
                int offsetY;
                int maxValue;
                int[] rainfallArray = new int[12];
                bool negativeValue = false;

                offsetY = 0; //defaults the offset to 0

                selectedLocation = globalArray[chosenLocationIndex];

                selectedYear = globalArray[chosenLocationIndex].getYearsObserved()[chosenYearIndex];

                displayMonths = selectedYear.getMonths();

                for (int n = 0; n < 12; n++)
                {

                    rainfallArray[n] = Convert.ToInt32(displayMonths[n].getRainfall()); //assigns values into the array of rainfall

                }

                maxValue = LinearSearch(rainfallArray); //uses the LinearSearch procedure to find the highest value in the array

                multiplierY = yBoundary / maxValue; //finds the multiplier

                for (int i = 0; i < 12; i++)
                {
                    rainfall = multiplierY * displayMonths[i].getRainfall(); //sets the value of the rainfall for the month 

                    //checks if the value is negative
                    if (rainfall < 0)
                    {

                        negativeValue = true; //used for label colour

                        rainfall = Math.Abs(rainfall); //turns the value positive

                    }

                    offsetY = Convert.ToInt32(rainfall); //sets the offset of the bar to level the bar

                    //instantiates and edits the properties for the rainfall picturebox
                    arrayOne[i] = new PictureBox();
                    arrayOne[i].Location = new Point((425 + (i * 30)), (750 - offsetY));
                    arrayOne[i].Size = new Size(25, Convert.ToInt32(rainfall));

                    if (negativeValue == true)
                    {

                        arrayOne[i].BackColor = Color.Red;

                    }
                    else
                    {

                        arrayOne[i].BackColor = Color.LimeGreen;

                    }

                    //instantiates and edits the properties for the rainfall label
                    labelArray[i] = new Label();
                    labelArray[i].Location = new Point((427 + (i * 30)), 775);
                    labelArray[i].Text = GetMonthName(i);
                    labelArray[i].ForeColor = labelTextColour;
                    labelArray[i].BackColor = labelBackColour;
                    labelArray[i].Font = labelFont;
                    labelArray[i].Size = labelSize;

                    //adds the label and the picturebox
                    Controls.Add(arrayOne[i]);
                    Controls.Add(labelArray[i]);

                }
            }
            catch
            {
            }
        }

        public void DisplaySunshine()
        {

            try
            {

                //declaring all the objects that is used in displaying the max temperature
                Location selectedLocation;
                Year selectedYear;
                Month[] displayMonths;
                PictureBox[] arrayOne = new PictureBox[12];
                Label[] labelArray = new Label[12];

                //declaring variables used to get the data and display the data
                int sunshine;
                int multiplierY;
                int offsetY = 0;
                int maxValue;
                int[] sunshineArray = new int[12];
                bool negativeValue = false;

                selectedLocation = globalArray[chosenLocationIndex];

                selectedYear = globalArray[chosenLocationIndex].getYearsObserved()[chosenYearIndex];

                displayMonths = selectedYear.getMonths();

                for (int n = 0; n < 12; n++)
                {
                    sunshineArray[n] = Convert.ToInt32(displayMonths[n].getSunshine()); //assigns values into the array of sunshine
                }

                maxValue = LinearSearch(sunshineArray); //uses the LinearSearch procedure to find the highest value in the array

                multiplierY = yBoundary / maxValue; //finds the multiplier

                for (int i = 0; i < 12; i++)
                {
                    sunshine = multiplierY * Convert.ToInt32(displayMonths[i].getSunshine());  //sets the value of the sunshine for the month 

                    //checks if the value is negative
                    if (sunshine < 0)
                    {

                        negativeValue = true; //used for label colour

                        sunshine = Math.Abs(sunshine); //turns the value positive

                    }

                    offsetY = sunshine; //sets the offset of the bar to level the bar

                    //instantiates and edits the properties for the sunshine picturebox
                    arrayOne[i] = new PictureBox();
                    arrayOne[i].Location = new Point((825 + (i * 30)), (750 - offsetY));
                    arrayOne[i].Size = new Size(25, sunshine);

                    if (negativeValue == true)
                    {

                        arrayOne[i].BackColor = Color.Red;

                    }
                    else
                    {

                        arrayOne[i].BackColor = Color.LimeGreen;

                    }

                    //instantiates and edits the properties for the sunshine label
                    labelArray[i] = new Label();
                    labelArray[i].Location = new Point((827 + (i * 30)), 775);
                    labelArray[i].Text = GetMonthName(i);
                    labelArray[i].ForeColor = labelTextColour;
                    labelArray[i].BackColor = labelBackColour;
                    labelArray[i].Font = labelFont;
                    labelArray[i].Size = labelSize;

                    //adds the label and the picturebox
                    Controls.Add(arrayOne[i]);
                    Controls.Add(labelArray[i]);

                }
            }
            catch
            {
            }

        }

        //a procedure that searches through all of the elements in the array
        public int LinearSearch(int[] _numberArray)
        {

            int[] arraySearch; //will store the integers that will be searched through

            //declares the variables used in the linear search
            int maxValue;
            int arrayLength;

            maxValue = 0; //defaults the max value to 0

            arraySearch = _numberArray;

            arrayLength = arraySearch.Length;

            for (int x = 0; x < arrayLength; x++) //loops through all of the elements in the array
            {
                if (arraySearch[x] > maxValue) //checks if the value in the array is larger than the current max value
                {

                    maxValue = arraySearch[x]; //changes the value to the bigger value

                }
                else
                {
                    //do nothing
                }
            }

            return maxValue; //returns the max value

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DataForm showForm = new DataForm();

            //closes this form
            this.Close();

        }

        public string GetMonthName(int _monthIndex)
        {

            //declares the variables used in retrieving and displaying the month names
            int monthIndex;
            string monthOutput;

            monthOutput = ""; //defaults the value of the output to an empty string

            monthIndex = _monthIndex + 1;

            switch (monthIndex) //switch statement to go through all the values of monthIndex
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

            return monthOutput; //returns the string containing the name of the month

        }

        private void predictButton_Click(object sender, EventArgs e)
        {

            if (radioCheck == false) //checks if a radiobutton has not been clicked
            {
                MessageBox.Show("You have not selected a month property"); //warns a user they need to select a radio button
            }
            else if (radioCheck == true) //checks if a radiobutton has been clicked
            {

                PredictionService loadForm = new PredictionService(chosenLocationIndex, chosenYearIndex, radioChoice); //creates an object to load a form

                loadForm.Show(); //shows the form

            }
            else
            {

                MessageBox.Show("ERROR"); //returns an error if there is uncertainty in the value of boolean - robustness

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            //sets the value for the radio choice - to be used in another form and changes the check to true
            radioChoice = 0;
            radioCheck = true;


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            //sets the value for the radio choice - to be used in another form and changes the check to true
            radioChoice = 1;
            radioCheck = true;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            //sets the value for the radio choice - to be used in another form and changes the check to true
            radioChoice = 2;
            radioCheck = true;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            //sets the value for the radio choice - to be used in another form and changes the check to true
            radioChoice = 3;
            radioCheck = true;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

            //sets the value for the radio choice - to be used in another form and changes the check to true
            radioChoice = 4;
            radioCheck = true;

        }

        public void DisplayError()
        {

                MessageBox.Show("ERROR: Have you updated the file?");

        }

    }
}
