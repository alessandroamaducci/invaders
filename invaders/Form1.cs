using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invaders
{
    public partial class Form1 : Form
    {
        Circle animatedcircle = new Circle();
        public Form1()
        {
            InitializeComponent();
            animatedcircle.g = this.CreateGraphics();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

           //Debugger.Break();
           var g = this.CreateGraphics();
            Circle cerchio1 = new Circle();
            cerchio1.g = g;
            cerchio1.Draw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Down)
            {
                animatedcircle.currenty = animatedcircle.currenty + 10;
                animatedcircle.Draw();

            }
            if (e.KeyCode == Keys.Up)
            {
                animatedcircle.currenty = animatedcircle.currenty - 10;
                animatedcircle.Draw();

            }
            if (e.KeyCode == Keys.Left)
            {
                animatedcircle.currentx = animatedcircle.currentx - 10;
                animatedcircle.Draw();

            }
            if (e.KeyCode == Keys.Right)
            {
                animatedcircle.currentx = animatedcircle.currentx + 10;
                animatedcircle.Draw();

            }
        }
    }
}
