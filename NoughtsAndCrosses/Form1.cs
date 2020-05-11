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
        public MainForm()
        {
            InitializeComponent();
            
        }
        public static class Globals
        {
            // global int
            public static bool team;
            public static String FILE_NAME = "Output.txt";

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

       
    }
}
