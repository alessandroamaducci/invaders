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
     public class Bomb
    {
        Form form;
        public int currentx = 0;
        public int velocity = 1;
        private int currenty = 0;
        public int Currenty
        {
            get
            {
                return currenty;
            }
            set
            {
                currenty = value;
                form.Refresh();
            }
        }
        public Bomb(Form form)
        {
            this.form = form;
            this.form.Paint += Form_Paint;
            form.Refresh();
            //Debugger.Break();
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        public void Draw(Graphics g)
        { 
            Rectangle rectangle = new Rectangle(currentx, currenty, 10, 10);
         
            g.DrawEllipse(System.Drawing.Pens.Black, rectangle);
            g.FillEllipse(Brushes.Aqua, rectangle);
        }
    }
}
