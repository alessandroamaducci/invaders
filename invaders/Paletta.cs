using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invaders
{
    class Paletta
    {
        int palettaweight = 25;
        public Form form1;
        public int currentx = 0;
        public  int currenty = 0;
        public Graphics g;
        public Paletta(Form f)
        {
            form1 = f;
            currenty = form1.ClientSize.Height - palettaweight;
            form1.KeyDown += Form1_KeyDown;
            form1.Paint += Form1_Paint;
            form1.Refresh();
        }

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Left)
            {
                currentx = currentx - 1;
                form1.Refresh();

            }
            if (e.KeyCode == System.Windows.Forms.Keys.Right)
            {
                currentx = currentx + 7;
                form1.Refresh();

            }
        }

        public void Draw(Graphics g)
        { 
            Rectangle rectangle = new Rectangle(currentx, currenty,50 , palettaweight);
            SolidBrush bluebrush = new SolidBrush(Color.Blue);
            g.FillRectangle(bluebrush, rectangle);
        }
    }
}
