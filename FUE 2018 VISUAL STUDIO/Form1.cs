﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUE_2018_VISUAL_STUDIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radiodiff1_CheckedChanged(object sender, EventArgs e)
        {
            diff1 = m * 9.81 - r * v;
            

        }
    }
}
