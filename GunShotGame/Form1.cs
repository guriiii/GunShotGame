﻿using System;
using System.Windows.Forms;

namespace GunShotGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Formrussian()).Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}