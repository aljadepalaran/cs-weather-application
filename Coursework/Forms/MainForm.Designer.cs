namespace Coursework
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.LoadButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MainView = new System.Windows.Forms.ListBox();
            this.locationDrop = new System.Windows.Forms.ComboBox();
            this.yearDrop = new System.Windows.Forms.ComboBox();
            this.monthDrop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.YearView = new System.Windows.Forms.ListBox();
            this.LocationView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(20, 192);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(199, 45);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "LOAD";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(225, 192);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(199, 45);
            this.DisplayButton.TabIndex = 1;
            this.DisplayButton.Text = "DISPLAY";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(430, 192);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(199, 45);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "EDIT";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(635, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "SPECIAL FEATURE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainView
            // 
            this.MainView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainView.ForeColor = System.Drawing.Color.Red;
            this.MainView.FormattingEnabled = true;
            this.MainView.ItemHeight = 24;
            this.MainView.Location = new System.Drawing.Point(627, 12);
            this.MainView.Name = "MainView";
            this.MainView.Size = new System.Drawing.Size(258, 148);
            this.MainView.TabIndex = 4;
            // 
            // locationDrop
            // 
            this.locationDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationDrop.FormattingEnabled = true;
            this.locationDrop.Location = new System.Drawing.Point(80, 31);
            this.locationDrop.Name = "locationDrop";
            this.locationDrop.Size = new System.Drawing.Size(187, 21);
            this.locationDrop.TabIndex = 5;
            this.locationDrop.SelectedIndexChanged += new System.EventHandler(this.locationDrop_SelectedIndexChanged);
            // 
            // yearDrop
            // 
            this.yearDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearDrop.FormattingEnabled = true;
            this.yearDrop.Location = new System.Drawing.Point(80, 77);
            this.yearDrop.Name = "yearDrop";
            this.yearDrop.Size = new System.Drawing.Size(187, 21);
            this.yearDrop.TabIndex = 6;
            this.yearDrop.SelectedIndexChanged += new System.EventHandler(this.yearDrop_SelectedIndexChanged);
            // 
            // monthDrop
            // 
            this.monthDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthDrop.FormattingEnabled = true;
            this.monthDrop.Location = new System.Drawing.Point(80, 123);
            this.monthDrop.Name = "monthDrop";
            this.monthDrop.Size = new System.Drawing.Size(187, 21);
            this.monthDrop.TabIndex = 7;
            this.monthDrop.SelectedIndexChanged += new System.EventHandler(this.monthDrop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Month";
            // 
            // YearView
            // 
            this.YearView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.YearView.FormattingEnabled = true;
            this.YearView.ItemHeight = 16;
            this.YearView.Location = new System.Drawing.Point(288, 123);
            this.YearView.Name = "YearView";
            this.YearView.Size = new System.Drawing.Size(325, 36);
            this.YearView.TabIndex = 11;
            // 
            // LocationView
            // 
            this.LocationView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationView.ForeColor = System.Drawing.Color.Blue;
            this.LocationView.FormattingEnabled = true;
            this.LocationView.ItemHeight = 16;
            this.LocationView.Location = new System.Drawing.Point(288, 12);
            this.LocationView.Name = "LocationView";
            this.LocationView.Size = new System.Drawing.Size(325, 100);
            this.LocationView.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 251);
            this.Controls.Add(this.LocationView);
            this.Controls.Add(this.YearView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthDrop);
            this.Controls.Add(this.yearDrop);
            this.Controls.Add(this.locationDrop);
            this.Controls.Add(this.MainView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.LoadButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Tag = "z";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox MainView;
        private System.Windows.Forms.ComboBox locationDrop;
        private System.Windows.Forms.ComboBox yearDrop;
        private System.Windows.Forms.ComboBox monthDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox YearView;
        private System.Windows.Forms.ListBox LocationView;
    }
}

