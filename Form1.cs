﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar.Visible = true;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureboxMostrar2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureboxMostrar2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pictureBoxMostrar.Visible = false;
            this.pictureboxMostrar2.Visible = false;
        }
    }
}
