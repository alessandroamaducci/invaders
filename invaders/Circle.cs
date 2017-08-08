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
    class Circle
    {
        Form form;
        public int currentx = 0;
        public  int currenty = 0;
        public Graphics g;
        public Circle(Form form)
        {
            this.form = form;
            this.form.Paint += Form_Paint;
            //Debugger.Break();
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        public void Draw(Graphics g)
        { 
            Rectangle rectangle = new Rectangle(currentx, currenty, 50, 50);
         
            g.DrawEllipse(System.Drawing.Pens.Black, rectangle);
        }
    }
}
