﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaibLab
{
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            InitializeComponent();

            player.URL = "./sample.mp4";
            
        }
    }
}
