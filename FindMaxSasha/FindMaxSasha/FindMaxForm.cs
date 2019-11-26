using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMaxSasha
{
    public partial class frmFindMax : Form
    {

        public frmFindMax()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, maxValue;
            Random randomNumberGenerator = new Random();

            // clear list box
            this.lstValues.Items.Clear();

            for (counter = 0; counter < MAX_RANDOM_NUMBER; counter++)
            {
                // generate a new random number between 1 and the MAX_ARRAY_SIZE
                randomNumber = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE + 1);

                // assign the random number to cell at position "counter" in the array
                arrayOfIntegers[counter] = randomNumber;

                // add the random number to the list
                this.lstValues.Items.Add(randomNumber);

                // refresh the form to display the new item in the list box
                this.Refresh();
            }

            maxValue = GetMaxValue(arrayOfIntegers);
            this.lblMax.Text = "The max value is: " + maxValue; 
        }

        private int GetMaxValue(int[] tmpArrayOfIntegers)
        {
            int tmpMaxValue = -1;
            int counter;

            for (counter = 0; counter < 10; counter++)
            {
                if (tmpMaxValue > tmpArrayOfIntegers[counter])
                {
                    tmpMaxValue = tmpArrayOfIntegers[counter];
                }
            }
            return tmpMaxValue;
        }
    }
}
