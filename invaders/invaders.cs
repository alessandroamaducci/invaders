﻿using System;
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
        Paletta paletta;
        public invaders()
        {
            InitializeComponent();
            paletta = new Paletta(this);
        }
    }
}