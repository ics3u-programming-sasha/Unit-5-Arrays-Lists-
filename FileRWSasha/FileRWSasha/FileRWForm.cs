/*
 * Created by: Sasha Malko
 * Created on: 4-Dec-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #41 - File Read/Write
 * This program reads the input file called "input.txt", compares the strings on each line to see if
 * they are the same or not (ignoring case), and generates another file called "output.txt" with 
 * "True" or "False" corresponding to the output of the function. 
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

namespace FileRWSasha
{
    public partial class FileRWForm : Form
    {
        public FileRWForm()
        {
            InitializeComponent();
            this.lblOutput.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Read each line of the file into a string array. Each element 
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            // array of characters that I want to take out when I split the line into words (spaces, tabs)
            char[] charSeparators = new char[] { ' ', '\t' };

            // the output string where I will put my results
            string output = "";

            // go through and compare each string on each line of the file
            foreach (string line in lines)
            {
                // split each line into words and put them into an array. I am assuming there are only
                // two words on the line.
                string[] words = line.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

                if (StringsAreEqual(words[0], words[1]) == true)
                {
                    // concatenate the output to the string. There must be \r\n so that it goes onto a new line in the text file.
                    output = output + "True\r\n";
                }
                else
                {
                    // concatenate the output to the string. There must be \r\n so that it goes onto a new line in the text file.
                    output = output + "False\r\n";
                }
            }

            // WriteAllText creates a file, writes the specified string to the file, 
            // and then closes the file. You do NOT need to call Flush() or Close().
            // If the file already exists, it overwrites the file.
            System.IO.File.WriteAllText(@"output.txt", output);

            // show the label notifying the user that the process is done
            this.lblOutput.Show();
        }

        // Function: StringsAreEqual
        // Input: string string1, string string2
        // Output: bool
        // Description: This function checks if the two given strings are equal without considering cases. 
        private bool StringsAreEqual(string string1, string string2)
        {
            // set the boolean variable equal to false
            bool isEqual = false;

            // declare local variables;
            int stringLength1, stringLength2;

            // get the lengths of the strings
            stringLength1 = string1.Length;
            stringLength2 = string2.Length;

            // check if the strings are equal in length
            if (stringLength1 == stringLength2)
            {
                // declare local variables
                string stringCase1, stringCase2;

                // convert the strings to uppercase
                stringCase1 = string1.ToUpper();
                stringCase2 = string2.ToUpper();

                // check if the strings are equal without considering cases
                if (stringCase1 == stringCase2)
                {
                    // set the boolean variable equal to true
                    isEqual = true;
                }
            }

            // return the boolean variable
            return isEqual;
        }
    }
}