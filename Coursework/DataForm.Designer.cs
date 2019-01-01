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
            this.addFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(385, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(221, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Year";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.locationLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.locationLabel.Location = new System.Drawing.Point(31, 13);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(117, 31);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Location";
            // 
            // chooseMonth
            // 
            this.chooseMonth.FormattingEnabled = true;
            this.chooseMonth.Location = new System.Drawing.Point(346, 47);
            this.chooseMonth.Name = "chooseMonth";
            this.chooseMonth.Size = new System.Drawing.Size(161, 368);
            this.chooseMonth.TabIndex = 8;
            this.chooseMonth.SelectedIndexChanged += new System.EventHandler(this.chooseMonth_SelectedIndexChanged);
            // 
            // chooseYear
            // 
            this.chooseYear.FormattingEnabled = true;
            this.chooseYear.Location = new System.Drawing.Point(179, 47);
            this.chooseYear.Name = "chooseYear";
            this.chooseYear.Size = new System.Drawing.Size(161, 368);
            this.chooseYear.TabIndex = 7;
            this.chooseYear.SelectedIndexChanged += new System.EventHandler(this.chooseYear_SelectedIndexChanged);
            // 
            // chooseLocation
            // 
            this.chooseLocation.FormattingEnabled = true;
            this.chooseLocation.Location = new System.Drawing.Point(12, 47);
            this.chooseLocation.Name = "chooseLocation";
            this.chooseLocation.Size = new System.Drawing.Size(161, 368);
            this.chooseLocation.TabIndex = 6;
            this.chooseLocation.SelectedIndexChanged += new System.EventHandler(this.chooseLocation_SelectedIndexChanged);
            // 
            // monthBox
            // 
            this.monthBox.Location = new System.Drawing.Point(631, 47);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(100, 20);
            this.monthBox.TabIndex = 12;
            // 
            // maxTempBox
            // 
            this.maxTempBox.Location = new System.Drawing.Point(631, 73);
            this.maxTempBox.Name = "maxTempBox";
            this.maxTempBox.Size = new System.Drawing.Size(100, 20);
            this.maxTempBox.TabIndex = 13;
            // 
            // minTempBox
            // 
            this.minTempBox.Location = new System.Drawing.Point(631, 99);
            this.minTempBox.Name = "minTempBox";
            this.minTempBox.Size = new System.Drawing.Size(100, 20);
            this.minTempBox.TabIndex = 14;
            // 
            // daysFrostBox
            // 
            this.daysFrostBox.Location = new System.Drawing.Point(631, 125);
            this.daysFrostBox.Name = "daysFrostBox";
            this.daysFrostBox.Size = new System.Drawing.Size(100, 20);
            this.daysFrostBox.TabIndex = 15;
            // 
            // rainfallBox
            // 
            this.rainfallBox.Location = new System.Drawing.Point(631, 151);
            this.rainfallBox.Name = "rainfallBox";
            this.rainfallBox.Size = new System.Drawing.Size(100, 20);
            this.rainfallBox.TabIndex = 16;
            // 
            // sunshineBox
            // 
            this.sunshineBox.Location = new System.Drawing.Point(631, 177);
            this.sunshineBox.Name = "sunshineBox";
            this.sunshineBox.Size = new System.Drawing.Size(100, 20);
            this.sunshineBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "MonthID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Max. Temp.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Min. Temp.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Days Frost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Rainfall";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(574, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Sunshine";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(533, 251);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(92, 35);
            this.submitButton.TabIndex = 24;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // addYearButton
            // 
            this.addYearButton.Location = new System.Drawing.Point(533, 292);
            this.addYearButton.Name = "addYearButton";
            this.addYearButton.Size = new System.Drawing.Size(92, 35);
            this.addYearButton.TabIndex = 25;
            this.addYearButton.Text = "Add Year";
            this.addYearButton.UseVisualStyleBackColor = true;
            // 
            // addLocationButton
            // 
            this.addLocationButton.Location = new System.Drawing.Point(533, 333);
            this.addLocationButton.Name = "addLocationButton";
            this.addLocationButton.Size = new System.Drawing.Size(92, 35);
            this.addLocationButton.TabIndex = 26;
            this.addLocationButton.Text = "Add Location";
            this.addLocationButton.UseVisualStyleBackColor = true;
            // 
            // addFile
            // 
            this.addFile.Location = new System.Drawing.Point(673, 292);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(75, 23);
            this.addFile.TabIndex = 27;
            this.addFile.Text = "addtofile";
            this.addFile.UseVisualStyleBackColor = true;
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.addFile);
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
        private System.Windows.Forms.Button addFile;
    }
}