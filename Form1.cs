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
            int val = change(1, Globals.one);
            Globals.one = val;
            checkwin();
        }

        private void pic2_Click_1(object sender, EventArgs e)
        {
            int val = change(2, Globals.two);
            Globals.two = val;
            checkwin();
        }

        private void pic3_Click_1(object sender, EventArgs e)
        {
            int val = change(3, Globals.three);
            Globals.three = val;
            checkwin();
        }

        private void pic4_Click_1(object sender, EventArgs e)
        {
            int val = change(4, Globals.four);
            Globals.four = val;
            checkwin();
        }

        private void pic5_Click_1(object sender, EventArgs e)
        {
            int val = change(5, Globals.five);
            Globals.five = val;
            checkwin();
        }

        private void pic6_Click_1(object sender, EventArgs e)
        {
            int val = change(6, Globals.six);
            Globals.six = val;
            checkwin();
        }

        private void pic7_Click_1(object sender, EventArgs e)
        {
            int val = change(7, Globals.seven);
            Globals.seven = val;
            checkwin();
        }

        private void pic8_Click_1(object sender, EventArgs e)
        {
            int val = change(8, Globals.eight);
            Globals.eight = val;
            checkwin();
        }

        private void pic9_Click_1(object sender, EventArgs e)
        {
            int val = change(9, Globals.nine);
            Globals.nine = val;
            checkwin();
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
                (Globals.one == 1 && Globals.five == 1 && Globals.nine == 1) || (Globals.two == 1 && Globals.five == 1 && Globals.eight == 1) ||
                (Globals.three == 1 && Globals.six == 1 && Globals.nine == 1) || (Globals.four == 1 && Globals.five == 1 && Globals.six == 1) ||
                (Globals.seven == 1 && Globals.eight == 1 && Globals.nine == 1) || (Globals.three == 1 && Globals.five == 1 && Globals.seven == 1))
            {
                MessageBox.Show("O Win");
            }
        }

        //value replaces the global variable
        public int change(int square, int value)
        {
            if (value == 0)
            {
                switch (square)
                {
                    case 1:
                        if (Globals.team == true)
                        {
                            pic1.Image = Properties.Resources.Nought;
                            value = 1;
                        }
                        else
                        {
                            pic1.Image = Properties.Resources.cross;
                            value = 2;
                        }
                        break;
                    case 2:
                        if (Globals.team == true)
                        {
                            pic2.Image = Properties.Resources.Nought;
                            value = 1;
                        }
                        else
                        {
                            pic2.Image = Properties.Resources.cross;
                            value = 2;
                        }
                        break;
                    case 3:
                        if (Globals.team == true)
                        {
                            pic3.Image = Properties.Resources.Nought;
                            value = 1;
                        }
                        else
                        {
                            pic3.Image = Properties.Resources.cross;
                            value = 2;
                        }
                        break;
                    case 4:
                        if (Globals.team == true)
                        {
                            pic4.Image = Properties.Resources.Nought;
                            value = 1;
                        }
                        else
                        {
                            pic4.Image = Properties.Resources.cross;
                            value = 2;
                        }
                        break;
                    case 5:
                        if (Globals.team == true)
                        {
                            pic5.Image = Properties.Resources.Nought;
                            value = 1;
                        }
                        else
                        {
                            pic5.Image = Properties.Resources.cross;
                            value = 2;
                        }
                        break;
                    case 6:
                        if (Globals.team == true)
                        {
                            pic6.Image = Properties.Resources.Nought;
                            value = 1;
                        }
                        else
                        {
                            pic6.Image = Properties.Resources.cross;
                            value = 2;
                        }
                        break;
                    case 7:
                        if (Globals.team == true)
                        {
                            pic7.Image = Properties.Resources.Nought;
                            value = 1;
                        }
                        else
                        {
                            pic7.Image = Properties.Resources.cross;
                            value = 2;
                        }
                        break;
                    case 8:
                        if (Globals.team == true)
                        {
                            pic8.Image = Properties.Resources.Nought;
                            value = 1;
                        }
                        else
                        {
                            pic8.Image = Properties.Resources.cross;
                            value = 2;
                        }
                        break;
                    case 9:
                        if (Globals.team == true)
                        {
                            pic9.Image = Properties.Resources.Nought;
                            value = 1;
                        }
                        else
                        {
                            pic9.Image = Properties.Resources.cross;
                            value = 2;
                        }
                        break;
                }   
            Globals.team = !Globals.team;
            }
            return value;
        }
    }
}

