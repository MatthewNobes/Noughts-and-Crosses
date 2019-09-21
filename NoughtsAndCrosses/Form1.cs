﻿using System;
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
                }
                else
                {
                    pcbOne.Image = Properties.Resources.Nought;
                    turnTimer = false;
                }
                oneFull = true; 
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
                }
                else
                {
                    pcbTwo.Image = Properties.Resources.Nought;
                    turnTimer = false;
                }
                twoFull = true;
            }
        }

        private void PcbThree_Click(object sender, EventArgs e)
        {
            if (threeFull == false)
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
                threeFull = true;
            }
        }

        private void PcbFour_Click(object sender, EventArgs e)
        {
            if (fourFull == false)
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
                }
                else
                {
                    pcbFive.Image = Properties.Resources.Nought;
                    turnTimer = false;
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
                }
                else
                {
                    pcbSix.Image = Properties.Resources.Nought;
                    turnTimer = false;
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
                }
                else
                {
                    pcbSeven.Image = Properties.Resources.Nought;
                    turnTimer = false;
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
                }
                else
                {
                    pcbEight.Image = Properties.Resources.Nought;
                    turnTimer = false;
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
                }
                else
                {
                    pcbNine.Image = Properties.Resources.Nought;
                    turnTimer = false;
                }
                nineFull = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //while (winIsLost == false)
            //{
              //  if (pcbOne.Image == Properties.Resources.cross)
                //{
                  //  MessageBox.Show("won");
                //}
            //}
        }
    }
}
