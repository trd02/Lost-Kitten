﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LostKitten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2 T = new Form2();
            T.TopMost = true;
            T.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
