﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateNewe_20160509
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ReturnDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ReturnDateTimePicker2.MinDate > DepartureDateTimePicker1.MinDate)
                {
                    MessageBox.Show("Selected date is OK!!!");
                }
                else
                    MessageBox.Show("Please select a valid date that is after the Departure!");
            }
            catch
            {
                //
            }
        }
    }
}
