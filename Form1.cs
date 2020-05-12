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
            //0 means unused.
            //1 means occupied by O
            //2 means occupied by X
            public static int one = 0;
            public static int two = 0;
            public static int three = 0;
            public static int four = 0;
            public static int five = 0;
            public static int six = 0;
            public static int seven = 0;
            public static int eight = 0;
            public static int nine = 0;
        }

        private void pic1_Click_1(object sender, EventArgs e)
        {
            if (Globals.one == 0)
            {
                if (Globals.team == true)
                {
                    pic1.Image = Properties.Resources.Nought;
                    Globals.team = false;
                    Globals.one = 1;
                }
                else
                {
                    pic1.Image = Properties.Resources.cross;
                    Globals.team = true;
                    Globals.one = 2;
                }
                
                checkwin();
            }
        }

        private void pic2_Click_1(object sender, EventArgs e)
        {
            if (Globals.two == 0)
            {
                if (Globals.team == true)
                {
                    pic2.Image = Properties.Resources.Nought;
                    Globals.team = false;
                    Globals.two = 1;
                }
                else
                {
                    pic2.Image = Properties.Resources.cross;
                    Globals.team = true;
                    Globals.two = 2;
                }
                
                checkwin();
            }
        }

        private void pic3_Click_1(object sender, EventArgs e)
        {
            if (Globals.three == 0)
            {
                if (Globals.team == true)
                {
                    pic3.Image = Properties.Resources.Nought;
                    Globals.team = false;
                    Globals.three = 1;
                }
                else
                {
                    pic3.Image = Properties.Resources.cross;
                    Globals.team = true;
                    Globals.three = 2;
                }
                
                checkwin();
            }
        }

        private void pic4_Click_1(object sender, EventArgs e)
        {
            if (Globals.four == 0)
            {
                if (Globals.team == true)
                {
                    pic4.Image = Properties.Resources.Nought;
                    Globals.team = false;
                    Globals.four = 1;
                }
                else
                {
                    pic4.Image = Properties.Resources.cross;
                    Globals.team = true;
                    Globals.four = 2;
                }
                
                checkwin();
            }
        }

        private void pic5_Click_1(object sender, EventArgs e)
        {
            if (Globals.five == 0)
            {
                if (Globals.team == true)
                {
                    pic5.Image = Properties.Resources.Nought;
                    Globals.team = false;
                    Globals.five = 1;
                }
                else
                {
                    pic5.Image = Properties.Resources.cross;
                    Globals.team = true;
                    Globals.five = 2;
                }
                
                checkwin();
            }
        }

        private void pic6_Click_1(object sender, EventArgs e)
        {
            if (Globals.six == 0)
            {
                if (Globals.team == true)
                {
                    pic6.Image = Properties.Resources.Nought;
                    Globals.team = false;
                    Globals.six = 1;
                }
                else
                {
                    pic6.Image = Properties.Resources.cross;
                    Globals.team = true;
                    Globals.six = 2;
                }
                
                checkwin();
            }
        }

        private void pic7_Click_1(object sender, EventArgs e)
        {
            if (Globals.seven == 0)
            {
                if (Globals.team == true)
                {
                    pic7.Image = Properties.Resources.Nought;
                    Globals.team = false;
                    Globals.seven = 1;
                }
                else
                {
                    pic7.Image = Properties.Resources.cross;
                    Globals.team = true;
                    Globals.seven = 2;
                }
                
                checkwin();
            }
        }

        private void pic8_Click_1(object sender, EventArgs e)
        {
            if (Globals.eight == 0)
            {
                if (Globals.team == true)
                {
                    pic8.Image = Properties.Resources.Nought;
                    Globals.team = false;
                    Globals.eight = 1;
                }
                else
                {
                    pic8.Image = Properties.Resources.cross;
                    Globals.team = true;
                    Globals.eight = 2;
                }
                
                checkwin();
            }
        }

        private void pic9_Click_1(object sender, EventArgs e)
        {
            if (Globals.nine == 0)
            {
                if (Globals.team == true)
                {
                    pic9.Image = Properties.Resources.Nought;
                    Globals.team = false;
                    Globals.nine = 1;
                }
                else
                {
                    pic9.Image = Properties.Resources.cross;
                    Globals.team = true;
                    Globals.nine = 2;
                }
                
                checkwin();
            }
        }

        public void checkwin()
        {
            //All win conditions for X.
            if ((Globals.one == 2 && Globals.two == 2 && Globals.three == 2) || (Globals.one == 2 && Globals.four == 2 && Globals.seven == 2) ||
                (Globals.one == 2 && Globals.five == 2 && Globals.nine == 2) || (Globals.two == 2 && Globals.five == 2 && Globals.eight == 2) ||
                (Globals.three == 2 && Globals.six == 2 && Globals.nine == 2) || (Globals.four == 2 && Globals.five == 2 && Globals.six == 2) ||
                (Globals.seven == 2 && Globals.eight == 2 && Globals.nine == 2) || (Globals.three == 2 && Globals.five == 2 && Globals.seven == 2))
            {
                MessageBox.Show("X Win");
            }
            if ((Globals.one == 1 && Globals.two == 1 && Globals.three == 1) || (Globals.one == 1 && Globals.four == 1 && Globals.seven == 1) ||
                (Globals.one == 2 && Globals.five == 1 && Globals.nine == 1) || (Globals.two == 1 && Globals.five == 1 && Globals.eight == 1) ||
                (Globals.three == 1 && Globals.six == 1 && Globals.nine == 1) || (Globals.four == 1 && Globals.five == 1 && Globals.six == 1) ||
                (Globals.seven == 1 && Globals.eight == 1 && Globals.nine == 1) || (Globals.three == 1 && Globals.five == 1 && Globals.seven == 1))
            {
                MessageBox.Show("O Win");
            }
        }
    }
}

