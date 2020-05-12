using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noughts_and_Crosses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static class Globals
        {
            // used to deiced who's turn it is
            public static bool team;

            //Used to note a square has been used.
            public static bool one;
            public static bool two;
            public static bool three;
            public static bool four;
            public static bool five;
            public static bool six;
            public static bool seven;
            public static bool eight;
            public static bool nine;
        }

        private void pic1_Click_1(object sender, EventArgs e)
        {
            if (Globals.one == false)
            {
                if (Globals.team == true)
                {
                    pic1.Image = Properties.Resources.Nought;
                    Globals.team = false;
                }
                else
                {
                    pic1.Image = Properties.Resources.cross;
                    Globals.team = true;
                }
                Globals.one = true;
            }
        }

        private void pic2_Click_1(object sender, EventArgs e)
        {
            if (Globals.two == false)
            {
                if (Globals.team == true)
                {
                    pic2.Image = Properties.Resources.Nought;
                    Globals.team = false;
                }
                else
                {
                    pic2.Image = Properties.Resources.cross;
                    Globals.team = true;
                }
                Globals.two = true;
            }
        }

        private void pic3_Click_1(object sender, EventArgs e)
        {
            if (Globals.three == false)
            {
                if (Globals.team == true)
                {
                    pic3.Image = Properties.Resources.Nought;
                    Globals.team = false;
                }
                else
                {
                    pic3.Image = Properties.Resources.cross;
                    Globals.team = true;
                }
                Globals.three = true;
            }
        }

        private void pic4_Click_1(object sender, EventArgs e)
        {
            if (Globals.four == false)
            {
                if (Globals.team == true)
                {
                    pic4.Image = Properties.Resources.Nought;
                    Globals.team = false;
                }
                else
                {
                    pic4.Image = Properties.Resources.cross;
                    Globals.team = true;
                }
                Globals.four = true;
            }
        }

        private void pic5_Click_1(object sender, EventArgs e)
        {
            if (Globals.five == false)
            {
                if (Globals.team == true)
                {
                    pic5.Image = Properties.Resources.Nought;
                    Globals.team = false;
                }
                else
                {
                    pic5.Image = Properties.Resources.cross;
                    Globals.team = true;
                }
                Globals.five = true;
            }
        }

        private void pic6_Click_1(object sender, EventArgs e)
        {
            if (Globals.six == false)
            {
                if (Globals.team == true)
                {
                    pic6.Image = Properties.Resources.Nought;
                    Globals.team = false;
                }
                else
                {
                    pic6.Image = Properties.Resources.cross;
                    Globals.team = true;
                }
                Globals.six = true;
            }
        }

        private void pic7_Click_1(object sender, EventArgs e)
        {
            if (Globals.seven == false)
            {
                if (Globals.team == true)
                {
                    pic7.Image = Properties.Resources.Nought;
                    Globals.team = false;
                }
                else
                {
                    pic7.Image = Properties.Resources.cross;
                    Globals.team = true;
                }
                Globals.seven = true;
            }
        }

        private void pic8_Click_1(object sender, EventArgs e)
        {
            if (Globals.eight == false)
            {
                if (Globals.team == true)
                {
                    pic8.Image = Properties.Resources.Nought;
                    Globals.team = false;
                }
                else
                {
                    pic8.Image = Properties.Resources.cross;
                    Globals.team = true;
                }
                Globals.eight = true;
            }
        }

        private void pic9_Click_1(object sender, EventArgs e)
        {
            if (Globals.nine == false)
            {
                if (Globals.team == true)
                {
                    pic9.Image = Properties.Resources.Nought;
                    Globals.team = false;
                }
                else
                {
                    pic9.Image = Properties.Resources.cross;
                    Globals.team = true;
                }
                Globals.nine = true;
            }
        }
    }
}

