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

            DataForm loadForm = new DataForm();

            this.Hide();

            loadForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
