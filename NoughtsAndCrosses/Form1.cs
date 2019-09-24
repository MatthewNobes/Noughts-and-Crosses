using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoughtsAndCrosses
{
    public partial class MainForm : Form
    {
        public bool turnTimer = false;

        public bool winIsLost = false;

        public bool oneFull = false;
        public bool twoFull = false;
        public bool threeFull = false;
        public bool fourFull = false;
        public bool fiveFull = false;
        public bool sixFull = false;
        public bool sevenFull = false;
        public bool eightFull = false;
        public bool nineFull = false;

        public string one;
        public string two;
        public string three;
        public string four;
        public string five;
        public string six;
        public string seven;
        public string eight;
        public string nine;

        public MainForm()
        {
            InitializeComponent();


            
        }

        private void PcbOne_Click(object sender, EventArgs e)
        {
            if (oneFull == false)
            {
                if (turnTimer == false)
                {
                    pcbOne.Image = Properties.Resources.cross;
                    turnTimer = true;
                    one = "c";
                }
                else
                {
                    pcbOne.Image = Properties.Resources.Nought;
                    turnTimer = false;
                    one = "n";
                }
                oneFull = true;
                isWinMet();
            }

        }

        private void PcbTwo_Click(object sender, EventArgs e)
        {
            if (twoFull == false)
            {
                if (turnTimer == false)
                {
                    pcbTwo.Image = Properties.Resources.cross;
                    turnTimer = true;
                    two = "c";
                }
                else
                {
                    pcbTwo.Image = Properties.Resources.Nought;
                    turnTimer = false;
                    two = "n";
                }
                twoFull = true;
            }
            isWinMet();
        }

        private void PcbThree_Click(object sender, EventArgs e)
        {
            if (threeFull == false)
            {
                if (turnTimer == false)
                {
                    pcbThree.Image = Properties.Resources.cross;
                    turnTimer = true;
                    three = "c";
                }
                else
                {
                    pcbThree.Image = Properties.Resources.Nought;
                    turnTimer = false;
                    three = "n";
                }
                threeFull = true;
            }
            isWinMet();
        }

        private void PcbFour_Click(object sender, EventArgs e)
        {
            if (fourFull == false)
            {
                if (turnTimer == false)
                {
                    pcbFour.Image = Properties.Resources.cross;
                    turnTimer = true;
                    four = "c";
                }
                else
                {
                    pcbFour.Image = Properties.Resources.Nought;
                    turnTimer = false;
                    four = "n";
                }
                fourFull = true;
            }
        }

        private void PcbFive_Click(object sender, EventArgs e)
        {
            if (fiveFull == false)
            {
                if (turnTimer == false)
                {
                    pcbFive.Image = Properties.Resources.cross;
                    turnTimer = true;
                    five = "c";
                }
                else
                {
                    pcbFive.Image = Properties.Resources.Nought;
                    turnTimer = false;
                    five = "n";
                }
                fiveFull = true;
            }
        }

        private void PcbSix_Click(object sender, EventArgs e)
        {
            if (sixFull == false)
            {
                if (turnTimer == false)
                {
                    pcbSix.Image = Properties.Resources.cross;
                    turnTimer = true;
                    six = "c";
                }
                else
                {
                    pcbSix.Image = Properties.Resources.Nought;
                    turnTimer = false;
                    six = "n";
                }
                sixFull = true;
            }
        }

        private void PcbSeven_Click(object sender, EventArgs e)
        {
            if (sevenFull == false)
            {
                if (turnTimer == false)
                {
                    pcbSeven.Image = Properties.Resources.cross;
                    turnTimer = true;
                    seven = "c";
                }
                else
                {
                    pcbSeven.Image = Properties.Resources.Nought;
                    turnTimer = false;
                    seven = "n";
                }
                sevenFull = true;
            }
        }

        private void PcbEight_Click(object sender, EventArgs e)
        {
            if (eightFull == false)
            {
                if (turnTimer == false)
                {
                    pcbEight.Image = Properties.Resources.cross;
                    turnTimer = true;
                    eight = "c";
                }
                else
                {
                    pcbEight.Image = Properties.Resources.Nought;
                    turnTimer = false;
                    eight = "n";
                }
                eightFull = true;
            }
        }

        private void PcbNine_Click(object sender, EventArgs e)
        {
            if (nineFull == false)
            {
                if (turnTimer == false)
                {
                    pcbNine.Image = Properties.Resources.cross;
                    turnTimer = true;
                    nine = "c";
                }
                else
                {
                    pcbNine.Image = Properties.Resources.Nought;
                    turnTimer = false;
                    nine = "n";
                }
                nineFull = true;
            }
        }

        public void isWinMet()
        {
            
            if ((one =="c" && two =="c" && three== "c") | (one == "c" && five == "c" && nine == "c"))
            {
                MessageBox.Show("Crosses win");
            }
        }
    }
}
