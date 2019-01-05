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
        public Main()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            DataForm loadForm = new DataForm(); //creates a way to access the form

            this.Hide(); //hides the current form

            loadForm.Show(); //shows the main form (dataForm)

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit(); //exits if the user click quit

        }
    }
}
