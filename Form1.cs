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
            Globals.one = change(1, Globals.one);
            checkwin();
        }

        private void pic2_Click_1(object sender, EventArgs e)
        {
            Globals.two = change(2, Globals.two);
            checkwin();
        }

        private void pic3_Click_1(object sender, EventArgs e)
        {
            Globals.three = change(3, Globals.three);
            checkwin();
        }

        private void pic4_Click_1(object sender, EventArgs e)
        {
            Globals.four = change(4, Globals.four);
            checkwin();
        }

        private void pic5_Click_1(object sender, EventArgs e)
        {
            Globals.five = change(5, Globals.five);
            checkwin();
        }

        private void pic6_Click_1(object sender, EventArgs e)
        {
            Globals.six = change(6, Globals.six);
            checkwin();
        }

        private void pic7_Click_1(object sender, EventArgs e)
        {
            Globals.seven = change(7, Globals.seven);
            checkwin();
        }

        private void pic8_Click_1(object sender, EventArgs e)
        {
            Globals.eight = change(8, Globals.eight);
            checkwin();
        }

        private void pic9_Click_1(object sender, EventArgs e)
        {
            Globals.nine = change(9, Globals.nine);
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
                //Its crosses by default and uses the IF to change to noughts if needed
                Image toUse = Properties.Resources.cross;
                value = 2;
                if (Globals.team == true)
                {
                    toUse = Properties.Resources.Nought;
                    value = 1;
                }
                switch (square)
                {
                    case 1:
                        pic1.Image = toUse;
                        break;
                    case 2:
                        pic2.Image = toUse;
                        break;
                    case 3:
                        pic3.Image = toUse;
                        break;
                    case 4:
                        pic4.Image = toUse;
                        break;
                    case 5:
                        pic5.Image = toUse;
                        break;
                    case 6:
                        pic6.Image = toUse;
                        break;
                    case 7:
                        pic7.Image = toUse;
                        break;
                    case 8:
                        pic8.Image = toUse;
                        break;
                    case 9:
                        pic9.Image = toUse;
                        break;
                }   
            Globals.team = !Globals.team;
            }
            return value;
        }
    }
}

