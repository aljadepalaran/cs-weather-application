namespace Coursework.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.chooseLocation = new System.Windows.Forms.ListBox();
            this.chooseYear = new System.Windows.Forms.ListBox();
            this.chooseMonth = new System.Windows.Forms.ListBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chooseLocation
            // 
            resources.ApplyResources(this.chooseLocation, "chooseLocation");
            this.chooseLocation.FormattingEnabled = true;
            this.chooseLocation.Name = "chooseLocation";
            // 
            // chooseYear
            // 
            resources.ApplyResources(this.chooseYear, "chooseYear");
            this.chooseYear.FormattingEnabled = true;
            this.chooseYear.Name = "chooseYear";
            // 
            // chooseMonth
            // 
            resources.ApplyResources(this.chooseMonth, "chooseMonth");
            this.chooseMonth.FormattingEnabled = true;
            this.chooseMonth.Name = "chooseMonth";
            // 
            // locationLabel
            // 
            resources.ApplyResources(this.locationLabel, "locationLabel");
            this.locationLabel.Name = "locationLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // DataForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.chooseMonth);
            this.Controls.Add(this.chooseYear);
            this.Controls.Add(this.chooseLocation);
            this.Name = "DataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox chooseLocation;
        private System.Windows.Forms.ListBox chooseYear;
        private System.Windows.Forms.ListBox chooseMonth;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}