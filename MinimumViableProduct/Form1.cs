using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinimumViableProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declare variables
        bool right, left;
        private void player_Click(object sender, EventArgs e)
        {

        }
        //When key pressed
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            //Move left and right
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (right == true) { player.Left += 5; }//5 pixels to the right
            if (left == true) { player.Left -= 5; }//5 pixels to the left
            //Stop playing moving left
            if (!player.Bounds.IntersectsWith(panel1.Bounds.Left()))
            {
                left = false;
                if
                    {
                    player.Left += 1;
                }
            }
        }

        //When key released
        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            //Stop moving left and right
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }
    }
}
