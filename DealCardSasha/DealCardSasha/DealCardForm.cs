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
            Image card = listCardImages[cardNumber];
            aPictureBox.Image = card;
            listCardImages.RemoveAt(cardNumber);
        }

        private void picCard_Click(object sender, EventArgs e)
        {
            // if there are zero cards left in the deck
            if (listCardImages.Count() <= 0)
            {
                // display a message box saying that the cards are being reshuffled
                MessageBox.Show("Reshuffling.", "Deal Card");
                // clear the list 
                this.listCardImages.Clear();
                // call the FaceDown procedure
                FaceDown();
                // call the NewDeck procedure
                NewDeck();
            }
            else
            {
                // generate a random number
                randomNumber = randNum.Next(0, listCardImages.Count() - 1);

                // get the card depending on the random selection
                DealCard(ref this.picCard, randomNumber);
            }
        }

        private void picCard2_Click(object sender, EventArgs e)
        {
            // if there are zero cards left in the deck
            if (listCardImages.Count() <= 0)
            {
                // display a message box saying that the cards are being reshuffled
                MessageBox.Show("Reshuffling.", "Deal Card");
                // clear the list 
                this.listCardImages.Clear();
                // call the FaceDown procedure
                FaceDown();
                // call the NewDeck procedure
                NewDeck();
            }
            else
            {
                // generate a random number
                randomNumber = randNum.Next(0, listCardImages.Count() - 1);

                // get the card depending on the random selection
                DealCard(ref this.picCard2, randomNumber);
            }
        }

        private void picCard3_Click(object sender, EventArgs e)
        {
            // if there are zero cards left in the deck
            if (listCardImages.Count() <= 0)
            {
                // display a message box saying that the cards are being reshuffled
                MessageBox.Show("Reshuffling.", "Deal Card");
                // clear the list 
                this.listCardImages.Clear();
                // call the FaceDown procedure
                FaceDown();
                // call the NewDeck procedure
                NewDeck();
            }
            else
            {
                // generate a random number
                randomNumber = randNum.Next(0, listCardImages.Count() - 1);

                // get the card depending on the random selection
                DealCard(ref this.picCard3, randomNumber);
            }
        }

        private void picCard4_Click(object sender, EventArgs e)
        {
            // if there are zero cards left in the deck
            if (listCardImages.Count() <= 0)
            {
                // display a message box saying that the cards are being reshuffled
                MessageBox.Show("Reshuffling.", "Deal Card");
                // clear the list 
                this.listCardImages.Clear();
                // call the FaceDown procedure
                FaceDown();
                // call the NewDeck procedure
                NewDeck();
            }
            else
            {
                // generate a random number
                randomNumber = randNum.Next(0, listCardImages.Count() - 1);

                // get the card depending on the random selection
                DealCard(ref this.picCard4, randomNumber);
            }
        }

        private void picCard5_Click(object sender, EventArgs e)
        {
            // if there are zero cards left in the deck
            if (listCardImages.Count() <= 0)
            {
                // display a message box saying that the cards are being reshuffled
                MessageBox.Show("Reshuffling.", "Deal Card");
                // clear the list 
                this.listCardImages.Clear();
                // call the FaceDown procedure
                FaceDown();
                // call the NewDeck procedure
                NewDeck();
            }
            else
            {
                // generate a random number
                randomNumber = randNum.Next(0, listCardImages.Count() - 1);

                // get the card depending on the random selection
                DealCard(ref this.picCard5, randomNumber);
            }
        }

        private void picCard6_Click(object sender, EventArgs e)
        {
            // if there are zero cards left in the deck
            if (listCardImages.Count() <= 0)
            {
                // display a message box saying that the cards are being reshuffled
                MessageBox.Show("Reshuffling.", "Deal Card");
                // clear the list 
                this.listCardImages.Clear();
                // call the FaceDown procedure
                FaceDown();
                // call the NewDeck procedure
                NewDeck();
            }
            else
            {
                // generate a random number
                randomNumber = randNum.Next(0, listCardImages.Count() - 1);

                // get the card depending on the random selection
                DealCard(ref this.picCard6, randomNumber);
            }
        }

        // Procedure: FaceDown
        // Input: None
        // Output: void
        // Description: Sets all of the cards face down. 
        private void FaceDown()
        {
            this.picCard.Image = Properties.Resources.Back;
            this.picCard2.Image = Properties.Resources.Back;
            this.picCard3.Image = Properties.Resources.Back;
            this.picCard4.Image = Properties.Resources.Back;
            this.picCard5.Image = Properties.Resources.Back;
            this.picCard6.Image = Properties.Resources.Back;
        }
    }
}