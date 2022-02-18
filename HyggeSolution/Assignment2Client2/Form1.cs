using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment2Client2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileOne_Click(object sender, EventArgs e)
        {

            string path = txtBoxPath + "//" + btnFileOne.Text;
            if (File.Exists(path))
            {
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                MessageBox.Show("The file was not found!");




            }
        }
    }
}


