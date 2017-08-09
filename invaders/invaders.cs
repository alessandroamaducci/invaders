using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invaders
{
    public partial class invaders : Form
    {
        BombsManager bombsmanager;
        public invaders()
        {
            InitializeComponent();
            bombsmanager = new BombsManager(this);
            
        }
    }
}
