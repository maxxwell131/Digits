using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digits
{
    public partial class FormDigits : Form
    {
        int buttons = 9;
        int currentButton;
        Random random = new Random();

        public FormDigits()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Game with numbers.


                Press number from 1 to 9", "About program");
        }

        private void menuNewGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            for (int i = 1; i <= buttons; i++)
            {
                myButton(i).Text = i.ToString();
            }

            for (int j = 0; j < 100; j++)
            {
                SwapButtons();
            }

            for (int i = 1; i <= buttons; i++)
            {
                myButton(i).Visible = true;
            }

            currentButton = 1;
        }

        private void SwapButtons()
        {
            int rndButton1 = random.Next( 1, buttons);
            int rndButton2 = random.Next( 1, buttons);

            if (rndButton1 == rndButton2) return;

            string tmpButtonText = myButton(rndButton1).Text;
            myButton(rndButton1).Text = myButton(rndButton2).Text;
            myButton(rndButton2).Text = tmpButtonText;
        }

        public Button myButton(int button)
        {
            switch (button)
            {
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;

                default:
                    return null;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string currentButtonClick = ((Button)sender).Text.ToString();
            if (currentButtonClick == currentButton.ToString())
            {
                ((Button)sender).Visible = false;
                currentButton++;
            }
        }
    }
}
