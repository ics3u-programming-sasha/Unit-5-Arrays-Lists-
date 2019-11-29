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
        public frmListAverage()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            int userMark = -1;

            try
            {
                userMark = int.Parse(txtMark.Text);
            }
            catch (Exception parseError)
            {
                Console.WriteLine("An error occured: '{0}'", parseError);
            }

            if ((userMark >= 0) && (userMark <= 100))
            {
                this.lstMarks.Items.Add(userMark);
                myListOfIntegers.Add(userMark);
            }
            else
            {
                MessageBox.Show("Please enter a number 0 and 100.", "Invalid Number");
            }
        }
    }
}
