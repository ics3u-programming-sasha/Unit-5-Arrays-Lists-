/*
 * Created by: Sasha Malko
 * Created on: 3-Dec-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #40 - Deal Card
 * This program displays a random card from a deck of 52 cards with no repeats once the user clicks on a picture box. 
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

namespace DealCardSasha
{
    public partial class frmDealCard : Form
    {
        public frmDealCard()
        {
            InitializeComponent();

            // call NewDeck
            NewDeck();
        }

        // declare variables
        Random randNum = new Random();
        int randomNumber;
        List<Image> listCardImages = new List<Image>();

        // Procedure: NewDeck
        // Input: None
        // Output: void
        // Description: This procedues populates a list with images of cards.
        private void NewDeck()
        {
            listCardImages.Insert(0, Properties.Resources.AceC);
            listCardImages.Insert(1, Properties.Resources.AceH);
            listCardImages.Insert(2, Properties.Resources.AceD);
            listCardImages.Insert(3, Properties.Resources.AceS);

            listCardImages.Insert(4, Properties.Resources.TwoC);
            listCardImages.Insert(5, Properties.Resources.TwoH);
            listCardImages.Insert(6, Properties.Resources.TwoD);
            listCardImages.Insert(7, Properties.Resources.TwoS);

            listCardImages.Insert(8, Properties.Resources.ThreeC);
            listCardImages.Insert(9, Properties.Resources.ThreeH);
            listCardImages.Insert(10, Properties.Resources.ThreeD);
            listCardImages.Insert(11, Properties.Resources.ThreeS);

            listCardImages.Insert(12, Properties.Resources.FourC);
            listCardImages.Insert(13, Properties.Resources.FourH);
            listCardImages.Insert(14, Properties.Resources.FourD);
            listCardImages.Insert(15, Properties.Resources.FourS);

            listCardImages.Insert(16, Properties.Resources.FiveC);
            listCardImages.Insert(17, Properties.Resources.FiveH);
            listCardImages.Insert(18, Properties.Resources.FiveD);
            listCardImages.Insert(19, Properties.Resources.FiveS);

            listCardImages.Insert(20, Properties.Resources.SixC);
            listCardImages.Insert(21, Properties.Resources.SixH);
            listCardImages.Insert(22, Properties.Resources.SixD);
            listCardImages.Insert(23, Properties.Resources.SixS);

            listCardImages.Insert(24, Properties.Resources.SevenC);
            listCardImages.Insert(25, Properties.Resources.SevenH);
            listCardImages.Insert(26, Properties.Resources.SevenD);
            listCardImages.Insert(27, Properties.Resources.SevenS);

            listCardImages.Insert(28, Properties.Resources.EightC);
            listCardImages.Insert(29, Properties.Resources.EightH);
            listCardImages.Insert(30, Properties.Resources.EightD);
            listCardImages.Insert(31, Properties.Resources.EightS);

            listCardImages.Insert(32, Properties.Resources.NineC);
            listCardImages.Insert(33, Properties.Resources.NineH);
            listCardImages.Insert(34, Properties.Resources.NineD);
            listCardImages.Insert(35, Properties.Resources.NineS);

            listCardImages.Insert(36, Properties.Resources.TenC);
            listCardImages.Insert(37, Properties.Resources.TenH);
            listCardImages.Insert(38, Properties.Resources.TenD);
            listCardImages.Insert(39, Properties.Resources.TenS);

            listCardImages.Insert(40, Properties.Resources.JC);
            listCardImages.Insert(41, Properties.Resources.JH);
            listCardImages.Insert(42, Properties.Resources.JD);
            listCardImages.Insert(43, Properties.Resources.JS);

            listCardImages.Insert(44, Properties.Resources.QC);
            listCardImages.Insert(45, Properties.Resources.QH);
            listCardImages.Insert(46, Properties.Resources.QD);
            listCardImages.Insert(47, Properties.Resources.QS);

            listCardImages.Insert(48, Properties.Resources.KC);
            listCardImages.Insert(49, Properties.Resources.KH);
            listCardImages.Insert(50, Properties.Resources.KD);
            listCardImages.Insert(51, Properties.Resources.KS);

        }

        // Procedure: DealCard
        // Input: None
        // Output: void
        // Description: This procedure checks the random number passed by value and displays the image in a picture box
        // passed by reference that corresponds to the random number and takes that card out of the list.
        private void DealCard(ref PictureBox aPictureBox, int cardNumber)
        {
            if (cardNumber == 0)
            {
                aPictureBox.Image = Properties.Resources.AceC;
                listCardImages.RemoveAt(0);
            }
            else if (cardNumber == 1)
            {
                aPictureBox.Image = Properties.Resources.AceH;
                listCardImages.RemoveAt(1);
            }
            else if (cardNumber == 2)
            {
                aPictureBox.Image = Properties.Resources.AceD;
                listCardImages.RemoveAt(2);
            }
            else if (cardNumber == 3)
            {
                aPictureBox.Image = Properties.Resources.AceS;
                listCardImages.RemoveAt(3);
            }
            else if (cardNumber == 4)
            {
                aPictureBox.Image = Properties.Resources.TwoC;
                listCardImages.RemoveAt(4);
            }
            else if (cardNumber == 5)
            {
                aPictureBox.Image = Properties.Resources.TwoH;
                listCardImages.RemoveAt(5);
            }
            else if (cardNumber == 6)
            {
                aPictureBox.Image = Properties.Resources.TwoD;
                listCardImages.RemoveAt(6);
            }
            else if (cardNumber == 7)
            {
                aPictureBox.Image = Properties.Resources.TwoS;
                listCardImages.RemoveAt(7);
            }
            else if (cardNumber == 8)
            {
                aPictureBox.Image = Properties.Resources.ThreeC;
                listCardImages.RemoveAt(8);
            }
            else if (cardNumber == 9)
            {
                aPictureBox.Image = Properties.Resources.ThreeH;
                listCardImages.RemoveAt(9);
            }
            else if (cardNumber == 10)
            {
                aPictureBox.Image = Properties.Resources.ThreeD;
                listCardImages.RemoveAt(10);
            }
            else if (cardNumber == 11)
            {
                aPictureBox.Image = Properties.Resources.ThreeS;
                listCardImages.RemoveAt(11);
            }
            else if (cardNumber == 12)
            {
                aPictureBox.Image = Properties.Resources.FourC;
                listCardImages.RemoveAt(12);
            }
            else if (cardNumber == 13)
            {
                aPictureBox.Image = Properties.Resources.FourH;
                listCardImages.RemoveAt(13);
            }
            else if (cardNumber == 14)
            {
                aPictureBox.Image = Properties.Resources.FourD;
                listCardImages.RemoveAt(14);
            }
            else if (cardNumber == 15)
            {
                aPictureBox.Image = Properties.Resources.FourS;
                listCardImages.RemoveAt(15);
            }
            else if (cardNumber == 16)
            {
                aPictureBox.Image = Properties.Resources.FiveC;
                listCardImages.RemoveAt(16);
            }
            else if (cardNumber == 17)
            {
                aPictureBox.Image = Properties.Resources.FiveD;
                listCardImages.RemoveAt(17);
            }
            else if (cardNumber == 18)
            {
                aPictureBox.Image = Properties.Resources.FiveH;
                listCardImages.RemoveAt(18);
            }
            else if (cardNumber == 19)
            {
                aPictureBox.Image = Properties.Resources.FiveS;
                listCardImages.RemoveAt(19);
            }
            else if (cardNumber == 20)
            {
                aPictureBox.Image = Properties.Resources.SixC;
                listCardImages.RemoveAt(20);
            }
            else if (cardNumber == 21)
            {
                aPictureBox.Image = Properties.Resources.SixD;
                listCardImages.RemoveAt(21);
            }
            else if (cardNumber == 22)
            {
                aPictureBox.Image = Properties.Resources.SixH;
                listCardImages.RemoveAt(22);
            }
            else if (cardNumber == 23)
            {
                aPictureBox.Image = Properties.Resources.SixS;
                listCardImages.RemoveAt(23);
            }
            else if (cardNumber == 24)
            {
                aPictureBox.Image = Properties.Resources.SevenC;
                listCardImages.RemoveAt(24);
            }
            else if (cardNumber == 25)
            {
                aPictureBox.Image = Properties.Resources.SevenD;
                listCardImages.RemoveAt(25);
            }
            else if (cardNumber == 26)
            {
                aPictureBox.Image = Properties.Resources.SevenH;
                listCardImages.RemoveAt(26);
            }
            else if (cardNumber == 27)
            {
                aPictureBox.Image = Properties.Resources.SevenS;
                listCardImages.RemoveAt(27);
            }
            else if (cardNumber == 28)
            {
                aPictureBox.Image = Properties.Resources.EightC;
                listCardImages.RemoveAt(28);
            }
            else if (cardNumber == 29)
            {
                aPictureBox.Image = Properties.Resources.EightD;
                listCardImages.RemoveAt(29);
            }
            else if (cardNumber == 30)
            {
                aPictureBox.Image = Properties.Resources.EightH;
                listCardImages.RemoveAt(30);
            }
            else if (cardNumber == 31)
            {
                aPictureBox.Image = Properties.Resources.EightS;
                listCardImages.RemoveAt(31);
            }
            else if (cardNumber == 32)
            {
                aPictureBox.Image = Properties.Resources.NineC;
                listCardImages.RemoveAt(32);
            }
            else if (cardNumber == 33)
            {
                aPictureBox.Image = Properties.Resources.NineD;
                listCardImages.RemoveAt(33);
            }
            else if (cardNumber == 34)
            {
                aPictureBox.Image = Properties.Resources.NineH;
                listCardImages.RemoveAt(34);
            }
            else if (cardNumber == 35)
            {
                aPictureBox.Image = Properties.Resources.NineS;
                listCardImages.RemoveAt(35);
            }
            else if (cardNumber == 36)
            {
                aPictureBox.Image = Properties.Resources.TenC;
                listCardImages.RemoveAt(36);
            }
            else if (cardNumber == 37)
            {
                aPictureBox.Image = Properties.Resources.TenD;
                listCardImages.RemoveAt(37);
            }
            else if (cardNumber == 38)
            {
                aPictureBox.Image = Properties.Resources.TenH;
                listCardImages.RemoveAt(38);
            }
            else if (cardNumber == 39)
            {
                aPictureBox.Image = Properties.Resources.TenS;
                listCardImages.RemoveAt(39);
            }
            else if (cardNumber == 40)
            {
                aPictureBox.Image = Properties.Resources.JC;
                listCardImages.RemoveAt(40);
            }
            else if (cardNumber == 41)
            {
                aPictureBox.Image = Properties.Resources.JD;
                listCardImages.RemoveAt(41);
            }
            else if (cardNumber == 42)
            {
                aPictureBox.Image = Properties.Resources.JH;
                listCardImages.RemoveAt(42);
            }
            else if (cardNumber == 43)
            {
                aPictureBox.Image = Properties.Resources.JS;
                listCardImages.RemoveAt(43);
            }
            else if (cardNumber == 44)
            {
                aPictureBox.Image = Properties.Resources.QC;
                listCardImages.RemoveAt(44);
            }
            else if (cardNumber == 45)
            {
                aPictureBox.Image = Properties.Resources.QD;
                listCardImages.RemoveAt(45);
            }
            else if (cardNumber == 46)
            {
                aPictureBox.Image = Properties.Resources.QH;
                listCardImages.RemoveAt(46);
            }
            else if (cardNumber == 47)
            {
                aPictureBox.Image = Properties.Resources.QS;
                listCardImages.RemoveAt(47);
            }
            else if (cardNumber == 48)
            {
                aPictureBox.Image = Properties.Resources.KC;
                listCardImages.RemoveAt(48);
            }
            else if (cardNumber == 49)
            {
                aPictureBox.Image = Properties.Resources.KD;
                listCardImages.RemoveAt(49);
            }
            else if (cardNumber == 50)
            {
                aPictureBox.Image = Properties.Resources.KH;
                listCardImages.RemoveAt(50);
            }
            else if (cardNumber == 51)
            {
                aPictureBox.Image = Properties.Resources.KS;
                listCardImages.RemoveAt(51);
            }

            if (listCardImages.Count() < 8)
            {
                MessageBox.Show("Reshuffling.", "Deal Card");
                this.listCardImages.Clear();
                NewDeck();
            }
        }

        private void picCard_Click(object sender, EventArgs e)
        {
            // generate a random number
            randomNumber = randNum.Next(0, listCardImages.Count() - 1);

            // get the card depending on the random selection
            DealCard(ref this.picCard, randomNumber);
        }

        private void picCard2_Click(object sender, EventArgs e)
        {
            // generate a random number
            randomNumber = randNum.Next(0, listCardImages.Count() - 1);

            // get the card depending on the random selection
            DealCard(ref this.picCard2, randomNumber);
        }

        private void picCard3_Click(object sender, EventArgs e)
        {
            // generate a random number
            randomNumber = randNum.Next(0, listCardImages.Count() - 1);

            // get the card depending on the random selection
            DealCard(ref this.picCard3, randomNumber);
        }

        private void picCard4_Click(object sender, EventArgs e)
        {
            // generate a random number
            randomNumber = randNum.Next(0, listCardImages.Count() - 1);

            // get the card depending on the random selection
            DealCard(ref this.picCard4, randomNumber);
        }

        private void picCard5_Click(object sender, EventArgs e)
        {
            // generate a random number
            randomNumber = randNum.Next(0, listCardImages.Count() - 1);

            // get the card depending on the random selection
            DealCard(ref this.picCard5, randomNumber);
        }

        private void picCard6_Click(object sender, EventArgs e)
        {
            // generate a random number
            randomNumber = randNum.Next(0, listCardImages.Count() - 1);

            // get the card depending on the random selection
            DealCard(ref this.picCard6, randomNumber);
        }
    }
}