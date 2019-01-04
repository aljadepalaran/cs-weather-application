namespace Coursework
{
    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.chooseMonth = new System.Windows.Forms.ListBox();
            this.chooseYear = new System.Windows.Forms.ListBox();
            this.chooseLocation = new System.Windows.Forms.ListBox();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.maxTempBox = new System.Windows.Forms.TextBox();
            this.minTempBox = new System.Windows.Forms.TextBox();
            this.daysFrostBox = new System.Windows.Forms.TextBox();
            this.rainfallBox = new System.Windows.Forms.TextBox();
            this.sunshineBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.addYearButton = new System.Windows.Forms.Button();
            this.addLocationButton = new System.Windows.Forms.Button();
            this.countyBox = new System.Windows.Forms.TextBox();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.locationNameBox = new System.Windows.Forms.TextBox();
            this.postcodeBox = new System.Windows.Forms.TextBox();
            this.latitudeBox = new System.Windows.Forms.TextBox();
            this.longitudeBox = new System.Windows.Forms.TextBox();
            this.locationNameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.yearDescriptionBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.graphButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(45, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(220, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Year";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.locationLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.locationLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.locationLabel.Location = new System.Drawing.Point(31, 3);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(117, 31);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Location";
            // 
            // chooseMonth
            // 
            this.chooseMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chooseMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chooseMonth.FormattingEnabled = true;
            this.chooseMonth.Location = new System.Drawing.Point(12, 255);
            this.chooseMonth.Name = "chooseMonth";
            this.chooseMonth.Size = new System.Drawing.Size(161, 171);
            this.chooseMonth.TabIndex = 8;
            this.chooseMonth.SelectedIndexChanged += new System.EventHandler(this.chooseMonth_SelectedIndexChanged);
            // 
            // chooseYear
            // 
            this.chooseYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chooseYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chooseYear.FormattingEnabled = true;
            this.chooseYear.Location = new System.Drawing.Point(179, 34);
            this.chooseYear.Name = "chooseYear";
            this.chooseYear.Size = new System.Drawing.Size(161, 392);
            this.chooseYear.TabIndex = 7;
            this.chooseYear.SelectedIndexChanged += new System.EventHandler(this.chooseYear_SelectedIndexChanged);
            // 
            // chooseLocation
            // 
            this.chooseLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chooseLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chooseLocation.FormattingEnabled = true;
            this.chooseLocation.Location = new System.Drawing.Point(12, 34);
            this.chooseLocation.Name = "chooseLocation";
            this.chooseLocation.Size = new System.Drawing.Size(161, 184);
            this.chooseLocation.TabIndex = 6;
            this.chooseLocation.SelectedIndexChanged += new System.EventHandler(this.chooseLocation_SelectedIndexChanged);
            // 
            // monthBox
            // 
            this.monthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.monthBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthBox.Location = new System.Drawing.Point(430, 247);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(68, 20);
            this.monthBox.TabIndex = 12;
            // 
            // maxTempBox
            // 
            this.maxTempBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxTempBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTempBox.Location = new System.Drawing.Point(430, 273);
            this.maxTempBox.Name = "maxTempBox";
            this.maxTempBox.Size = new System.Drawing.Size(68, 20);
            this.maxTempBox.TabIndex = 13;
            // 
            // minTempBox
            // 
            this.minTempBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minTempBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minTempBox.Location = new System.Drawing.Point(430, 299);
            this.minTempBox.Name = "minTempBox";
            this.minTempBox.Size = new System.Drawing.Size(68, 20);
            this.minTempBox.TabIndex = 14;
            // 
            // daysFrostBox
            // 
            this.daysFrostBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.daysFrostBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daysFrostBox.Location = new System.Drawing.Point(430, 325);
            this.daysFrostBox.Name = "daysFrostBox";
            this.daysFrostBox.Size = new System.Drawing.Size(68, 20);
            this.daysFrostBox.TabIndex = 15;
            // 
            // rainfallBox
            // 
            this.rainfallBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rainfallBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rainfallBox.Location = new System.Drawing.Point(430, 351);
            this.rainfallBox.Name = "rainfallBox";
            this.rainfallBox.Size = new System.Drawing.Size(68, 20);
            this.rainfallBox.TabIndex = 16;
            // 
            // sunshineBox
            // 
            this.sunshineBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sunshineBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sunshineBox.Location = new System.Drawing.Point(430, 377);
            this.sunshineBox.Name = "sunshineBox";
            this.sunshineBox.Size = new System.Drawing.Size(68, 20);
            this.sunshineBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(376, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "MonthID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(364, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Max. Temp.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(364, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Min. Temp.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(367, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Days Frost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(382, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Rainfall";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Location = new System.Drawing.Point(373, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Sunshine";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.submitButton.Location = new System.Drawing.Point(647, 326);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(76, 45);
            this.submitButton.TabIndex = 24;
            this.submitButton.Text = "Submit Changes";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // addYearButton
            // 
            this.addYearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addYearButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addYearButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.addYearButton.Location = new System.Drawing.Point(647, 274);
            this.addYearButton.Name = "addYearButton";
            this.addYearButton.Size = new System.Drawing.Size(76, 45);
            this.addYearButton.TabIndex = 25;
            this.addYearButton.Text = "Add Year";
            this.addYearButton.UseVisualStyleBackColor = false;
            this.addYearButton.Click += new System.EventHandler(this.addYearButton_Click);
            // 
            // addLocationButton
            // 
            this.addLocationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addLocationButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLocationButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.addLocationButton.Location = new System.Drawing.Point(565, 326);
            this.addLocationButton.Name = "addLocationButton";
            this.addLocationButton.Size = new System.Drawing.Size(76, 45);
            this.addLocationButton.TabIndex = 26;
            this.addLocationButton.Text = "Add Location";
            this.addLocationButton.UseVisualStyleBackColor = false;
            this.addLocationButton.Click += new System.EventHandler(this.addLocationButton_Click);
            // 
            // countyBox
            // 
            this.countyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.countyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countyBox.Location = new System.Drawing.Point(430, 90);
            this.countyBox.Name = "countyBox";
            this.countyBox.Size = new System.Drawing.Size(344, 20);
            this.countyBox.TabIndex = 28;
            // 
            // streetBox
            // 
            this.streetBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.streetBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.streetBox.Location = new System.Drawing.Point(430, 67);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(344, 20);
            this.streetBox.TabIndex = 29;
            // 
            // locationNameBox
            // 
            this.locationNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.locationNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationNameBox.Location = new System.Drawing.Point(430, 41);
            this.locationNameBox.Name = "locationNameBox";
            this.locationNameBox.Size = new System.Drawing.Size(344, 20);
            this.locationNameBox.TabIndex = 30;
            // 
            // postcodeBox
            // 
            this.postcodeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.postcodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postcodeBox.Location = new System.Drawing.Point(430, 116);
            this.postcodeBox.Name = "postcodeBox";
            this.postcodeBox.Size = new System.Drawing.Size(100, 20);
            this.postcodeBox.TabIndex = 31;
            // 
            // latitudeBox
            // 
            this.latitudeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.latitudeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latitudeBox.Location = new System.Drawing.Point(430, 142);
            this.latitudeBox.Name = "latitudeBox";
            this.latitudeBox.Size = new System.Drawing.Size(100, 20);
            this.latitudeBox.TabIndex = 32;
            // 
            // longitudeBox
            // 
            this.longitudeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.longitudeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.longitudeBox.Location = new System.Drawing.Point(430, 168);
            this.longitudeBox.Name = "longitudeBox";
            this.longitudeBox.Size = new System.Drawing.Size(100, 20);
            this.longitudeBox.TabIndex = 33;
            // 
            // locationNameLabel
            // 
            this.locationNameLabel.AutoSize = true;
            this.locationNameLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.locationNameLabel.Location = new System.Drawing.Point(389, 44);
            this.locationNameLabel.Name = "locationNameLabel";
            this.locationNameLabel.Size = new System.Drawing.Size(35, 13);
            this.locationNameLabel.TabIndex = 34;
            this.locationNameLabel.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.LimeGreen;
            this.label9.Location = new System.Drawing.Point(389, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Street";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.LimeGreen;
            this.label10.Location = new System.Drawing.Point(384, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "County";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.LimeGreen;
            this.label11.Location = new System.Drawing.Point(372, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Postcode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.LimeGreen;
            this.label12.Location = new System.Drawing.Point(379, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Latitude";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.LimeGreen;
            this.label13.Location = new System.Drawing.Point(370, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Longitude";
            // 
            // yearBox
            // 
            this.yearBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearBox.Location = new System.Drawing.Point(430, 194);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(68, 20);
            this.yearBox.TabIndex = 40;
            // 
            // yearDescriptionBox
            // 
            this.yearDescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yearDescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearDescriptionBox.Location = new System.Drawing.Point(430, 220);
            this.yearDescriptionBox.Name = "yearDescriptionBox";
            this.yearDescriptionBox.Size = new System.Drawing.Size(344, 20);
            this.yearDescriptionBox.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.LimeGreen;
            this.label14.Location = new System.Drawing.Point(395, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Year";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.LimeGreen;
            this.label15.Location = new System.Drawing.Point(364, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Description";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.updateButton.Location = new System.Drawing.Point(565, 274);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(76, 45);
            this.updateButton.TabIndex = 44;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // graphButton
            // 
            this.graphButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.graphButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.graphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.graphButton.Location = new System.Drawing.Point(565, 377);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(76, 45);
            this.graphButton.TabIndex = 45;
            this.graphButton.Text = "Visualise";
            this.graphButton.UseVisualStyleBackColor = false;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(799, 441);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.yearDescriptionBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.locationNameLabel);
            this.Controls.Add(this.longitudeBox);
            this.Controls.Add(this.latitudeBox);
            this.Controls.Add(this.postcodeBox);
            this.Controls.Add(this.locationNameBox);
            this.Controls.Add(this.streetBox);
            this.Controls.Add(this.countyBox);
            this.Controls.Add(this.addLocationButton);
            this.Controls.Add(this.addYearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sunshineBox);
            this.Controls.Add(this.rainfallBox);
            this.Controls.Add(this.daysFrostBox);
            this.Controls.Add(this.minTempBox);
            this.Controls.Add(this.maxTempBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.chooseMonth);
            this.Controls.Add(this.chooseYear);
            this.Controls.Add(this.chooseLocation);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.ListBox chooseMonth;
        private System.Windows.Forms.ListBox chooseYear;
        private System.Windows.Forms.ListBox chooseLocation;
        private System.Windows.Forms.TextBox monthBox;
        private System.Windows.Forms.TextBox maxTempBox;
        private System.Windows.Forms.TextBox minTempBox;
        private System.Windows.Forms.TextBox daysFrostBox;
        private System.Windows.Forms.TextBox rainfallBox;
        private System.Windows.Forms.TextBox sunshineBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button addYearButton;
        private System.Windows.Forms.Button addLocationButton;
        private System.Windows.Forms.TextBox countyBox;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.TextBox locationNameBox;
        private System.Windows.Forms.TextBox postcodeBox;
        private System.Windows.Forms.TextBox latitudeBox;
        private System.Windows.Forms.TextBox longitudeBox;
        private System.Windows.Forms.Label locationNameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox yearDescriptionBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button graphButton;
    }
}