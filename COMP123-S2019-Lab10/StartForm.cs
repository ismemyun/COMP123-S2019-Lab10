﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            //StartForm startForm = new StartForm();
            //startForm.Hide();
            //this.Hide();
            //Program.startForm.Hide();
            Hide();
            //MainForm mainForm = new MainForm();
            //mainForm.Show();
            Program.mainForm.Show();

        }
    }
}
