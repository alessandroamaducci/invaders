using System;
using System.Collections.Generic;
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
        List<Bomb> Bombs = new List<Bomb>();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public BombsManager(Form form)
        {
            this.form = form;
            Random rand = new Random();

            Bomb bomb = new Bomb(form);
            bomb.currentx = rand.Next(0, form.ClientSize.Width);
            bomb.velocity = rand.Next(0, 5);
            Bombs.Add(bomb);

            bomb = new Bomb(form);
            bomb.currentx = rand.Next(0, form.ClientSize.Width);
            bomb.velocity = rand.Next(0, 5);
            Bombs.Add(bomb);

            bomb = new Bomb(form);
            bomb.currentx = rand.Next(0, form.ClientSize.Width);
            bomb.velocity = rand.Next(0, 5);
            Bombs.Add(bomb);

            timer.Interval = 50;
            timer.Tick += Timer_Tick; ;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach(Bomb bomb in Bombs)
            {
                bomb.Currenty += bomb.velocity;
            }
        }
    }
}
