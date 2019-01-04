namespace Coursework
{
    partial class PredictionService
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
            this.locationContainer = new System.Windows.Forms.ListBox();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // locationContainer
            // 
            this.locationContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.locationContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationContainer.ForeColor = System.Drawing.Color.LimeGreen;
            this.locationContainer.FormattingEnabled = true;
            this.locationContainer.Location = new System.Drawing.Point(22, 52);
            this.locationContainer.Name = "locationContainer";
            this.locationContainer.Size = new System.Drawing.Size(177, 249);
            this.locationContainer.TabIndex = 0;
            this.locationContainer.SelectedIndexChanged += new System.EventHandler(this.locationContainer_SelectedIndexChanged);
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Location = new System.Drawing.Point(22, 12);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(177, 20);
            this.searchBar.TabIndex = 31;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButton1.FlatAppearance.BorderSize = 5;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.radioButton1.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButton1.Location = new System.Drawing.Point(49, 324);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 17);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Max Temperature";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButton2.FlatAppearance.BorderSize = 5;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.radioButton2.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButton2.Location = new System.Drawing.Point(49, 347);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 17);
            this.radioButton2.TabIndex = 33;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Min Temperature";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButton3.FlatAppearance.BorderSize = 5;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.radioButton3.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButton3.Location = new System.Drawing.Point(49, 370);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 17);
            this.radioButton3.TabIndex = 34;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Days Frosted";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButton4.FlatAppearance.BorderSize = 5;
            this.radioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.radioButton4.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButton4.Location = new System.Drawing.Point(49, 393);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 17);
            this.radioButton4.TabIndex = 35;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Rainfall";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButton5.FlatAppearance.BorderSize = 5;
            this.radioButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.radioButton5.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButton5.Location = new System.Drawing.Point(49, 416);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(69, 17);
            this.radioButton5.TabIndex = 36;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Sunshine";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // PredictionService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.locationContainer);
            this.Name = "PredictionService";
            this.Text = "PredictionService";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PredictionService_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox locationContainer;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}