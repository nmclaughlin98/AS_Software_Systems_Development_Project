﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSplash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            tmrSplash.Stop();
            this.Hide();
            frmLoginRegister NextScreen = new frmLoginRegister();
            NextScreen.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            timer1.Enabled = true;
            timer1.Start();
            //timer1.Interval = 1000;
            progressBar1.Maximum = 4;
            
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        
        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 4)
            {
                progressBar1.Value++;
                
               
            }
            else
            {
                timer1.Stop();
                
            }
            
        }
    }
}
