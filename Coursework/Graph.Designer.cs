namespace Coursework
{
    partial class Graph
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
            this.backButton = new System.Windows.Forms.Button();
            this.predictButton = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.backButton.Location = new System.Drawing.Point(32, 33);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(137, 45);
            this.backButton.TabIndex = 27;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // predictButton
            // 
            this.predictButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.predictButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.predictButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.predictButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.predictButton.Location = new System.Drawing.Point(175, 33);
            this.predictButton.Name = "predictButton";
            this.predictButton.Size = new System.Drawing.Size(137, 45);
            this.predictButton.TabIndex = 28;
            this.predictButton.Text = "Predict Weather";
            this.predictButton.UseVisualStyleBackColor = false;
            this.predictButton.Click += new System.EventHandler(this.predictButton_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButton5.FlatAppearance.BorderSize = 5;
            this.radioButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.radioButton5.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButton5.Location = new System.Drawing.Point(114, 216);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(69, 17);
            this.radioButton5.TabIndex = 41;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Sunshine";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButton4.FlatAppearance.BorderSize = 5;
            this.radioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.radioButton4.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButton4.Location = new System.Drawing.Point(114, 193);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 17);
            this.radioButton4.TabIndex = 40;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Rainfall";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButton3.FlatAppearance.BorderSize = 5;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.radioButton3.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButton3.Location = new System.Drawing.Point(114, 170);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 17);
            this.radioButton3.TabIndex = 39;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Days Frosted";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButton2.FlatAppearance.BorderSize = 5;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.radioButton2.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButton2.Location = new System.Drawing.Point(114, 147);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 17);
            this.radioButton2.TabIndex = 38;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Min Temperature";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButton1.FlatAppearance.BorderSize = 5;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.radioButton1.ForeColor = System.Drawing.Color.LimeGreen;
            this.radioButton1.Location = new System.Drawing.Point(114, 124);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 17);
            this.radioButton1.TabIndex = 37;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Max Temperature";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1194, 801);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.predictButton);
            this.Controls.Add(this.backButton);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.MaximumSize = new System.Drawing.Size(1210, 840);
            this.MinimumSize = new System.Drawing.Size(1210, 840);
            this.Name = "Graph";
            this.Text = "Graph";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Graph_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button predictButton;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}