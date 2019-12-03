/*
 * Created by: Sasha Malko
 * Created on: 27-Nov-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #39 - List Average
 * This program calculates the average of the values in a list.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAverageSasha
{
    public partial class frmListAverage : Form
    {
        // create an empty list of integers
        List<int> myListOfIntegers = new List<int>();

        public frmListAverage()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // declare local variables
            int userMark = -1;

            // convert the value in the textbox to an integer
            try
            {
                userMark = int.Parse(txtMark.Text);
            }
            // if the user did not enter a valid number, write the error to the command line
            catch (Exception parseError)
            {
                Console.WriteLine("An error occured: '{0}'", parseError);
            }

            // check if the user entered a number between 0 and 100
            if ((userMark >= 0) && (userMark <= 100))
            {
                // add the mark to the listbox
                this.lstMarks.Items.Add(userMark);

                // add the mark to the list
                myListOfIntegers.Add(userMark);
            }
            // otherwise, display an error
            else
            {
                MessageBox.Show("Please enter a number between 0 and 100.", "Invalid Number");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variable
            double total = 0;
            double average = 0;
            int counter;

            // calculate the average of the values in the list box
            for (counter = 0; counter < myListOfIntegers.Count(); counter++)
            {
                total = myListOfIntegers[counter] + total;
                average = total / myListOfIntegers.Count();
            }

            // display the average
            this.lblAverage.Text = "The average is: " + String.Format("{0:0.0}", average);
        }
    }
}