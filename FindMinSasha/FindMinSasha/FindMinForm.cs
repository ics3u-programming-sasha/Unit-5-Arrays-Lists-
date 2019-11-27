﻿/*
 * Created by: Sasha Malko
 * Created on: 26-Nov-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #38 - Find Min Value
 * This program displays 10 random numbers from an array and shows the smallest number in the array. 
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

namespace FindMinSasha
{
    public partial class frmFindMin : Form
    {
        public frmFindMin()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, minValue;
            Random randomNumberGenerator = new Random();

            // clear list box
            this.lstValues.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generate a new random number between 1 and the MAX_ARRAY_SIZE
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER + 1);

                // assign the random number to cell at position "counter" in the array
                arrayOfIntegers[counter] = randomNumber;

                // add the random number to the list
                this.lstValues.Items.Add(randomNumber);

                // refresh the form to display the new item in the list box
                this.Refresh();
            }

            // get the min value in the array
            minValue = GetMinValue(arrayOfIntegers);

            // display the min value in the label
            this.lblMin.Text = "The min value is: " + minValue;
        }

        // Function: GetMinValue
        // Input: int[] tmpArrayOfIntegers
        // Output: The min value in the array
        // Description: This function accepts an array of integers, 
        // scans the array and returns the smallest value in the array.
        private int GetMinValue(int[] tmpArrayOfIntegers)
        {
            // declare local variables
            int tmpMinValue = 501;
            int counter;

            // if the counter is less than the length of tmpArrayOfIntegers
            for (counter = 0; counter < tmpArrayOfIntegers.Length; counter++)
            {
                // if tmpMaxValue is greater than the tmpArrayOfIntegers(counter)
                if (tmpMinValue > tmpArrayOfIntegers[counter])
                {
                    // set the tmpMaxValue to the tmpArrayOfIntegers[counter]
                    tmpMinValue = tmpArrayOfIntegers[counter];
                }
            }

            // return the tmpMinValue
            return tmpMinValue;
        }
    }
}