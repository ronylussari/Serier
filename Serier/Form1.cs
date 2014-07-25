using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Serier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("Series.xml"))
            {

            }
            else
            {

            }
        }

        private void series1Search_Click(object sender, EventArgs e)
        {

        }
    }
}
