﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 

namespace ListTest
{
    
    public partial class Form1 : Form
    {
        //a string list to hold student names
        
        public Form1()
        {
            InitializeComponent();
        }
         
        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            originalOutput.Text = $"Original ------\n\n";


        }

    }
}
