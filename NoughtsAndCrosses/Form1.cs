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

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void PcbOne_Click(object sender, EventArgs e)
        {
            
            if (turnTimer ==false)
            {
                pcbOne.Image = Properties.Resources.cross;
                turnTimer = true;
            }
            else
            {
                pcbOne.Image = Properties.Resources.Nought;
                turnTimer = false;
            }

        }

        private void PcbTwo_Click(object sender, EventArgs e)
        {
            if (turnTimer == false)
            {
                pcbTwo.Image = Properties.Resources.cross;
                turnTimer = true;
            }
            else
            {
                pcbTwo.Image = Properties.Resources.Nought;
                turnTimer = false;
            }
        }

        private void PcbThree_Click(object sender, EventArgs e)
        {
            if (turnTimer == false)
            {
                pcbThree.Image = Properties.Resources.cross;
                turnTimer = true;
            }
            else
            {
                pcbThree.Image = Properties.Resources.Nought;
                turnTimer = false;
            }
        }

        private void PcbFour_Click(object sender, EventArgs e)
        {
            if (turnTimer == false)
            {
                pcbFour.Image = Properties.Resources.cross;
                turnTimer = true;
            }
            else
            {
                pcbFour.Image = Properties.Resources.Nought;
                turnTimer = false;
            }
        }

        private void PcbFive_Click(object sender, EventArgs e)
        {
            if (turnTimer == false)
            {
                pcbFive.Image = Properties.Resources.cross;
                turnTimer = true;
            }
            else
            {
                pcbFive.Image = Properties.Resources.Nought;
                turnTimer = false;
            }
        }

        private void PcbSix_Click(object sender, EventArgs e)
        {
            if (turnTimer == false)
            {
                pcbSix.Image = Properties.Resources.cross;
                turnTimer = true;
            }
            else
            {
                pcbSix.Image = Properties.Resources.Nought;
                turnTimer = false;
            }
        }

        private void PcbSeven_Click(object sender, EventArgs e)
        {
            if (turnTimer == false)
            {
                pcbSeven.Image = Properties.Resources.cross;
                turnTimer = true;
            }
            else
            {
                pcbSeven.Image = Properties.Resources.Nought;
                turnTimer = false;
            }
        }

        private void PcbEight_Click(object sender, EventArgs e)
        {
            if (turnTimer == false)
            {
                pcbEight.Image = Properties.Resources.cross;
                turnTimer = true;
            }
            else
            {
                pcbEight.Image = Properties.Resources.Nought;
                turnTimer = false;
            }
        }

        private void PcbNine_Click(object sender, EventArgs e)
        {
            if (turnTimer == false)
            {
                pcbNine.Image = Properties.Resources.cross;
                turnTimer = true;
            }
            else
            {
                pcbNine.Image = Properties.Resources.Nought;
                turnTimer = false;
            }
        }
    }
}
