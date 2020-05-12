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


            public static class Globals
            {
                // global int
                public static bool team;
            }

            private void pic5_Click(object sender, EventArgs e)
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
            }

            private void pic1_Click(object sender, EventArgs e)
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
            }

            private void pic2_Click(object sender, EventArgs e)
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
            }

            private void pic3_Click(object sender, EventArgs e)
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
            }

            private void pic4_Click(object sender, EventArgs e)
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
            }

            private void pic6_Click(object sender, EventArgs e)
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
            }

            private void pic7_Click(object sender, EventArgs e)
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
            }

            private void pic8_Click(object sender, EventArgs e)
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
            }

            private void pic9_Click(object sender, EventArgs e)
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
            }
        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }
    }

}
}
