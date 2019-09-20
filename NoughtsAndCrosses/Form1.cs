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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            

            this.Cursor = new Cursor(Cursor.Current.Handle);
            

            if (Cursor.Position.X <=275)
            {
                MessageBox.Show("hello");
            }
        }
    }
}
