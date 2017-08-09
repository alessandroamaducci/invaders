using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace invaders
{
    class BombsManager
    {
        Form form;
        int youfail = 0;
        bool failed = false;
        Paletta paletta;
        List<Bomb> Bombs = new List<Bomb>();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timerstring = new System.Windows.Forms.Timer();
        public BombsManager(Form form)
        {
            this.form = form;
            this.form.Paint += Form_Paint;
            paletta = new Paletta(form);
            Random rand = new Random();

            Bomb bomb = new Bomb(form);
            bomb.currentx = rand.Next(0, form.ClientSize.Width);
            bomb.velocity = rand.Next(2, 6);
            Bombs.Add(bomb);

            bomb = new Bomb(form);
            bomb.currentx = rand.Next(0, form.ClientSize.Width);
            bomb.velocity = rand.Next(2, 6);
            Bombs.Add(bomb);

            bomb = new Bomb(form);
            bomb.currentx = rand.Next(0, form.ClientSize.Width);
            bomb.velocity = rand.Next(2, 6);
            Bombs.Add(bomb);

            timer.Interval = 25;
            timer.Tick += Timer_Tick;
            timer.Start();
            timerstring.Interval = 100;
            timerstring.Tick += Timerstring_Tick;
            timerstring.Start();
        }

        private void Timerstring_Tick(object sender, EventArgs e)
        {
            if (youfail > 0)
            {
                youfail--;
            }
        }
        string[] nomi = { "sofia", "alessandro", "gigi" };
        string[] insulti = { "brutta", "scema", "bella" };
        private void Form_Paint(object sender, PaintEventArgs e)
        {
            if (youfail > 0)
            {
                Random r = new Random();
                string message = "sofia è scema";// nomi[r.Next(0, nomi.Length - 1)] + " è " + insulti[r.Next(0, insulti.Length - 1)];
                System.Drawing.Font font = new System.Drawing.Font("Gigi", (10-youfail)*5+1);
                SizeF s = e.Graphics.MeasureString(message, font);
                float x = form.ClientSize.Width / 2 - s.Width / 2;
                e.Graphics.DrawString(message, font, System.Drawing.Brushes.Crimson,x,form.ClientSize.Height/2);
            }
            else
            {
                failed = false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach(Bomb bomb in Bombs)
            {
                bomb.Currenty += bomb.velocity;
                if (checkCollision(bomb))
                {
                    bomb.velocity = -bomb.velocity; 
                } 
               if (bomb.currenty < 0)
                {
                    bomb.velocity = -bomb.velocity;
                }
                if (bomb.currenty > form.ClientSize.Height && youfail==0)
                {
                    bomb.currenty = 0;
                    youfail = 10;
                }
            }
        }
        private bool checkCollision(Bomb bomb)
        {
            bool kick = false;
            if (bomb.currenty > paletta.currenty)
            {
                if (bomb.currentx > paletta.currentx && bomb.currentx+bomb.size<paletta.currentx+paletta.width) 
                {
                    kick = true;
                }
            }
            return kick;
        }
    }
}
